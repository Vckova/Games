using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    internal class MainMenu
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome in our store, we have two games for play:");
            Console.WriteLine(" a. Pyramid - 3$ ");
            Console.WriteLine(" b. Calendar - 5$ ");

            Console.WriteLine("If you want to play our games press Y ?");
            string PlayYN = Console.ReadLine();
            if (PlayYN.Equals("y"))
            {
                Console.WriteLine("Please enter valid credit card");
                string CreditCard = Console.ReadLine();
                Console.WriteLine("Please enter Name and Surname");
                string Name = Console.ReadLine();
                Console.WriteLine("Please enter CVS code");
                string CVS = Console.ReadLine();
                Console.WriteLine("Please enter exp date");
                string ExpDate = Console.ReadLine();

                Console.WriteLine("Which game you wanna play?");
                Console.WriteLine(" a. Pyramid - 3$ ");
                Console.WriteLine(" b. Calendar - 5$ ");
                int PyramidPlayed = 0;
                int ClendarPlayed = 0;
                string GamesAB;
                do
                {
                    GamesAB = Console.ReadLine();
                    if (!GamesAB.Equals("a") && !GamesAB.Equals("b"))
                    {
                        Console.WriteLine("Your input is invalid. Please enter valid option.");
                    }
                } while (!GamesAB.Equals("a") && !GamesAB.Equals("b"));


                if (GamesAB.Equals("a"))
                {
                    string PyramidYN;
                    do
                    {
                        PyramidPlayed = PyramidPlayed + 1;
                        var NewPyramid = new Pyramid();
                        NewPyramid.DrawPyramid();
                        Console.WriteLine("Do you want to play this game again?");
                        PyramidYN = Console.ReadLine();
                    } while (PyramidYN.Equals("y"));

                }
                else if (GamesAB.Equals("b"))
                {
                    string CalendarYN;
                    do
                    {
                        ClendarPlayed = ClendarPlayed + 1;
                        var NewCalendar = new Calendar();
                        NewCalendar.DrawCalendar();
                        Console.WriteLine("Do you want to play this game again?");
                        CalendarYN = Console.ReadLine();
                    } while (CalendarYN.Equals("y"));
                }

                Console.WriteLine("Your bill is :");
                Console.WriteLine("1. Pyramid x " + PyramidPlayed + " x 3$ = " + PyramidPlayed * 3 + "$");
                Console.WriteLine("1. Calendar x " + ClendarPlayed + " x 5$ = " + ClendarPlayed * 5 + "$");
                Console.WriteLine(" TOTAL = " + (PyramidPlayed * 3 + ClendarPlayed * 5) + "$");
                Console.WriteLine("This is charged from your credit card!");


                Console.WriteLine(" Thank you for playing, Have a nice day!");
            }
            else
            {
                Console.WriteLine(" We are sorry you didn't play with us");
            }
        }
    }
}
