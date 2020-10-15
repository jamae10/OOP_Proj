using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Proj
{
    class SimpleProg
    {
        public int choiceSimple;
        public int num1, num2, sum; //option 1
        public double r, areaOfCircle, area; // option 2 
        public double n1, n2, average, ave; //option 3
        public string fname, lname; //option 4

        //to display the Simple Sub Menu
        public void displaySimpleMenu()
        {
            Console.WriteLine("\n================================");
            Console.WriteLine($"{" ",-7}{"Simple Program Menu",-10}");
            Console.WriteLine("================================");
            Console.WriteLine("[1] Adding 2 Input Numbers ");
            Console.WriteLine("[2] Area of the Circle using an Input Number");
            Console.WriteLine("[3] Average of 2 Input Numbers");
            Console.WriteLine("[4] Displaying Full Name with Input First Name and Last Name");
            Console.WriteLine("[5] Back to Main Menu");
            Console.WriteLine("================================");

        }

        //returns user's choice in Simple Sub Menu
        public int getOptSimple()
        {
            Boolean cc = true;

            while (cc)
            {
                Console.Write("Enter Number of Choice: \n>> ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out choiceSimple))
                {
                    Console.WriteLine("!!Invalid Input. Please Try Again.!!\n");
                    continue;
                }
               
                if (choiceSimple <= 0 || choiceSimple > 5)
                {
                    Console.WriteLine("!!Invalid Choice of Number. Please Try Again.!!\n");
                }

                else { break; }
            }
            return choiceSimple;
        }

        //option 1 - Adding 2 Input Numbers
        public void SimpleOpt1()
        {
            Console.WriteLine("\n*****Adding 2 Input Numbers*****");
            Console.WriteLine("Enter 1st Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;
            Console.WriteLine($"\n{num1} + {num2} = {sum}");
        }

        //option 2 - Area of Circle
        public void SimpleOpt2()
        {
            Console.WriteLine("\n*****Area of Circle*****");
            Console.WriteLine("Enter Number of Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            areaOfCircle = (Math.PI * r) * 2;
            area = Math.Round((Double)areaOfCircle, 2);

            Console.WriteLine($"The Area of Circle is {area} ");
        }

        //option 3 - Average of 2 Numbers
        public void SimpleOpt3()
        {
            Console.WriteLine("\n*****Average of 2 Numbers*****");
            Console.WriteLine("Enter 1st Number: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            average = (n1 + n2) / 2;
            ave = Math.Round((Double)average, 2);
            Console.WriteLine($"The Average is {ave} ");
        }

        //option 4 - First Name and Last Name
        public void SimpleOpt4()
        {
            Console.WriteLine("\n*****First Name and Last Name*****");
            Console.WriteLine("Enter First Name: ");
            fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            lname = Console.ReadLine();

            Console.WriteLine($"The Full Name is {fname} {lname}");
        }

    }
}
