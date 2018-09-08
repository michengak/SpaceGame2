using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreatedWord()
        {

            World newWorld = new World();

            newWorld.AddLocation(0, -4.367, "Alpha Centauri", "welcome to Alpha Centauri ," +
                                  " this is your home, mysteries and wonders!");

            newWorld.AddLocation(-4, 6.5, "My Great Planet", "welcome to My Great planet, " +
                                  "this is where you are, and feel free to conquer your space!");


            newWorld.AddLocation(0, 0, "Home", "welcome to the Earth Store, this is your home!");



            return  newWorld;
        }
    }
}

public static void MyGreatStore()  // this is the implementation of the store in the earth location.
{
    string item;
    Console.WriteLine("Welcome to My Great Planet Store");
    Console.WriteLine("What would you like to buy? ");
    Console.WriteLine("Pick a number 1, 2, 3 or 4");
    Console.WriteLine("1- Snickers = 12 credits");
    Console.WriteLine("2- KitKat   = 32 credits ");
    Console.WriteLine("3- Twix     = 23 credits");
    Console.WriteLine("4- BabyRuth = 5 credits");
    item = Console.ReadLine().ToLower();
    Console.Clear();

    switch (item)
    {
        case "1":
            {
                Console.WriteLine("Good Choice");
                Console.ReadLine();
                break;
            }
        case "2":
            {
                Console.WriteLine("Yum KitKat");
                Console.ReadLine();
                break;
            }
        case "3":
            {
                Console.WriteLine("Left and Right Twix, Yay");
                Console.ReadLine();
                break;
            }
        case "4":
            {
                Console.WriteLine("Terrible candy bar, here you go");
                Console.ReadLine();
                break;
            }
        default:
            {
                Console.WriteLine("I dont understand, try again");
                Console.ReadLine();
                break;
            }

    }


}
