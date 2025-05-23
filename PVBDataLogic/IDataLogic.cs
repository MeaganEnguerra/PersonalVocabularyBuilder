using VocabularyCommon;

namespace PVBDataLogic
{
    public interface IDataLogic
    {

        public List<UserAccount> GetAccounts();
        public void CreateAccount(UserAccount account, string userName, string password);
        public void DeleteAccount(UserAccount account, string userName);

        public void AddWord(string word, string meaning, string sentence);
        bool RemoveWord(string word);
        bool UpdateWord(string oldWord, string newWord, string newMeaning, string newSentence);
        string SearchWord(string word);
        //List<string> GetAllWords();





    }
}
