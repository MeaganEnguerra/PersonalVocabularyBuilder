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
           //datalogic = new InMemoryData();
            //datalogic = new TextFileData();
            //datalogic = new JsonFileData();
           datalogic = new JsonFileData();

        }

        public void AddWord(string Word, string Meaning, string Sentence, string userName)
        {           
             datalogic.AddWord(Word, Meaning, Sentence, userName);
        }

        public bool RemoveWord(string remove, string userName)
        {
            return datalogic.RemoveWord(remove, userName);
        }

        public SetVocabulary SearchWord(string search, string userName)
        {
            return datalogic.SearchWord(search, userName);
        }

        public void CreateAccount(string userName, string passWord)
        {
            datalogic.CreateAccount(userName, passWord);
        }

        public bool DeleteAccount(string userName, string passWord)
        {
            return datalogic.DeleteAccount(userName, passWord);
        }


        public List<UserAccount> GetAllAccounts()
        {
            return datalogic.GetAccounts();
        }
      
        public List<SetVocabulary> GetAllWords(string userName)
        {
            return datalogic.GetAllWords(userName);
        }

        public bool UpdateWord(string oldWord, string newWord, string newMeaning, string newSentence, string userName)
        {
            return datalogic.UpdateWord(oldWord, newWord, newMeaning, newSentence, userName);
        }

       

    }
}
