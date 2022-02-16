using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        { }
        public string CarType { get; set; } = "SportsCar";
        public override void DriveAbstract()
        {
            Console.WriteLine($"I drive this car ABSTRACT!");
        }
    }
    
    
}
