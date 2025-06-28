
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using PVBBusinessLogic;
using PVBDataLogic;
using VocabularyCommon;


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
            "Press (7) to DELETE AN ACCOUNT",
            "Press (8) to EXIT"
            };

        static string[] AccountActions = new string[]
            {
            "Press (1) to LOG IN",
            "Press (2) to SIGN UP",
            "Press (3) to EXIT"
            };

        static VocabularyBusinessLogic vocabularyBusinessLogic = new VocabularyBusinessLogic();
        static UserAccount activeUser;
        static bool loggedIn = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Personal Vocabulary Builder!");
            Console.WriteLine("A simple app that helps you list and manage your vocabulary.\n");
            Console.WriteLine("Before we start, please log in or sign up to your account.\n");


            Console.WriteLine("\nHello! What do you want to do?\n");
            SignAccount();

            while (loggedIn == true)
            {

                string userOption;
                do
                {
                    Option();
                    userOption = GetUserInput();

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
                          DeleteAccount();
                            break;

                        case "8":
                            return;

                        default:
                            Console.WriteLine("\nInvalid option. Please select a valid number (1-8).\n");
                            break;
                    }

                } while (userOption != "8" && loggedIn == true);
                Console.WriteLine("\nAPP CLOSING...");
            }

        }



        public static void Option()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("\nPress a number (1-8) to get started:\n");
            foreach (var choice in myOption)
            {
                Console.WriteLine(choice);
            }
        }


        static void ShowLogInOrSignUp()
        {
            Console.WriteLine("-------------------");

            foreach (string accountAction in AccountActions)
            {
                Console.WriteLine(accountAction);
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

                string userName = activeUser.Username;

                vocabularyBusinessLogic.AddWord(addWord, addMeaning, addSentence, userName);

                Console.WriteLine("-------------------------");
                Console.WriteLine("\nTHE WORD: " + addWord + " HAS BEEN NOW ADDED TO YOUR LIST..\n");

                Console.Write("\nAdd more? Type 'yes' to continue, or anything else to exit: ");
                add = Console.ReadLine()?.Trim().ToLower();

            } while (add == "yes");
        }

        static void ViewWord()
        {
            string userName = activeUser.Username;
            if (vocabularyBusinessLogic.GetAllWords(userName).Count == 0)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("\nNo results.");
            }
            else
            {

            }
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("\nLIST OF ALL YOUR OBTAINED VOCABULARY SO FAR...\n");
                foreach (var word in vocabularyBusinessLogic.GetAllWords(userName))
                {
                    Console.WriteLine($"Word: {word.Word}\nMeaning: {word.Meaning}\nSentence: {word.Sentence}\n");
                }

            }
        }

        static void RemoveWord()
        {
            Console.Write("\nEnter a word you want to remove: ");
            string remove = Console.ReadLine();

            string userName = activeUser.Username;
            if (vocabularyBusinessLogic.RemoveWord(remove, userName))
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("\n" + remove + " HAS BEEN REMOVED.\n");
                //vocabularyBusinessLogic.RemoveWord(remove);
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

            string userName = activeUser.Username;
            if (vocabularyBusinessLogic.UpdateWord(oldWord, newWord, newMeaning, newSentence, userName))
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

            string userName = activeUser.Username;
            SetVocabulary result = vocabularyBusinessLogic.SearchWord(search, userName);

            if (result != null)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("\nWORD FOUND:\n");              
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("\nWORD NOT FOUND.\n");
            }
        }



        public static void GameMode()
        {
            string userName = activeUser.Username;
            var allWords = vocabularyBusinessLogic.GetAllWords(userName);
           

            if (allWords.Count == 0)
            {
                Console.WriteLine("No words in the vocabulary list. Please add some first.");
                return;
            }

            VocabularyBusinessLogic.GameMode.vocabularies = allWords;
            VocabularyBusinessLogic.GameMode.ResetQuiz();

            Console.WriteLine("-------------------------");
            Console.WriteLine("\nGuess the word based on its meaning!\n");

            string playAgain = "yes";
            int correct = 0;
            int incorrect = 0;

            do
            {
                var entry = vocabularyBusinessLogic.GetRandom(userName);

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
                Console.Write("\nWant to continue? type YES or NO: ");
                playAgain = Console.ReadLine()?.Trim().ToLower();

            } while (playAgain == "yes" && VocabularyBusinessLogic.GameMode.usedIndexes.Count < VocabularyBusinessLogic.GameMode.vocabularies.Count);

            
            if (correct > 0 || incorrect > 0)
            {
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

        static void SignAccount()
        {
            string accountAction;
            do
            {
                ShowLogInOrSignUp();
                accountAction = GetUserInput();

                switch (accountAction)
                {
                    case "1":
                        LogIn();
                        break;

                    case "2":
                        SignUp();
                        break;

                    case "3":
                        Console.WriteLine("\nExiting the application.");
                        return;

                    default:
                        Console.WriteLine("\nInvalid option. Select a valid number (1-3).\n");
                        break;
                }

            } while (!loggedIn);
        }

        static void LogIn()
        {
            Console.Write("Enter Username: ");
            string userName = Console.ReadLine().Trim();

            Console.Write("Enter Password: ");
            string passWord = Console.ReadLine().Trim();

            if (vocabularyBusinessLogic.ValidateVocabularyAccount(userName, passWord))
            {
                loggedIn = true;
                activeUser = new UserAccount { Username = userName, Password = passWord };
                Console.WriteLine("Login successful! Welcome, " + userName);
            }
            else
            {
                Console.WriteLine("Incorrect username or password. Please try again.");
            }

        }

        static void SignUp()
        {       
            string userName;
            string passWord;

            do
            {            
                Console.Write("Enter Username: ");
                userName = Console.ReadLine().Trim();

                Console.Write("Enter Password: ");
                passWord = Console.ReadLine().Trim();

                if ( string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
                {
                    Console.WriteLine("Please input your Username and Password.\n");
                    continue;
                }

                if (vocabularyBusinessLogic.ExistedAccounts(userName))
                {
                    Console.WriteLine("That username is already taken. Try logging in or use another username.\n");
                    return;
                }
                vocabularyBusinessLogic.CreateAccount(userName, passWord);
                Console.WriteLine("Account created successfully! Please log in.\n");

                LogIn();
                return;

            } while (true);
        }

        static void DeleteAccount()
        {
            
            Console.Write("Plead Enter your Username: ");
            string userName = Console.ReadLine().Trim();

            Console.Write("Please Enter your Password: ");
            string passWord = Console.ReadLine().Trim();

            Console.Write("Are you sure you want to delete your account? (Yes/No): ");
            string confirmation = Console.ReadLine().Trim().ToLower();

            if (confirmation == "yes")
            {
                bool deleted = vocabularyBusinessLogic.DeleteAccount(userName, passWord);

                if (deleted)
                {
                    Console.WriteLine("\n successfully deleted.");
                    loggedIn = false;
                    SignAccount();
                }
                else
                {
                    Console.WriteLine("\nProcess Failed.");
                }
            }
            else
            {
            }
        }
    }

}










