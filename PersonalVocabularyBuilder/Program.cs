namespace PersonalVocabularyBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                string path = "C:\\Users\\User\\Documents\\BSIT 2-1 Repos\\Vocabularies.txt";
                Console.Write("Welcome to Vocabulary Builder! ");
                Console.WriteLine("A simple app that manages and expand your personal vocabulary.\n");

                string name = "meagan";

                Console.WriteLine("Please enter your username to access this application.");
                Console.Write("Username: ");
                string userName = Console.ReadLine();

                if (userName == name)
                {

                    Console.WriteLine("\nHello!, Meagan! What do you want to do today? \n");

                    var option = new string[5];
                    option[0] = "Press (1) if you want to ADD A NEW VOCABULARY";
                    option[1] = "Press (2) if you want to VIEW ALL VOCABULARY";
                    option[2] = "Press (3) if you want to EDIT A CERTAIN VOCABULARY";
                    option[3] = "Press (4) if you want to DELETE A CERTAIN VOCABULARY";
                    option[4] = "Press (5) if you want to go BACK TO MENU";

                    Console.WriteLine("SELECT A NUMBER: \n");

                    foreach (var choice in option)
                    {
                        Console.WriteLine(choice);
                    }

                    Console.Write("Enter a number: ");
                    int userChoice = Convert.ToInt16(Console.ReadLine());

                    if (userChoice == 1)
                    {
                        Console.Write("Enter a word: ");
                        string word = Console.ReadLine();

                        Console.Write("Enter the meaning: ");
                        string meaning = Console.ReadLine();

                        Console.Write("Use it in a sentence: (If u want) ");
                        string sentence = Console.ReadLine();


                        using (StreamWriter writer = new StreamWriter(path, true))
                        {
                            writer.WriteLine("Word: " + word);
                            writer.WriteLine("Meaning: " + meaning);
                            writer.WriteLine("For example: " + sentence);
                            writer.WriteLine(" ");

                        }
                        Console.WriteLine(" ");
                        Console.WriteLine(word + " is now added from ur vocabulary. ");
                        Console.ReadKey();
                    }
                    else if (userChoice == 2)
                    {
                        if (File.Exists(path))
                        {
                            string[] allWords = File.ReadAllLines(path);

                            if (allWords.Length > 0)
                            {
                                Console.WriteLine(" These are the words from ur vocabulary app: \n");
                                foreach (var word in allWords)
                                {
                                    Console.WriteLine(" - " + word);
                                }
                            }
                        }
                    }
                    else if (userChoice == 3)
                    {
                        Console.Write("Enter a word u want to edit: ");
                        string word = Console.ReadLine();

                        Console.Write("Enter a new word: ");
                        string newWord = Console.ReadLine();

                        string allText = File.ReadAllText(path).Replace(word, newWord);

                        File.WriteAllText(path, allText);

                        Console.WriteLine("Saved Changes :)");

                    }
                    else if (userChoice == 4)
                    {
                        File.WriteAllText("C:\\Users\\User\\Documents\\BSIT 2-1 Repos\\Vocabularies.txt", "");
                        Console.WriteLine("All vocabulary are deleted.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid inpot");

                    }


                }
            }
        }
    }
