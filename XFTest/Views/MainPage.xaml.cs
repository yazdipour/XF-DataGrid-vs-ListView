using Xamarin.Forms;
using XFTest.Models;
using XFTest.ViewModels;

namespace XFTest.Views
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel mainPageViewModel = new MainPageViewModel();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
        }

        async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            if (e.Item is RetListResult item)
                await Navigation.PushAsync(new ItemPage(item));
        }
    }
}
