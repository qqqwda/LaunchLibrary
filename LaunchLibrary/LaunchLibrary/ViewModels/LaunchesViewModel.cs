<<<<<<< HEAD
﻿using LaunchLibrary.Models;
=======
﻿using GalaSoft.MvvmLight.Command;
using LaunchLibrary.Models;
>>>>>>> 6c5489f85524e0f608563aafd364d6aa2de5a056
using LaunchLibrary.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
<<<<<<< HEAD
=======
using System.Windows.Input;
>>>>>>> 6c5489f85524e0f608563aafd364d6aa2de5a056
using Xamarin.Forms;

namespace LaunchLibrary.ViewModels
{
    public class LaunchesViewModel : BaseViewModel
    {
        private ApiService apiService;
        private ObservableCollection<Launch> launches;
<<<<<<< HEAD
=======
        private bool isRefreshing;

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }


>>>>>>> 6c5489f85524e0f608563aafd364d6aa2de5a056

        public ObservableCollection<Launch> Launches
        {
            get { return this.launches; }
            set { SetValue(ref this.launches, value); }
        }

        public LaunchesViewModel()
        {
<<<<<<< HEAD
=======
            this.isRefreshing = false;
>>>>>>> 6c5489f85524e0f608563aafd364d6aa2de5a056
            this.apiService = new ApiService();
            this.LoadLaunches();
        }

<<<<<<< HEAD
        private async void LoadLaunches()
        {
=======
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
>>>>>>> 6c5489f85524e0f608563aafd364d6aa2de5a056
            var connection = await this.apiService.CheckConnection();

            if (!connection.IsSuccess)
            {
<<<<<<< HEAD
                await Application.Current.MainPage.DisplayAlert("Error", connection.Message, "OK");
                return;
            }

=======
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert("Error", connection.Message, "OK");
                return;

            }
            #endregion

            //https://launchlibrary.net/1.4/launch/next/1
>>>>>>> 6c5489f85524e0f608563aafd364d6aa2de5a056
            var response = await this.apiService.GetLaunchs<Launchs>(
                "https://launchlibrary.net",
                "/1.4/launch",
                "/next/3");
<<<<<<< HEAD
            //https://launchlibrary.net/1.4/launch/next/1

            var list = (List<Launch>)response.Launches;
            this.Launches = new ObservableCollection<Launch>(list);

            foreach (var item in Launches)
            {
                if (item.Missions == null)
                {

                }
            }


        }
    }
}
=======


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
>>>>>>> 6c5489f85524e0f608563aafd364d6aa2de5a056
