using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Net.NetworkInformation;
using PVBDataLogic;


namespace PVBBusinessLogic
{
    public class VocabularyBusinessLogic
    {
        public VocabularyDataLogic vocabularyDataLogic = new VocabularyDataLogic();

        public  void AddWord(string addWord, string addMeaning, string addSentence)
        {
             vocabularyDataLogic.AddWord (addWord, addMeaning, addSentence);
        }

        public bool RemoveWord (string remove)
        {
           return vocabularyDataLogic.RemoveWord (remove);
        }
        public  bool ValidateAccount (string userName, string passWord)
        {
            return vocabularyDataLogic.ValidateVocabularyAccount(userName, passWord);
        }

        public  bool UpdateWord(string oldWord, string newWord, string newMeaning, string newSentence)
        {
            return vocabularyDataLogic.UpdateWord(oldWord, newWord,newMeaning, newSentence);
        }

        public  string SearchWord(string search)
        {
            return vocabularyDataLogic.SearchWord(search);
        }

        public class SetVocabulary
        {
            public static string Word { get; set; }
            public static string Meaning { get; set; }
            public static string Sentence { get; set; }
        }
        public class GameMode
        {
         //i added this function-GameMode to maximize my project but it still have flows, need  more time to improve.
            public static List<SetVocabulary> vocabularies = new List<SetVocabulary>();
            public static List<int> usedIndexes = new List<int>();
            public static Random randomMeaning = new Random();

            public static SetVocabulary GetRandomWord()
            {
                if (vocabularies.Count == 0 || usedIndexes.Count == vocabularies.Count)
                    return null;

                int index;
                do
                {
                    index = randomMeaning.Next(vocabularies.Count);
                } while (usedIndexes.Contains(index));

                usedIndexes.Add(index);
                return vocabularies[index];
            }

            public static void ResetQuiz()
            {
                usedIndexes.Clear();
            }
        }

        public  (string Meaning, string Word) GetRandom()
        {

            if (vocabularyDataLogic.vocabularies.Count < 3)
                return (null, null);

            int index = GameMode.randomMeaning.Next(0, vocabularyDataLogic.vocabularies.Count / 3) * 3; //para ma-include pa yung index of word, meaniing, sentence

            string word = vocabularyDataLogic.vocabularies[index].Replace("Word: ", "");
            string meaning = vocabularyDataLogic.vocabularies[index + 1].Replace("Meaning: ", "");

            return (meaning, word);
        }

        public bool ValidateVocabularyAccount(string userName, string passWord)
        {
            foreach (var account in accounts)
            {
                if (account.UserName == userName && account.Password == passWord)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
