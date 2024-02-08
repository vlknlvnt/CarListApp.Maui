using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListApp.Maui.Models

{
    public class Car : BaseEntity
    {
        /* every car has an id, make, model and vin */
        public int id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; } 
        
        /* acronym for Veichle Identification Number */
        public string Vin { get; set; }
    }
}
