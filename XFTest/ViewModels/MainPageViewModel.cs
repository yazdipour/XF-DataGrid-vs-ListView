using System;
using XFTest.Models;
using System.Collections.ObjectModel;
using XFTest.Services;
using Xamarin.Forms.Internals;
using System.ComponentModel;
using System.Diagnostics;

namespace XFTest.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<RetListResult> ListViewItems { get; set; } = new ObservableCollection<RetListResult>();

        public MainPageViewModel() => LoadItems();

        private async void LoadItems()
        {
            try
            {
                if (ListViewItems?.Count != 0) return;
                var result = await ApiHandler.Api?.GetRetList();
                result?.RetListResult?.ForEach((item) => ListViewItems.Add(item));
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add => ((INotifyPropertyChanged)ListViewItems).PropertyChanged += value;
            remove => ((INotifyPropertyChanged)ListViewItems).PropertyChanged -= value;
        }
    }
}

