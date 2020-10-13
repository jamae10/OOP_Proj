using System;

namespace OOP_Proj
{
    class MainMenu
    {
        public static int choice, fchoice;
        static void Main(string[] args)
        {
            Boolean loop = true;
            do
            {
                //creating objects for each class
                MainMenu disp = new MainMenu();
                ArithMetic opt1 = new ArithMetic();
                StringProb opt2 = new StringProb();
                UnitConv opt3 = new UnitConv();
                SortingArr opt4 = new SortingArr();
                MathClass opt5 = new MathClass();

                disp.displayMainMenu();
                fchoice = disp.getMainMenu();


                break;
            } while (loop);
        }

        public void displayMainMenu()
        {
            Console.WriteLine("================================");
            Console.WriteLine($"{" ",-12}{"Main Menu",-10}");
            Console.WriteLine("================================");
            Console.WriteLine("[1] Simple Program ");
            Console.WriteLine("[2] Selection Program");
            Console.WriteLine("[3] Iteration Program");
            Console.WriteLine("[4] Array Program");
            Console.WriteLine("[5] Exit");
            Console.WriteLine("================================");

        }

        //get user input in Main Menu
        public int getMainMenu()
        {
            Boolean cc = true;

            while (cc)
            {
                Console.WriteLine("Enter Number of Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice <= 0 || choice > 5)
                {
                    Console.WriteLine("Invalid Choice of Number. Please Try Again.\n");
                }

                else { break; }
            }
            return choice;
        }

    }
}
