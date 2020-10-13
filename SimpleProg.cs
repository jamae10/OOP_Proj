using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Proj
{
    class SimpleProg
    {
        public int choiceSimple;
        public int num1, num2, sum; //option 1
        public void displaySimpleMenu()
        {
            Console.WriteLine("================================");
            Console.WriteLine($"{" ",-12}{"Simple Program Menu",-10}");
            Console.WriteLine("================================");
            Console.WriteLine("[1] Adding 2 Input Numbers ");
            Console.WriteLine("[2] Area of the Circle using an Input Number");
            Console.WriteLine("[3] Average of 2 Input Numbers");
            Console.WriteLine("[4] Displaying Full Name with Input First Name and Last Name");
            Console.WriteLine("[5] Back to Main Menu");
            Console.WriteLine("================================");

        }

        public int getOptSimple()
        {
            Boolean cc = true;

            while (cc)
            {
                Console.WriteLine("Enter Number of Choice: ");
                choiceSimple = Convert.ToInt32(Console.ReadLine());

                if (choiceSimple <= 0 || choiceSimple > 5)
                {
                    Console.WriteLine("Invalid Choice of Number. Please Try Again.\n");
                }

                else { break; }
            }
            return choiceSimple;
        }
        
        public  void SimpleOpt1()
        {
            Console.WriteLine("Enter 1st Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;
            Console.WriteLine("{0} + {1} = {3}",num1,num2,sum);
        }

        public double SimpleOpt2()
        {

        }

        public double SimpleOpt3()
        {

        }

        public string SimpleOpt4()
        {

        }

    }
}
