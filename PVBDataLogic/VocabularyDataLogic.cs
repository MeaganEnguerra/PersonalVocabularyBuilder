using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using VocabularyCommon;


namespace PVBDataLogic
{
    public class VocabularyDataLogic
    {


        IDataLogic datalogic;

        public VocabularyDataLogic()
        {
            datalogic = new InMemoryData();
            //movielibrarydata = new TextFileData();
            //movielibrarydata = new JsonFileData();

        }

        public  List<string> vocabularies = new List<string>();
        public void AddWord(string addWord, string addMeaning, string addSentence)
        {
            vocabularies.Add("Word: " + addWord);
            vocabularies.Add("Meaning: " + addMeaning);
            vocabularies.Add("Sentence: " + addSentence);
        }

        public bool RemoveWord(string remove)
        {
            for (int index = 0; index < vocabularies.Count; index++)
            {
                if (vocabularies[index].Contains("Word: " + remove))
                {
                    vocabularies.RemoveAt(index);
                    if (index < vocabularies.Count) ;
                    vocabularies.RemoveAt(index);
                    if (index < vocabularies.Count) ;
                    vocabularies.RemoveAt(index);

                    return true;
                }
            }
            return false;
        }

        public bool UpdateWord(string oldWord, string newWord, string newMeaning, string newSentence)
        {
            for (int index = 0; index < vocabularies.Count; index++)
            {
                if (vocabularies[index].Contains("Word: " + oldWord))
                {
                    vocabularies[index] = "Word: " + newWord;
                    if (index + 1 < vocabularies.Count)
                        vocabularies[index + 1] = "Meaning: " + newMeaning;
                    if (index + 2 < vocabularies.Count)
                        vocabularies[index + 2] = "Sentence: " + newSentence;

                    return true;
                }
            }
            return false;
        }

        public string SearchWord(string search)
        {
            for (int index = 0; index < vocabularies.Count; index++)
            {
                if (vocabularies[index].Contains("Word: " + search))
                {
                    string result = vocabularies[index] + "\n";
                    if (index + 1 < vocabularies.Count)
                        result += vocabularies[index + 1] + "\n";
                    if (index + 2 < vocabularies.Count) result += vocabularies[index + 2];
                    return result;
                }
            }
            return null;
        }

        public List<UserAccount> GetAllAccounts()
        {
            return datalogic.GetAccounts();
        }    

    }
}
