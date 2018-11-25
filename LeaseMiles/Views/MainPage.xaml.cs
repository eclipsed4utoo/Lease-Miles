using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LeaseMiles
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();
        }
    }
}
