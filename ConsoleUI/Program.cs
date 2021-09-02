using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion

            var vehicles = new List<Vehicle>();

            var car1 = new Car() {Year = 2000, Make="Ford", Model= "Focus", HasTrunk = true};
            var cycle1 = new Motorcycle() { Year = 2010, Make = "Harley", Model = "Cruiser", HasSideCar = true};
            var vehicle1 = new Car() { Year = 2005, Make = "Honda", Model = "Accord", HasTrunk = true };
            var vehicle2 = new Motorcycle() { Year = 1998, Make = "Honda", Model = "Sports bike", HasSideCar = false };

            vehicles.Add(car1);
            vehicles.Add(cycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.getStats();

            }
            Console.WriteLine("-------------------");
            
            car1.DriveAbstract();
            car1.DriveVirtual();
            cycle1.DriveAbstract();
            cycle1.DriveVirtual();
           


            Console.ReadLine();
        }
    }
}
