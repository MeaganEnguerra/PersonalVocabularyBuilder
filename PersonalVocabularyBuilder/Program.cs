using System.Collections.Generic;
using System;

namespace PersonalVocabularyBuilder
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string name = "meagan";
            List<string> vocabularies = new List<string>();

            Console.WriteLine("Welcome to your Personal Vocabulary Builder!");
            Console.WriteLine("A simple app that helps u to list and manage your vocabulary.\n");

            Console.Write("Enter ur username: ");
            string userName = Console.ReadLine();

            if (userName == name)
            {
                Console.WriteLine("Hello, meagan! What do u want to do? \n");
                var myOption = new string[4];
                myOption[0] = "Press (1) if you want to ADD A NEW VOCABULARY";
                myOption[1] = "Press (2) if you want to VIEW ALL VOCABULARY";
                myOption[2] = "Press (3) if you want to DELETE A CERTAIN VOCABULARY";
                myOption[3] = "Press (4) if you want to EXIT";


                string options;
                do
                {
                    Console.WriteLine("Press number 1 to 4 to get started: \n");
                    foreach (var selectedChoice in myOption)
                    {
                        Console.WriteLine(selectedChoice);
                    }

                    options = Console.ReadLine();

                    if (options == "1")
                    {
                        string add;
                        do
                        {
                            Console.Write("Input a word: ");
                            string addWord = Console.ReadLine();

                            Console.Write("Input its meaning: ");
                            string addMeaning = Console.ReadLine();

                            Console.Write("Use it in a sentence: (Optional): ");
                            string addSentence = Console.ReadLine();

                            vocabularies.Add(addWord);
                            vocabularies.Add(addMeaning);
                            vocabularies.Add(addSentence);
                            Console.WriteLine(addWord + " is added to ur list. \n");

                            Console.Write("Add more? ");
                            Console.WriteLine("Press [1] if u want to addd more, press any if u'r done. \n");
                            add = Console.ReadLine();
                        }
                        while (add == "1");

                    }
                    else if (options == "2")
                    {
                        Console.WriteLine("List of all ur obtained vocabulary so far... \n");

                        if (vocabularies.Count == 0)
                        {
                            Console.WriteLine("No results.");
                        }
                        else
                        {
                            for (int wordsList = 0; wordsList < vocabularies.Count; wordsList++)
                            {
                                Console.WriteLine(vocabularies[wordsList]);
                            }
                        }
                    }
                    else if (options == "3")
                    {
                        string remove;

                        Console.WriteLine("Enter a word u want to remove: \n");
                        string removeWord = Console.ReadLine();

                        if (vocabularies.Contains(removeWord))
                        {
                            vocabularies.Remove(removeWord);
                            Console.WriteLine(removeWord + " is removed. \n");
                        }
                    }
                    else if (options == "4")
                    {
                        Console.WriteLine("App Closed.");
                    }



                } while (options != "4");
            }
            
            else 
            {
                Console.WriteLine("Invaalid input username. ");
            }
        }
    }
}
