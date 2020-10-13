using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Proj
{
    class SimpleProg
    {
        public void displaySimpleMenu()
        {
            Console.WriteLine("================================");
            Console.WriteLine($"{" ",-12}{"Main Menu",-10}");
            Console.WriteLine("================================");
            Console.WriteLine("[1] Adding 2 Input Numbers ");
            Console.WriteLine("[2] Area of the Circle using an Input Number");
            Console.WriteLine("[3] Average of 2 Input Numbers");
            Console.WriteLine("[4] Displaying Full Name with Input First Name and Last Name");
            Console.WriteLine("[5] Back to Main Menu");
            Console.WriteLine("================================");

        }
    }
}
