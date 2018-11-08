using LaunchLibrary.Models;
using LaunchLibrary.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LaunchLibrary.ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        private ApiService apiService;

        public WelcomeViewModel()
        {
            this.apiService = new ApiService();
            LoadLaunch();
        }
        private async void LoadLaunch()
        {
            var connection = await this.apiService.CheckConnection();
            if (!connection.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error",connection.Message,"OK");
                return;
            }

            var response = await this.apiService.GetList<Launchs>(
                "https://launchlibrary.net",
                "/1.4/launch",
                "/next/1");
            //https://launchlibrary.net/1.4/launch/next/1

            if (!response.IsSuccess)
            {
                
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "OK");

                return;
            }
        }
    }
}
