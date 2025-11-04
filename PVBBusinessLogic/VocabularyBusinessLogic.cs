using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Net.NetworkInformation;
using PVBDataLogic;
using VocabularyCommon;
using EmailFunc;
using Microsoft.Extensions.Configuration;

namespace PVBBusinessLogic
{
    public class VocabularyBusinessLogic
    {
        VocabularyDataLogic vocabularyDataLogic = new VocabularyDataLogic();
    

        private readonly EmailSMTP _emailService;

        public VocabularyBusinessLogic(EmailSMTP emailService)
        {
            _emailService = emailService;
        }

        public  void AddWord(string addWord, string addMeaning, string addSentence, string userName)
        {
             vocabularyDataLogic.AddWord (addWord, addMeaning, addSentence, userName);
        }

        public bool RemoveWord (string remove, string userName)
        {
           return vocabularyDataLogic.RemoveWord (remove, userName);
        }
      
        public  bool UpdateWord(string oldWord, string newWord, string newMeaning, string newSentence, string userName)
        {
            return vocabularyDataLogic.UpdateWord(oldWord, newWord,newMeaning, newSentence, userName);
        }

        public void CreateAccount(string username, string password)
        {
            vocabularyDataLogic.CreateAccount(username, password);
            _emailService.SendEmail(username, password);
        }

        public bool  DeleteAccount(string username, string password)
        {
            return vocabularyDataLogic.DeleteAccount(username, password);
        }

        public  SetVocabulary SearchWord(string search, string userName)
        {
            return vocabularyDataLogic.SearchWord(search, userName);
        }

        public List<SetVocabulary> GetAllWords(string userName)
        {
            return vocabularyDataLogic.GetAllWords(userName);
        }

      
        public class GameMode
        {
       
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

        public (string Meaning, string Word) GetRandom(string userName)
        {
         
            var allWords = vocabularyDataLogic.GetAllWords(userName);

            if (allWords.Count == 0 || GameMode.usedIndexes.Count == allWords.Count)
                return (null, null); 

            int index;
            do
            {
                index = GameMode.randomMeaning.Next(allWords.Count);
            } while (GameMode.usedIndexes.Contains(index)); 

            GameMode.usedIndexes.Add(index); 

            var selected = allWords[index];
            return (selected.Meaning, selected.Word);
        }


        public bool ValidateVocabularyAccount(string username, string password)
        {

            username = username.Trim().ToLower();    
            password = password.Trim();              


            var account = GetAccount(username, password);

            if (account   != null)
            {
                return true;
            }

            return false;
        }

      

        public UserAccount GetAccount(string userName, string passWord)
        {
            var Accounts = vocabularyDataLogic.GetAllAccounts();
       
            foreach (var account in Accounts)
            {
                if (account.Username.Trim() == userName.Trim() && account.Password.Trim() == passWord.Trim())
                {
                    return account; 
                }
            }
            return null;
        }

        public bool ExistedAccounts(string userName)
        {
            var allAccounts = vocabularyDataLogic.GetAllAccounts();
            return allAccounts.Any(acc => acc.Username.Equals(userName.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public List<UserAccount> GetAllAccounts()
        {
            return vocabularyDataLogic.GetAllAccounts();
        }

    }
}
