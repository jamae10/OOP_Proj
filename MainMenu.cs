using System;
using System.Diagnostics;

namespace OOP_Proj
{
    class MainMenu
    {
        public static int choiceMainMenu, fchoiceMainMenu, fchoiceSimple, fchoiceSelection,fchoiceIteration, fchoiceArray;
        static void Main(string[] args)
        {
            Boolean loop = true;
            do
            {
                //creating objects for each class
                MainMenu disp = new MainMenu();
                SimpleProg opt1 = new SimpleProg();
                SelectionProg opt2 = new SelectionProg();
                IterationProg opt3 = new IterationProg();
                ArrayProg opt4 = new ArrayProg();
            
                disp.displayMainMenu();
                fchoiceMainMenu = disp.getMainMenu();

                switch(fchoiceMainMenu)
                {
                    case 1:
                        Boolean s = true;
                        while (s)
                        {
                            opt1.displaySimpleMenu();
                            fchoiceSimple = opt1.getOptSimple();
                            if (fchoiceSimple == 1)
                            {
                                opt1.SimpleOpt1();
                            }
                            else if (fchoiceSimple == 2)
                            {
                                opt1.SimpleOpt2();
                            }
                            else if (fchoiceSimple == 3)
                            {
                                opt1.SimpleOpt3();
                            }
                            else if (fchoiceSimple == 4)
                            {
                                opt1.SimpleOpt4();
                            }
                            else if (fchoiceSimple == 5)
                            {
                                disp.displayMainMenu();
                                break;
                            }

                        }
                        
                        break;

                    case 2:
                        opt2.displaySelectionMenu();
                        fchoiceSelection = opt2.getOptSelection();
                        break;

                    case 3:
                        opt3.displayIterationMenu();
                        fchoiceIteration = opt3.getOptIteration();
                        break;

                    case 4:
                        opt4.displayArrayMenu();
                        fchoiceArray = opt4.getOptArray();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;
                }

                break;
            } while (loop);
        }

        //display main menu
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
                choiceMainMenu = Convert.ToInt32(Console.ReadLine());

                if (choiceMainMenu <= 0 || choiceMainMenu > 5)
                {
                    Console.WriteLine("Invalid Choice of Number. Please Try Again.\n");
                }

                else { break; }
            }
            return choiceMainMenu;
        }

    }
}
