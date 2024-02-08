using CarListApp.Maui.ViewModels;

namespace CarListApp.Maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage(CarListViewModel carListViewModel) // get a copy of carlistviewmodel
        {
            InitializeComponent();
            BindingContext = carListViewModel; // bind carlistviewmodel to context
        }
    }

}
