using LosePanel.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LosePanel.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}