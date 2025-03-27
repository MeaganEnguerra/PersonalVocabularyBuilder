using System.ComponentModel;
using System.Data;
using System.Globalization;

namespace BusinessDataLogic
{
    public class process
    {
        public static List<string> vocabularies = new List<string>();
        public static void AddWord(string addWord, string addMeaning, string addSentence)
        {
            vocabularies.Add("Word: " + addWord);
            vocabularies.Add("Meaning: " + addMeaning);
            vocabularies.Add("Sentence: " + addSentence);
        }

        public static bool RemoveWord(string removeWord)
        {
            for (int del = 0; del < vocabularies.Count; del++)
            {
                if (vocabularies[del].Contains("Word: " + removeWord))
                {
                    vocabularies.RemoveAt(del);
                    if (del < vocabularies.Count) ;
                    vocabularies.RemoveAt(del);
                    if (del < vocabularies.Count) ;
                    vocabularies.RemoveAt(del);

                    return true;
                }
            }       return false;
        }
    }
}
