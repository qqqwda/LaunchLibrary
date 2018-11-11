using LaunchLibrary.Models;
using LaunchLibrary.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace LaunchLibrary.ViewModels
{
    public class LaunchesViewModel : BaseViewModel
    {
        private ApiService apiService;
        private ObservableCollection<Launch> launches;

        public ObservableCollection<Launch> Launches
        {
            get { return this.launches; }
            set { SetValue(ref this.launches, value); }
        }

        public LaunchesViewModel()
        {
            this.apiService = new ApiService();
            this.LoadLaunches();
        }

        private async void LoadLaunches()
        {
            var connection = await this.apiService.CheckConnection();

            if (!connection.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error",connection.Message,"OK");
                return;
            }

            var response = await this.apiService.GetLaunchs<Launchs>(
                "https://launchlibrary.net",
                "/1.4/launch",
                "/next/6");
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
