using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        int menuOption = 0;

        while (menuOption != 4)
        {
            Console.WriteLine($"\nMenu options:");

            MenuOptions menu = new MenuOptions();
            menu.GetMenu();

            Console.Write("Select a choice from the menu: ");
            string option = Console.ReadLine();
            menuOption = int.Parse(option);

            
            if (menuOption == 1)
            {
            
                Console.Clear();
                
                BreathingActivity breathingActivity = new BreathingActivity(0);

                breathingActivity.DisplayStartingMessage();
                breathingActivity.SetDuration();
                Console.Clear();
                breathingActivity.Run();
                

                Console.WriteLine("\n");
                breathingActivity.DisplayEndingMessage();
                Console.WriteLine("\n");


            }
            else if (menuOption == 2)
            {
                Console.Clear();

                ReflectingActivity reflectingActivity = new ReflectingActivity(0);

                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.SetDuration();
                Console.Clear();
                reflectingActivity.Run();
                
                Console.WriteLine("\n");
                reflectingActivity.DisplayEndingMessage();
                Console.WriteLine("\n");

            }
            else if (menuOption == 3)
            {
                ListingActivity listingActivity = new ListingActivity(0);   
                
                Console.Clear();
                listingActivity.DisplayStartingMessage();
                listingActivity.SetDuration();

                Console.Clear();

                listingActivity.Run();

                listingActivity.DisplayEndingMessage();

            }
        }

    }
}