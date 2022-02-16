using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        
        public Vehicle()
        {
        }
        public int Year { get; set; } = 1900;
        public string Make { get; set; } = "manufacturer";
        public string Model { get; set; } = "vehicle model";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"I drive this { GetType().Name} VIRTUAL!");
        }


    }
}
