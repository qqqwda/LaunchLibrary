using LaunchLibrary.Models;
using LaunchLibrary.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace LaunchLibrary.ViewModels
{
    public class RocketsViewModel : BaseViewModel
    {
        private ObservableCollection<Rocket> rockets;
        private ApiService apiService;

        public ObservableCollection<Rocket> Rockets
        {
            get { return this.rockets; }
            set { SetValue(ref this.rockets, value); }
        }


        public RocketsViewModel()
        {
            this.apiService = new ApiService();
            LoadRockets();
        }

        private async void LoadRockets()
        {
            var connection = await this.apiService.CheckConnection();

            if (!connection.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", connection.Message,"OK");
                return;
            }

            var response = await this.apiService.GetRockets<RootRockets>(
                "https://launchlibrary.net",
                "/1.4/rocket/next/8");

            var list = (List<Rocket>)response.Rockets;
            this.Rockets = new ObservableCollection<Rocket>(list);
            
            
        }
    }
}
