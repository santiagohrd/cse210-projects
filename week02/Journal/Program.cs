using System;
using System.Security.Cryptography.X509Certificates;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Project!");

        Journals myJournals = new Journals();
        
        int userOption = 0;

        while (userOption != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            
            Console.Write("What would you like to do? ");
            string number = Console.ReadLine();
            userOption = int.Parse(number);

            if (userOption == 1)
            {
                PromptGenerator _prompts = new PromptGenerator();

                Entry userEntry = new Entry();

                string selectedQuestion =_prompts.GetRandomPrompt();
                
                Console.WriteLine(selectedQuestion);
                string answer = Console.ReadLine();
                
                userEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
                userEntry._promptText = selectedQuestion;
                userEntry._entryText = answer;

                myJournals.AddEntry(userEntry);
            }
           
            else if (userOption == 2)
            {
                myJournals.DisplayAll();
            }

            else if (userOption == 3) //load
            {
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                
                myJournals.LoadFromFile(fileName);
            }

            else if (userOption == 4) //save
            {
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();

                myJournals.SaveToFile(fileName);
            }
        }   
    }
}