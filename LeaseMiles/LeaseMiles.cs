using System;

using Xamarin.Forms;

namespace LeaseMiles
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.FromHex("#77CFF2"), BarTextColor = Color.White };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
