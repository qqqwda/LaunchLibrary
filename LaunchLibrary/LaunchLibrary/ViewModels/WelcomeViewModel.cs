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
            //LoadLaunch();
        }

<<<<<<< HEAD
        public ICommand InfoPage()
        {
            return new RelayCommand(GoToInfoPage);
        }

        private async void GoToInfoPage()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new InfoPage());
        }

        private async void LoadLaunch()
=======
        public ICommand AgenciesCommand
>>>>>>> 6c5489f85524e0f608563aafd364d6aa2de5a056
        {
            get
            {
<<<<<<< HEAD
                await Application.Current.MainPage.DisplayAlert("Error", connection.Message, "OK");
                return;
=======
                return new RelayCommand(GoToAgenciesPage);
>>>>>>> 6c5489f85524e0f608563aafd364d6aa2de5a056
            }
        }

<<<<<<< HEAD
            var response = await this.apiService.GetLaunchs<Launchs>(
                "https://launchlibrary.net",
                "/1.4/launch",
                "/next/3");
            //https://launchlibrary.net/1.4/launch/next/1

            var launches = (List<Launch>)response.Launches;













=======
        public ICommand RocketsCommand
        {
            get
            {
                return new RelayCommand(GoToRocketsPage);
            }
>>>>>>> 6c5489f85524e0f608563aafd364d6aa2de5a056
        }

        private async void GoToRocketsPage()
        {
            MainViewModel.GetInstance().Rockets = new RocketsViewModel();
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new RocketsPage()));
            
        }

        private async void GoToAgenciesPage()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new AgenciesPage()));
            return;
        }
        
    }
}
