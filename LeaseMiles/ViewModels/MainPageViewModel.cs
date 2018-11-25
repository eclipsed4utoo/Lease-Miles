using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LeaseMiles.Helpers;

namespace LeaseMiles
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public DateTime CarBuyDate
        {
            get { return Settings.CarBuyDate; }
            set 
            { 
                Settings.CarBuyDate = value; 
                OnPropertyChanged();
                OnPropertyChanged("DaysSinceContractStart");
                OnPropertyChanged("AverageMilesPerDay");
                OnPropertyChanged("TotalMilesAllowed");
            }
        }

        public int MilesPerYear
        {
            get { return Settings.MilesPerYear; }
            set 
            {
                Settings.MilesPerYear = value; 
                OnPropertyChanged();
                OnPropertyChanged("DaysSinceContractStart");
                OnPropertyChanged("AverageMilesPerDay");
                OnPropertyChanged("TotalMilesAllowed");
            }
        }

        public DateTime MaxDatePickerDate
        {
            get { return DateTime.Today; }
        }

        public decimal DaysSinceContractStart
        {
            get 
            { 
                var days = (decimal)Math.Round((DateTime.Today - CarBuyDate).TotalDays, 0);
                if (days <= 0)
                    return 0;

                return days;
            }
        }

        public decimal AverageMilesPerDay
        {
            get { return Math.Round(MilesPerYear / 365M, 1); }
        }

        public decimal TotalMilesAllowed
        {
            get
            {
                return Math.Round(DaysSinceContractStart * AverageMilesPerDay, 0);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;
            changed(this, new PropertyChangedEventArgs(name));
        }
    }
}
