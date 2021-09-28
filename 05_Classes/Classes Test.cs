using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Something else";

          
        }

        [TestMethod]

        public void VehicleTests()
        {
            Vehicle car = new Vehicle();
            car.TypeofVehicle = VehicleType.Car;
        }
    }
}
