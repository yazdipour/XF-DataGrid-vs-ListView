
using Xamarin.Forms;
using System.ComponentModel;
using XFTest.ViewModels;

namespace XFTest.Views
{
    public partial class ItemPage : ContentPage, INotifyPropertyChanged
    {
        public ItemPage(Models.RetListResult item)
        {
            InitializeComponent();
            BindingContext = new ItemPageViewModel(item);
        }
    }
}
