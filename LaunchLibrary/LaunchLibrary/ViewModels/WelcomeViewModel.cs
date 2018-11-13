using GalaSoft.MvvmLight.Command;
using LaunchLibrary.Models;
using LaunchLibrary.Services;
using LaunchLibrary.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
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

        public ICommand InfoPage()
        {
            return new RelayCommand(GoToInfoPage);
        }

        private async void GoToInfoPage()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new InfoPage());
        }

        private async void LoadLaunch()
        {
            var connection = await this.apiService.CheckConnection();
            if (!connection.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", connection.Message, "OK");
                return;
            }

            var response = await this.apiService.GetLaunchs<Launchs>(
                "https://launchlibrary.net",
                "/1.4/launch",
                "/next/3");
            //https://launchlibrary.net/1.4/launch/next/1

            var launches = (List<Launch>)response.Launches;













        }
    }
}
