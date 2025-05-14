using System;
using System.Collections;
using System.Collections.Generic;

namespace ASC_Desing_2
{
    public class User_Interaction
    {
        // Delegate for chatbot response
        public delegate void ChatbotResponse(string message);

        // List to store user history
        private List<string> memory = new List<string>();

        // Random generator for fallback messages
        private Random random = new Random();

        // Fallback random responses
        private List<string> fallbackResponses = new List<string>
        {
            "Could you please rephrase that?",
            "I'm not sure I understand. Try again?",
            "That's an interesting question!",
            "Let me think about that...",
            "Can you clarify what you mean?"
        };

        public User_Interaction()
        {
            // Keyword-based responses
            ArrayList Questions = new ArrayList();
            ArrayList ignore = new ArrayList();

            Questions.Add("A password should be at least 12 characters long...");
            Questions.Add("Phishing is when criminals use scam emails, texts or calls...");
            Questions.Add("When browsing the internet, make sure the site is secure...");
            Questions.Add("Cybercrime includes identity theft, data breaches, viruses...");
            Questions.Add("Cybersecurity protects systems and data from attacks...");

            ignore.Add("tell");
            ignore.Add("me");
            ignore.Add("about");

            // Main interaction loop
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[ CAA ] : ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ask me anything about cybersecurity or type 'exit'.");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("[ User ] : ");
                Console.ForegroundColor = ConsoleColor.White;
                string ask = Console.ReadLine()?.ToLower().Trim();

                if (string.IsNullOrWhiteSpace(ask))
                {
                    Console.WriteLine("[ CAA ] : Please enter a valid input.");
                    continue;
                }

                if (ask == "exit")
                {
                    Console.WriteLine("[ CAA ] : Goodbye!");
                    break;
                }

                // Store in memory
                memory.Add(ask);

                // Handle sentiment detection
                if (ask.Contains("sad") || ask.Contains("angry") || ask.Contains("upset"))
                {
                    Respond("I'm sorry you're feeling that way. I'm here to help.");
                    continue;
                }
                else if (ask.Contains("happy") || ask.Contains("good") || ask.Contains("excited"))
                {
                    Respond("I'm glad you're feeling great! Let's continue.");
                    continue;
                }

                // Check for "remember" command
                if (ask.Contains("remember"))
                {
                    Respond("Here’s what you’ve asked me so far:");
                    foreach (var mem in memory)
                    {
                        Console.WriteLine("- " + mem);
                    }
                    continue;
                }

                // Filter question
                string[] words = ask.Split(' ');
                ArrayList filtered = new ArrayList();

                foreach (string word in words)
                {
                    if (!ignore.Contains(word))
                        filtered.Add(word);
                }

                bool found = false;
                foreach (string keyword in filtered)
                {
                    foreach (string q in Questions)
                    {
                        if (q.ToLower().Contains(keyword))
                        {
                            Respond(q);
                            found = true;
                        }
                    }
                }

                if (!found)
                {
                    // Use random fallback
                    int i = random.Next(fallbackResponses.Count);
                    Respond(fallbackResponses[i]);
                }
            }
        }

        // Reusable delegate-based response method
        private void Respond(string message)
        {
            ChatbotResponse response = ConsoleResponse;
            response(message);
        }

        // Output handler for responses
        private void ConsoleResponse(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[ CAA ] : ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }
    }
}
