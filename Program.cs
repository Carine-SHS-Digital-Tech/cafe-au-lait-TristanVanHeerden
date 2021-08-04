using System;

namespace Cafe_au_lai
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"
------------------------------------------------------------------------------------------------------------------
 ________  ________  ________ _______           ________  ___  ___          ___       ________  ___  _________   
|\   ____\|\   __  \|\  _____\\  ___ \         |\   __  \|\  \|\  \        |\  \     |\   __  \|\  \|\___   ___\ 
\ \  \___|\ \  \|\  \ \  \__/\ \   __/|        \ \  \|\  \ \  \\\  \       \ \  \    \ \  \|\  \ \  \|___ \  \_| 
 \ \  \    \ \   __  \ \   __\\ \  \_|/__       \ \   __  \ \  \\\  \       \ \  \    \ \   __  \ \  \   \ \  \  
  \ \  \____\ \  \ \  \ \  \_| \ \  \_|\ \       \ \  \ \  \ \  \\\  \       \ \  \____\ \  \ \  \ \  \   \ \  \ 
   \ \_______\ \__\ \__\ \__\   \ \_______\       \ \__\ \__\ \_______\       \ \_______\ \__\ \__\ \__\   \ \__\
    \|_______|\|__|\|__|\|__|    \|_______|        \|__|\|__|\|_______|        \|_______|\|__|\|__|\|__|    \|__|

------------------------------------------------------------------------------------------------------------------                                                                                                                                                                                                                                                                                                                
");
                    top:
                    Console.WriteLine(@"Please insert operation mode
option 1 : Start order
Option 2 : Raw dailty Statistics");
                    Console.WriteLine(@"Please select the operation");
                    int OperationoNum = Convert.ToInt32(Console.ReadLine());
                    switch (OperationoNum)
                    {
                        case 1: 
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"
Welcome to our establishment, wer're happy to have you here ^-^
please use the following text based system to order your beverages!
Note: only 4 drinks at maximum are allowed per customer as our stock is currently low!
");
                            float b1 = 2.25;
                            int b2 = 1;
                            int b3 = 1;
                            int b4 = 1;
                            
 Order:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Please select from the follwing beverages.");
                    Console.WriteLine("1 > Espresso        $2.25");
                           int Espresso =  Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2 > Ice Coffee      $2.50");
                            int Ice_coffee = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("3 > latte           $2.50");
                            int latte = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("4 > Cappuccino      $3.00");
                            int foam = Convert.ToInt32(Console.ReadLine());
                            {
                                Console.WriteLine("");
                            }
                    Console.WriteLine("please confirm the order     (1 = yes/2 = no)");
                            int Option = Convert.ToInt32(Console.ReadLine());
                    
                    if(Option < 1)
                            {
                                goto Order;
                            }
                    if(Option > 2)
                            {

                            }

                    goto top;
                            break;

                        case 2:
                        Top_1:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("This is summery :D");
                            Console.WriteLine("Please press enter to return to the main menu");
                            Console.ReadLine();
                            goto top;

                            break;


                    }

                }
            }
        }
    }
}
