using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
   public class Cookie
    {
        public string Name { get; set; }
        public bool Hasnuts { get; set; }
        public double GramsOfFlour { get; set; }
    }

    public enum VehicleType { Car,Van,Truck}

    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeofVehicle { get; set; }

    }

    public class Order
    {
        public string CustomerName { get; set; }
        public Cookie OrderedProduct { get; set; }

        public decimal TotalCost { get; set; }
    }

}
