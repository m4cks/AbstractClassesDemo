using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /*
    * Create an abstract class called Vehicle
    * The vehicle class shall have three string properties Year, Make, and Model
    * Set the defaults to something generic in the Vehicle class
    * Vehicle shall have an abstract method called DriveAbstract with no implementation
    * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
    */

    internal abstract class Vehicle
    {
        public string Name = "Vehicle";
        public string Make = "Default";
        public string Year = "0000";

        public abstract void DriveAbstract();
        

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Driving virtually");
        }
    }
}
