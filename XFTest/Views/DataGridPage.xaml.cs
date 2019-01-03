using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XFTest.ViewModels;
using XFTest.Models;
using Xamarin.Forms.DataGrid;

namespace XFTest.Views
{
    public partial class DataGridPage : ContentPage
    {
        public DataGridPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (sender is DataGrid r)
                if (r.SelectedItem is RetListResult item)
                    await Navigation.PushAsync(new ItemPage(item));
        }
    }
}
