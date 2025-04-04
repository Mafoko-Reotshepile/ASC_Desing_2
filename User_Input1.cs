using System.Collections.Generic;
using System.Linq;
using System;

namespace ASC_Desing_2
{
    internal class User_Input
    {
        public User_Input()
        {



            // Change CAA text color to red
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[ CAA ] : ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What is your name?");

            // Get user's name
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[ User ] : ");
            Console.ForegroundColor = ConsoleColor.White;
            string name = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                name = "User"; // Default name if input is empty
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[ CAA ] : ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Hello {name}! How can I help you today?");

            // List of predefined questions and ignored words
            List<string> userQuestions = new List<string>
            {
                "I'm good, thanks.",
                "My purpose is to educate about Cybersecurity."
            };

            List<string> userIgnoreWords = new List<string> { "how", "what's" };

            // User input for question
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"[ {name} ] : ");
            Console.ForegroundColor = ConsoleColor.White;
            string ask = Console.ReadLine()?.ToLower().Trim(); // Convert input to lowercase

            if (string.IsNullOrWhiteSpace(ask))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[ CAA ] : ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please enter a valid question.");
                return;
            }

            // Filter ignored words
            List<string> filteredWords = ask.Split(' ')
                                            .Where(word => !userIgnoreWords.Contains(word))
                                            .ToList();

            if (filteredWords.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[ CAA ] : ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please ask something meaningful.");
                return;
            }

            // Search for relevant responses
            bool found = false;
            foreach (string question in userQuestions)
            {
                if (filteredWords.Any(word => question.ToLower().Contains(word)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[ CAA ] : ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(question);
                    found = true;
                }
            }

            if (!found)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[ CAA ] : ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("I am sorry, I do not have an answer for that.");
            }
        }
    }
}