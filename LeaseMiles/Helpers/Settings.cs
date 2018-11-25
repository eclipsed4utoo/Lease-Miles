// Helpers/Settings.cs
using System;
using Xamarin.Essentials;

namespace LeaseMiles.Helpers
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class Settings
    {
        #region Setting Constants

        private const string CarBuyDateKey = "buy_date";
        private static readonly DateTime CarBuyDateDefault = DateTime.Today;

        private const string MilesPerYearKey = "miles_year";
        private static readonly int MilesPerYearDefault = 10000;

        #endregion


        public static DateTime CarBuyDate
        {
            get { return Preferences.Get(CarBuyDateKey, CarBuyDateDefault); }
            set { Preferences.Set(CarBuyDateKey, value); }
        }

        public static int MilesPerYear
        {
            get { return Preferences.Get(MilesPerYearKey, MilesPerYearDefault); }
            set { Preferences.Set(MilesPerYearKey, value); }
        }
    }
}