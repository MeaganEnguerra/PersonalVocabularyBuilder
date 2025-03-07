using System.Collections.Generic;
using System;

namespace PersonalVocabularyBuilder
{
    internal class Program
    {

        static void Main(string[] args)
        {


            Console.Write("Welcome to Vocabulary Builder! ");
            Console.WriteLine("A simple app that manages and expand your personal vocabulary.\n");

            string name = "meagan";
            List<string> listedWords = new List<string>();
            
            var option = new string[5];
            option[0] = "Press (1) if you want to ADD A NEW VOCABULARY";
            option[1] = "Press (2) if you want to VIEW ALL VOCABULARY";
            option[2] = "Press (3) if you want to EDIT A CERTAIN VOCABULARY";
            option[3] = "Press (4) if you want to DELETE A CERTAIN VOCABULARY";
            option[4] = "Press (5) if you want to go BACK TO MENU";


            Console.WriteLine("Please enter your username to access this application.");
            Console.Write("Username: ");
            string userName = Console.ReadLine();


            if (userName == name)
            {
                 
                Console.WriteLine("\nHello!, Meagan! What do you want to do today? \n");
                Console.WriteLine("SELECT A NUMBER: \n");

                foreach (var choice in option)
                {
                    Console.WriteLine(choice);
                }

                Console.Write("Enter a number: ");
                int userChoice = Convert.ToInt16(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.Write("Enter a word: ");
                        string word = Console.ReadLine();

                        Console.Write("Enter the meaning: ");
                        string meaning = Console.ReadLine();

                        Console.Write("Use it in a sentence: (If u want) ");
                        string sentence = Console.ReadLine();

                        listedWords.Add(word);
                        listedWords.Add(meaning);
                        listedWords.Add(sentence);


                        Console.WriteLine(" ");
                        Console.WriteLine(word + " is now added from ur vocabulary. ");
                        break;

                    case 2:
                        Console.WriteLine("These are the words from your vocabulary app:\n");
                        if (listedWords.Count == 0) 
                        {
                            Console.WriteLine("Empty.");
                        }
                        else
                        {
                            for (int i = 0; i < listedWords.Count; i += 3) 
                            {
                                if (i + 2 < listedWords.Count) 
                                {
                                    Console.WriteLine($"{i / 3 + 1}. Word: {listedWords[i]}"); 
                                    Console.WriteLine($"   Meaning: {listedWords[i + 1]}"); 
                                    Console.WriteLine($"   Sentence: {listedWords[i + 2]}\n"); 
                                }
                            }
                        }
                        break;

                    case 3:

                        listedWords.Clear();
                        Console.WriteLine("All vocabulary are deleted.");
                        break;

                    case 4:

                        Console.WriteLine("Exit");
                        return;

                    default:
                        Console.WriteLine("InpUt Inavalid");
                        break;




                }
            }
        }
    }
}
