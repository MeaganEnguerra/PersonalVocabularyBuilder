using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using BusinessDataLogic;

namespace PersonalVocabularyBuilder
{
    internal class Program
    {

        static string[] myOption =
        {
            "Press (1) to ADD A NEW VOCABULARY",
            "Press (2) to VIEW ALL VOCABULARY",
            "Press (3) to DELETE A CERTAIN VOCABULARY",
            "Press (4) to EXIT"
        };

        static void Main(string[] args)
        {
            string name = "meagan";

            Console.WriteLine("Welcome to your Personal Vocabulary Builder!");
            Console.WriteLine("A simple app that helps you list and manage your vocabulary.\n");

            Console.Write("Enter your username: ");
            string userName = Console.ReadLine();

            if (userName == name)
            {
                Console.WriteLine("\nHello, Meagan! What do you want to do?\n");
                Option();
                int userOption = GetUserInput();

                while (userOption != 4)
                {
                    switch (userOption)
                    {
                        case 1:
                            AddWord();
                            break;

                        case 2:
                            ViewWord();
                            break;

                        case 3:
                            RemoveWord();
                            break;

                        case 4:

                            return;

                        default:
                            Console.WriteLine("\nInvalid option. Please select a valid number (1-4).\n");
                            break;
                    }
                    Option();
                    userOption = GetUserInput();

                }
                Console.WriteLine("\nAPP CLOSING...");
            }
            else
            {
                Console.WriteLine("Invalid input username.");
            }
        }

        public static void Option()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("\nPress a number (1-4) to get started:\n");
            foreach (var choice in myOption)
            {
                Console.WriteLine(choice);
            }
        }

        static int GetUserInput()
        {
            Console.Write("\nInput: ");
            int userInput = Convert.ToInt16(Console.ReadLine());
            return userInput;
        }

        static void AddWord()
        {
            string add;
            do
            {
                Console.Write("\nInput a word: ");
                string addWord = Console.ReadLine();

                Console.Write("\nInput its meaning: ");
                string addMeaning = Console.ReadLine();

                Console.Write("\nUse it in a sentence (Optional): ");
                string addSentence = Console.ReadLine();
                process.AddWord(addWord, addMeaning, addSentence);

                Console.WriteLine("\nTHE WORD: " + addWord + " HAS BEEN NOW ADDED TO YOUR LIST..\n");

                Console.Write("\nAdd more? Type 'yes' to continue, or anything else to exit: ");
                add = Console.ReadLine()?.Trim().ToLower();

            } while (add == "yes");
        }

        static void ViewWord()
        {
            Console.WriteLine("\nLIST OF ALL YOUR OBTANAINED VOCABULARY SO FAR...\n");
            if (process.vocabularies.Count == 0)
            {
                Console.WriteLine("No results.");
            }
            else
            {
                foreach (var word in process.vocabularies)
                {
                    Console.WriteLine(word + "\n");
                }
            }
        }

        static void RemoveWord()
        {
            Console.Write("\nEnter a word you want to remove: ");
            string removeWord = Console.ReadLine();
            if (process.RemoveWord(removeWord))
            {
                Console.WriteLine("\n" + removeWord + " HAS BEEN REMOVED.\n");
                process.RemoveWord(removeWord);
            }
            else
            {
                Console.WriteLine("\nWORD NOT FOUND IN YOUR LIST.\n");
            }
        }
    }
}





