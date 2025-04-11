using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PVBBusinessLogic;


namespace PersonalVocabularyBuilder
{
    internal class Program
    {

        static string[] myOption =
        {
            "Press (1) to ADD A NEW VOCABULARY",
            "Press (2) to VIEW ALL VOCABULARY",
            "Press (3) to DELETE A CERTAIN VOCABULARY",
            "Press (4) to UPDATE / EDIT A WORD",
            "Press (5) to SEARCH A WORD",
            "Press (6) to ENTER GAME MODE",
            "Press (7) to EXIT"
        };

        static VocabularyBusinessLogic vocabularyBusinessLogic = new VocabularyBusinessLogic();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Personal Vocabulary Builder!");
            Console.WriteLine("A simple app that helps you list and manage your vocabulary.\n");

            string userName = string.Empty;
            string passWord = string.Empty;
            do
            {
                Console.Write("\nEnter your username: ");
                userName = Console.ReadLine();

                Console.WriteLine("\nEnter your password: ");
                passWord = Console.ReadLine();


                if (!vocabularyBusinessLogic.ValidateAccount(userName, passWord))
                {
                    Console.WriteLine("\nIncorrect user's input. Please try again.");
                }
            } while (!vocabularyBusinessLogic.ValidateAccount(userName, passWord));

            Console.WriteLine("\nHello! What do you want to do?\n");

            Option();
            string userOption = GetUserInput();

            while (userOption != "7")
            {
                switch (userOption)
                {
                    case "1":
                        AddWord();
                        break;

                    case "2":
                        ViewWord();
                        break;

                    case "3":
                        RemoveWord();
                        break;

                    case "4":
                        UpdateWord();
                        break;

                    case "5":
                        SearchWord();
                        break;

                    case "6":
                        GameMode();
                        break;

                    case "7":

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



        public static void Option()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("\nPress a number (1-4) to get started:\n");
            foreach (var choice in myOption)
            {
                Console.WriteLine(choice);
            }
        }

        static string GetUserInput()
        {
            Console.Write("\nInput: ");
            string userInput = Console.ReadLine();
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
                vocabularyBusinessLogic.AddWord(addWord, addMeaning, addSentence);

                Console.WriteLine("-------------------------");
                Console.WriteLine("\nTHE WORD: " + addWord + " HAS BEEN NOW ADDED TO YOUR LIST..\n");

                Console.Write("\nAdd more? Type 'yes' to continue, or anything else to exit: ");
                add = Console.ReadLine()?.Trim().ToLower();

            } while (add == "yes");
        }

        static void ViewWord()
        {

            if (vocabularyBusinessLogic.vocabularyDataLogic.vocabularies.Count == 0)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("\nNo results.");
            }
            else
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("\nLIST OF ALL YOUR OBTAINED VOCABULARY SO FAR...\n");
                foreach (string word in vocabularyBusinessLogic.vocabularyDataLogic.vocabularies)
                {
                    Console.WriteLine(word + "\n");
                }
            }
        }

        static void RemoveWord()
        {
            Console.Write("\nEnter a word you want to remove: ");
            string remove = Console.ReadLine();
            if (vocabularyBusinessLogic.RemoveWord(remove))
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("\n" + remove + " HAS BEEN REMOVED.\n");
                vocabularyBusinessLogic.RemoveWord(remove);
            }
            else
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("\nWORD NOT FOUND IN YOUR LIST.\n");
            }
        }

        static void UpdateWord()
        {
            Console.Write("\nEnter the word you want to update: ");
            string oldWord = Console.ReadLine();

            Console.Write("Enter the new word: ");
            string newWord = Console.ReadLine();

            Console.Write("Enter the new meaning: ");
            string newMeaning = Console.ReadLine();

            Console.Write("Enter the new sentence: ");
            string newSentence = Console.ReadLine();

            if (vocabularyBusinessLogic.UpdateWord(oldWord, newWord, newMeaning, newSentence))
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("\nWORD SUCCESSFULLY UPDATED.\n");
            }
            else
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("\nWORD NOT FOUND.\n");
            }
        }

        static void SearchWord()
        {
            Console.Write("\nEnter the word you want to search: ");
            string search = Console.ReadLine();

            string result = vocabularyBusinessLogic.SearchWord(search);

            if (result != null)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("\nWORD FOUND:\n" + "\n" + result);
            }
            else
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("\nWORD NOT FOUND.\n");
            }
        }



        public static void GameMode()
        {

            if (vocabularyBusinessLogic.vocabularyDataLogic.vocabularies.Count == 0)
            {
                Console.WriteLine("No words in the vocabulary list. Please add some first.");
                return;
            }

            string playAgain;
            int correct = 0;
            int incorrect = 0;
            Random rand = new Random();
            Console.WriteLine("-------------------------");
            Console.WriteLine("\nGuess the word based on its meaning!\n");

            do
            {
                var entry = vocabularyBusinessLogic.GetRandom();
                if (entry.Meaning == null || entry.Word == null)
                {
                    Console.WriteLine("You've guessed all words in the list. Well done!");
                    break;
                }
                Console.WriteLine("-------------------------");
                Console.WriteLine("meaning: " + entry.Meaning);
                Console.Write("Your guess word: ");
                string guess = Console.ReadLine()?.Trim().ToLower();

                if (guess == entry.Word.ToLower())
                {
                    Console.WriteLine("Correct!");
                    correct++;
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct word is: " + entry.Word);
                    incorrect++;
                }
                Console.WriteLine("-------------------------");
                Console.Write("\nPlay again? type YES or NO: ");
                playAgain = Console.ReadLine()?.Trim().ToLower();

            } while (playAgain == "yes");

            Console.WriteLine("-------------------------");
            Console.WriteLine("\nQUIZ SUMMARY:");
            Console.WriteLine("Correct Answers: " + correct);
            Console.WriteLine("Incorrect Answers: " + incorrect);

            if (correct > incorrect)
                Console.WriteLine("\nGreat job!");
            else if (correct == incorrect)
                Console.WriteLine("\nNot bad. Keep practicing");
            else
                Console.WriteLine("\nKeep trying and you'll improve.");
        }


    }
}




