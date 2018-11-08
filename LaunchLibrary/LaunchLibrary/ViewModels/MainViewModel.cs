using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibrary.ViewModels
{
    public class MainViewModel
    {
        public WelcomeViewModel Welcome { get; set; }
        public LaunchesViewModel Launches { get; set; }

        public MainViewModel()
        {
            this.Launches = new LaunchesViewModel();
            this.Welcome = new WelcomeViewModel();
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
