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

        public ICommand AgenciesCommand
        {
            get
            {
                return new RelayCommand(GoToAgenciesPage);
            }
        }

        public ICommand RocketsCommand
        {
            get
            {
                return new RelayCommand(GoToRocketsPage);
            }
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
