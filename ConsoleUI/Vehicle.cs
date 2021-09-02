using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public int Year { get; set; } = 0;
        public string Make { get; set; } = "unknown";
        public string Model { get; set; }="unknown";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"Virtual: {Year}, {Make}, {Model}");
        }

        public abstract void getStats();
       

            





    }
}
