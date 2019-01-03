using System;
using System.ComponentModel;
using Xamarin.Forms.Internals;
using XFTest.Models;
using XFTest.Services;

namespace XFTest.ViewModels
{
    public class ItemPageViewModel : INotifyPropertyChanged
    {
        private RetListResult item;
        public string No1 { get; set; }
        public string Nmuber1 { get; set; }
        public string No2 { get; set; }
        public string Address1 { get; set; }
        public string Date1 { get; set; }

        public ItemPageViewModel(RetListResult item)
        {
            this.item = item;
            LoadDetails();
        }

        private async void LoadDetails()
        {
            var retItem = await ApiHandler.Api.GetRetItem(item.No1, item.Date1);
            var splitted = SuperSplit(retItem?.RetItemResult);
            No1 = splitted[0] ?? "";
            OnPropertyChanged(nameof(No1));
            Nmuber1 = splitted[1] ?? "";
            OnPropertyChanged(nameof(Nmuber1));
            No2 = splitted[2] ?? "";
            OnPropertyChanged(nameof(No2));
            Address1 = splitted[3] ?? "";
            OnPropertyChanged(nameof(Address1));
            Date1 = splitted[4] ?? "";
            OnPropertyChanged(nameof(Date1));
        }
        private string[] SuperSplit(string data) => data.Split(new string[] { ";;;;" }, StringSplitOptions.None);

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
}

