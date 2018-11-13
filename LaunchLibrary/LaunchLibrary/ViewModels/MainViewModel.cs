using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibrary.ViewModels
{
    public class MainViewModel
    {
        public WelcomeViewModel Welcome { get; set; }
        public LaunchesViewModel Launches { get; set; }
        public MainPage MainPage { get; set; }

        public MainViewModel()
        {
            this.Welcome = new WelcomeViewModel();
            this.Launches = new LaunchesViewModel();
            this.MainPage = new MainPage();

        }

        #region Singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();

            }
            else
            {
                return instance;
            }
        }
        #endregion


    }
}
