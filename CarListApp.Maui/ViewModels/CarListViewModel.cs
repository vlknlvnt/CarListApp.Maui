using CarListApp.Maui.Models;
using CarListApp.Maui.Services;
using CarListApp.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListApp.Maui.ViewModels
{

    public partial class CarListViewModel : BaseViewModel
    {
        private readonly CarService carService;
        public ObservableCollection<Car> Cars { get; private set; } = new(); // create a new car list every time

        public CarListViewModel(CarService carService) {
            Title = "Car List Title";
            this.carService = carService;
        }

        [ObservableProperty]
        bool isRefreshing;

        [RelayCommand]
        async Task GetCarList()
        {
            if(IsLoading) return;
            try
            {
                IsLoading = true;
                if (Cars.Any()) Cars.Clear(); // if there is any car in Cars list, clear

                var cars = carService.GetCars(); // define cars
                foreach (var car in cars) // every car will be added in Cars list
                {
                    Cars.Add(car);
                }
            }
            catch(Exception ex) 
            {
                Debug.WriteLine($"Unable to get cars: {ex.Message}");
                await Shell.Current.DisplayAlert("Error", "Failed to retrieve list of cars.", "Ok");
            }
            finally
            {
                IsRefreshing = false; // refresh stops
                IsLoading = false; // either car list created or failed to be created, loading session ends
            }
        }

        [RelayCommand]
        async Task GetCarDetails(Car car)
        {
            if(car == null) return;

            await Shell.Current.GoToAsync(nameof(CarDetailsPage), true, new Dictionary<string, object>
            {
                {nameof(Car), car }
            });
        }
    }
}
