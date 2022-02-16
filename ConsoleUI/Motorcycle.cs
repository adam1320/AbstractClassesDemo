using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        { }

        public string EngineConfiguration { get; set; } = "V-Twin";
        public override void DriveAbstract()
        {
            Console.WriteLine($"This motorcycle drives ABSTRACT!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This motorcycle drives VIRTUAL!");
        }

    }
    
}
