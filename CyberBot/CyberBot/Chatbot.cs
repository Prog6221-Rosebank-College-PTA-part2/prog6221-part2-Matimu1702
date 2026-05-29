using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot
{
    internal class Chatbot
    {
        private string userName;

        public void StartChatbot()
        {
            WelcomeScreen.Display();

            AskUserName();

            StartConversation();
        }

        private void AskUserName()
        {
            Console.Write("\nPlease enter your name: ");
            userName = Console.ReadLine()?.Trim();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Invalid input. Please enter a valid name: ");
                Console.ResetColor();

                userName = Console.ReadLine()?.Trim();
            }

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(
                $"\nHello, {userName}! I'm your cybersecurity assistant.");

            Console.ResetColor();
        }

        private void StartConversation()
        {
            while (true)
            {
                Console.Write("\nYou: ");

                string userInput =
                    Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bot: Please enter a valid question.");
                    Console.ResetColor();
                    continue;
                }

                if (userInput == "exit" || userInput == "quit")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.WriteLine(
                        $"\nBot: Stay safe online, {userName}! Goodbye!");

                    Console.ResetColor();
                    break;
                }

                string response =
                    ResponseSystem.GetResponse(userInput);

                TypingEffect.Show(response);
            }
        }
    }
}


