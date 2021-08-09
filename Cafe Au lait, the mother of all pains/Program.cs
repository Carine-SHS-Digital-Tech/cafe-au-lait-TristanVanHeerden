using System;
using System.IO;
using System.Globalization;
using System.Text;

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

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(@"Please insert operation mode
option 1 : Dine in
Option 2 : Take away");
                    Console.WriteLine(@"Please select the operation");
                    int OperationoNum = Convert.ToInt32(Console.ReadLine());
                    switch (OperationoNum)
                    {
                        case 1:/// dine in 
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(@"
Please only select 4 Drinks
");



                        Order:
                            Double Espreso_price = 2.25;
                            Double foam_price = 3.00;
                            Double Latte_price = 2.5;
                            Double Iced_coffee_price = 2.50;
                            Double Gst = 1.1;

                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Please select from the follwing beverages.");
                            Console.WriteLine("1 > Espresso        $2.25");
                            int Espresso = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("2 > Ice Coffee      $2.50");
                            int Ice_coffee = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("3 > latte           $2.50");
                            int latte = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("4 > Cappuccino      $3.00");
                            int foam = Convert.ToInt32(Console.ReadLine());
                            int total_coffees = (Espresso + Ice_coffee + latte + foam);
                            if (total_coffees > 4)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("sorry we cannot sell " + total_coffees + "to you as it exceeds the 4 cup capacity ");
                                goto Order;
                            }
                            {
                                double price = ((Espresso * Espreso_price + Iced_coffee_price * Ice_coffee + Latte_price * latte + foam * foam_price) * Gst);
                                double final_price = Math.Round(price, 2);
                            Reciept1:
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Reciept");
                                    Console.WriteLine("Espresso(s) >" + (Espresso));
                                    Console.WriteLine("Iced Coffee(s) >" + (Ice_coffee));
                                    Console.WriteLine("Latte(s) >" + (latte));
                                    Console.WriteLine("Cuppacinno(s)" + (foam));
                                    Console.WriteLine("toal Cost > $" + (final_price));
                                }

                            }
                            Console.WriteLine("please confirm the order     (1 = yes/2 = no)");
                            int Option = Convert.ToInt32(Console.ReadLine());

                            if (Option < 2)
                            {


                                // this isnt part  of the code its just a little easter egg :)
                                goto top;
                            }
                            if (Option > 1)
                            {
                                
                                goto Order;
                            }

                            goto Order;
                            break;

                        case 2:// Take away 
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(@"
Please only select 4 Drinks
");

                            Double Espreso_price_A = 2.25;
                            Double foam_price_A = 3.00;
                            Double Latte_price_A = 2.5;
                            Double Iced_coffee_price_A = 2.50;
                            Double Gst_A = 1.1;
                            Double extra = 1.05;

                        Order2:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Please select from the follwing beverages.");
                            Console.WriteLine("1 > Espresso        $2.25");
                            int Espresso_A = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("2 > Ice Coffee      $2.50");
                            int Ice_coffee_A = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("3 > latte           $2.50");
                            int latte_A = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("4 > Cappuccino      $3.00");
                            int foam_A = Convert.ToInt32(Console.ReadLine());
                            int total_coffees_A = (Espresso_A + Ice_coffee_A + latte_A + foam_A);
                            if (total_coffees_A > 4)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("sorry we cannot sell " + total_coffees_A + "to you as it exceeds the 4 cup capacity ");
                                Console.WriteLine();
                                goto Order;
                            }
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                double price = (((Espresso_A * Espreso_price_A + Iced_coffee_price_A * Ice_coffee_A + Latte_price_A * latte_A + foam_A * foam_price_A) * extra) * Gst_A);
                                double final_price2 = Math.Round(price, 2);
                            Reciept2:
                                {
                                    Console.WriteLine("Reciept");
                                    Console.WriteLine("Espresso(s) >" + (Espresso_A));
                                    Console.WriteLine("Iced Coffee(s) >" + (Ice_coffee_A));
                                    Console.WriteLine("Latte(s) >" + (latte_A));
                                    Console.WriteLine("Cuppacinno(s)" + (foam_A));
                                    Console.WriteLine("toal Cost > $" + (final_price2));
                                }

                            }
                            Console.WriteLine("please confirm the order     (1 = yes/2 = no)");
                            int Option2 = Convert.ToInt32(Console.ReadLine());

                            if (Option2 < 2)
                            {
                                
                                goto top;
                            }
                            if (Option2 > 1)
                            {
                                

                                goto Order2;
                            }

                            break;


                    }

                }
            }
        }
    }
}
