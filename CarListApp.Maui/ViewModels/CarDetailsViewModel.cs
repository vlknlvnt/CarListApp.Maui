using CarListApp.Maui.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListApp.Maui.ViewModels
{
    [QueryProperty(nameof(Car), "Car")] // property gets car name and id
    public partial class CarDetailsViewModel : BaseViewModel
    {
        [ObservableProperty] // property gets car's items (id, model, vin etc..)
        Car car;
    }

    /*public CarDetailsViewModel()
    {
        Title = $"Car Details - {car.Make} {car.Model}";
    }*/
}
