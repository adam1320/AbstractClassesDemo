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
            var vehicles = new List<Vehicle>();
            var Car1 = new Car() { CarType = "SportsCar", Make = "Ferrari", Model = "458 Italia", Year = 2020 };
            var Motorcycle1 = new Motorcycle() { EngineConfiguration = "V-Twin", Make = "Harley Davidson", Model = "Fat Boy", Year = 2020 };
            Vehicle Vehicle1 = new Car() { CarType = "Truck", Make = "Chevrolet", Model = "3500", Year = 2020 };
            Vehicle Vehicle2 = new Car() { CarType = "Touring", Make = "Cadillac", Model = "CTS-V", Year = 2020 };

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
            
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(Vehicle1);
            vehicles.Add(Vehicle2);
            vehicles.Add(Car1);
            vehicles.Add(Motorcycle1);
            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model} ");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();

            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
