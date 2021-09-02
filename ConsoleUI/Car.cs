using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public bool HasTrunk { get; internal set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"You are driving a {Year} {Make} {Model} and does it have a trunk, {HasTrunk}.");
        }
       

        public override void getStats()
        {
            Console.WriteLine($"Stats: {Year}, {Make}, {Model}, Has trunk {HasTrunk}");
        }
    }
}
