using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LaunchLibrary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage ()
        {
            InitializeComponent();

            Children.Add(new WelcomePage() { Title ="Welcome"});
            Children.Add(new LaunchesPage() { Title="Next Launches"});
            Children.Add(new MainPage() { Title="Main page"});
        }
    }
}