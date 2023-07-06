using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicles
    {
        public bool HasSideCar { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle's engine sputters to life and streaks down the road");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle's virtual Drive Method");
        }
    }
}
