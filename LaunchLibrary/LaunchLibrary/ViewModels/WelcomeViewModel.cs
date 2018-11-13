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
            //LoadLaunch();
        }
        private async void LoadLaunch()
        {
            
        }
    }
}
