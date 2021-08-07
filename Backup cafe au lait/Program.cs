using System;
using System.IO;
using System.Threading.Tasks;
using System.Text;
using CsvHelper;
using System.Globalization;

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
Option 2 : Log off");
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
                            Double Espreso_price = 2.25;
                            Double foam_price = 3.00;
                            Double Latte_price = 2.5;
                            Double Iced_coffee_price = 2.50;
                            Double Gst = 1.1;

                        Order:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Please select from the follwing beverages.");
                            Console.WriteLine("1 > Espresso        $2.25");
                            int Espresso = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("2 > Ice Coffee      $2.50");
                            int Ice_coffee = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("3 > latte           $2.50");
                            int latte = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("4 > Cappuccino      $3.00");
                            int foam = Convert.ToInt32(Console.ReadLine());
                            {
                                double price = ( (Espresso * Espreso_price + Iced_coffee_price * Ice_coffee + Latte_price * latte + foam * foam_price) * Gst);
                               double final_price = Math.Round(price, 2);
                                Console.WriteLine(("$ ")+final_price);
                            }
                            Console.WriteLine("please confirm the order     (1 = yes/2 = no)");
                            int Option = Convert.ToInt32(Console.ReadLine());

                            if (Option < 1)
                            {
                                var csvPath = Path.Combine(Environment.CurrentDirectory, $"CafeAuLait-{DateTime.Now.ToFileTime()}.csv");
                                using (var streamWriter = new StreamWriter(csvPath)) 
                                {
                                    using (var CsvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture ))
                                    {
                                        var CafeAuLait = CafeAuLaitInfo.GetTotal_cups();
                                        CsvWriter.WriteRecords(CafeAuLait);

                                    }
                                }
                                
                                // this isnt part  of the code its just a little easter egg :)
                            }
                            if (Option > 2)
                            {
                                goto Order;
                            }

                            goto top;
                            break;

                        case 2:

                            break;


                    }

                }
            }
        }
    }
}
