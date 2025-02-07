using System;

class Program
{
    static void Main(string[] args)
    {
        int menuOption = 0;

        while (menuOption != 4)
        {
            Console.WriteLine("Menu options:");

            MenuOptions menu = new MenuOptions();
            menu.GetMenu();

            Console.Write("Select a choice from the menu: ");
            string option = Console.ReadLine();
            menuOption = int.Parse(option);
            
            int duration;

            
            if (menuOption == 1)
            {
                Console.Write("How long, in seconds would you like your session? ");
                string durationInput = Console.ReadLine();
                duration = int.Parse(durationInput);

                BreathingActivity breathingActivity = new BreathingActivity(duration);
            }
            else if (menuOption == 2)
            {
                
            }
            else if (menuOption == 3)
            {
                
            }
        }

    }
}