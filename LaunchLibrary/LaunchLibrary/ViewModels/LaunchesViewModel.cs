using GalaSoft.MvvmLight.Command;
using LaunchLibrary.Models;
using LaunchLibrary.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LaunchLibrary.ViewModels
{
    public class LaunchesViewModel : BaseViewModel
    {
        private ApiService apiService;
        private ObservableCollection<Launch> launches;
        private bool isRefreshing;

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }



        public ObservableCollection<Launch> Launches
        {
            get { return this.launches; }
            set { SetValue(ref this.launches, value); }
        }

        public LaunchesViewModel()
        {
            this.isRefreshing = false;
            this.apiService = new ApiService();
            this.LoadLaunches();
        }

        #region Commands
        public ICommand RefreshCommand
        {
            get{ return new RelayCommand(LoadLaunches); }
            
        }

        #endregion

        #region Methods

        private async void LoadLaunches()
        {
            this.IsRefreshing = true;
            #region CheckConnection
            var connection = await this.apiService.CheckConnection();

            if (!connection.IsSuccess)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert("Error", connection.Message, "OK");
                return;

            }
            #endregion

            //https://launchlibrary.net/1.4/launch/next/1
            var response = await this.apiService.GetLaunchs<Launchs>(
                "https://launchlibrary.net",
                "/1.4/launch",
                "/next/3");


            if (response == null)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert("Error", "Can't reach the response", "OK");
                return;
            }

            var list = (List<Launch>)response.Launches;
            this.Launches = new ObservableCollection<Launch>(list);
            if (this.Launches.Count > 0)
            {
                this.IsRefreshing = false;
            }
            

        }

        #endregion
    }
 }
