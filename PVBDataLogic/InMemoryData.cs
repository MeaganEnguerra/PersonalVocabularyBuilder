using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using VocabularyCommon;

namespace PVBDataLogic
{
    public class InMemoryData : IDataLogic
    {
        List<UserAccount> accounts = new List<UserAccount>();
        List <SetVocabulary> setVocabularies = new List<SetVocabulary>();

        public InMemoryData()
        {
        AddUserAccount();
        AddVocabulary();

        }
        private void AddUserAccount()
        {
            UserAccount account1 = new UserAccount();
            account1.Username = "meagan";
            account1.Password = "1234";
            accounts.Add(account1);

            UserAccount account2 = new UserAccount();
            account2.Username = "mina";
            account2.Password = "0000";
            accounts.Add(account2);

            UserAccount account3 = new UserAccount();
            account3.Username = "zy";
            account3.Password = "1111";
            accounts.Add(account3);
        }

        private void AddVocabulary()
        {
            SetVocabulary vocabulary1 = new SetVocabulary();
            vocabulary1.Word = "abandon";
            vocabulary1.Meaning = "to give up completely";
            vocabulary1.Sentence = "He had to abandon his car.";
            setVocabularies.Add(vocabulary1);

            SetVocabulary vocabulary2 = new SetVocabulary();
            vocabulary2.Word = "benevolent";
            vocabulary2.Meaning = "well meaning and kindly";
            vocabulary2.Sentence = "A benevolent smile.";
            setVocabularies.Add(vocabulary2);
        }

        public List<SetVocabulary> GetAllWords(string userName)
        {
            return setVocabularies;
        }

        public List<UserAccount> GetAccounts()
        {
            return accounts;
        }

        public void CreateAccount(string userName, string passWord)
        {
            if (accounts.Any(a => a.Username.Equals(userName, StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }

            UserAccount newAccount = new UserAccount()
            {
              
                Username = userName,
                Password = passWord
            };

            accounts.Add(newAccount);
        }


        public bool DeleteAccount(string account, string userName)
        {
            var accountToRemove = accounts.FirstOrDefault(a => a.Username == userName);
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Username == userName)
                {
                    accounts.RemoveAt(i);
                    break;
                }
            } return false;
        }
   
    
        public void AddWord(string word, string meaning, string sentence, string userName)
        {
            setVocabularies.Add(new SetVocabulary(word, meaning, sentence));
        }

            
        public bool RemoveWord(string remove, string userName)
        {
            for (int index = 0; index < setVocabularies.Count; index++)
            {
                if (setVocabularies[index].Word.Equals(remove, StringComparison.OrdinalIgnoreCase))
                {
                    setVocabularies.RemoveAt(index);
                    return true;
                }
            }
            return false;
        }


        public SetVocabulary SearchWord(string search, string userName)
        {
            foreach (var vocab in setVocabularies)
            {
                if (vocab.Word.Equals(search, StringComparison.OrdinalIgnoreCase))
                {
                    return vocab;
                }
            }
            return null;
        }

        public bool UpdateWord(string oldWord, string newWord, string newMeaning, string newSentence, string userName)
        {
            foreach (var vocab in setVocabularies)
            {
                if (vocab.Word.Equals(oldWord, StringComparison.OrdinalIgnoreCase))
                {
                    vocab.Word = newWord;
                    vocab.Meaning = newMeaning;
                    vocab.Sentence = newSentence;
                    return true;
                }
            }
            return false;
        }

        public List<UserAccount> GetAllAccounts()
        {
            return accounts;
        }
    }
}

