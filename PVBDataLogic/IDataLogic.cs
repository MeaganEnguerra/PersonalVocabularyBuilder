using VocabularyCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVBDataLogic
{
    public interface IDataLogic
    {
        public List<UserAccount> GetAccounts();
        List<SetVocabulary> GetAllWords(string userName);
        public void CreateAccount(string userName, string passWord);
        public bool DeleteAccount(string userName, string passWord);
        public void AddWord(string word, string meaning, string sentence, string userName);
        bool RemoveWord(string remove, string userName);
        public bool UpdateWord(string oldWord, string newWord, string newMeaning, string newSentence, string userName);
        public SetVocabulary SearchWord(string search, string userName);       
    }
}
