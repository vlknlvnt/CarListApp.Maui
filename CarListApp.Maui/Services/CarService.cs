using CarListApp.Maui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListApp.Maui.Services
{
    public class CarService
    {
        public List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car
                {
                    id = 1, Make = "Honda", Model = "Fit", Vin = "123"
                },
                new Car
                {
                    id = 2, Make = "Toyota", Model = "Prado", Vin = "123"
                },
                new Car
                {
                    id = 3, Make = "Honda", Model = "Civic", Vin = "123"
                },
                new Car
                {
                    id = 4, Make = "Audi", Model = "A5", Vin = "123"
                },
                new Car
                {
                    id = 5, Make = "BMW", Model = "M3", Vin = "123"
                },
                new Car
                {
                    id = 6, Make = "Mercedes", Model = "EVM3", Vin = "123"
                },
                new Car
                {
                    id = 7, Make = "Toyota", Model = "Prado II", Vin = "123"
                },
                new Car
                {
                    id = 8, Make = "Honda", Model = "Accord", Vin = "123"
                },
                new Car
                {
                    id = 9, Make = "Honda", Model = "Mustang", Vin = "123"
                },
                new Car
                {
                    id = 10, Make = "BMW", Model = "M8", Vin = "123"
                }
            };
        }
    }
}
