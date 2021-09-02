using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; internal set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"You are driving a {Year} {Make} {Model} and does it have a side car {HasSideCar}.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"Virtual: {Year}, {Make}, {Model}");

        }

        public override void getStats()
        {
            Console.WriteLine($"Stats: {Year}, {Make}, {Model}, Has Side Car {HasSideCar}");
        }
    }
}
