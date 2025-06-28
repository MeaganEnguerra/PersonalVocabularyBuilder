using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using VocabularyCommon;

namespace PVBDataLogic
{
    public class TextFileData : IDataLogic
    {
        string filepathOfAccounts = "accounts.txt";
        string filepathOfVocabularies = "vocabularies.txt";

        List<UserAccount> accounts = new List<UserAccount>();
        List<SetVocabulary> setVocabularies = new List<SetVocabulary>();
        public TextFileData()
        {
            GetDataFromAccounts();
            GetDataFromVocabularies();
        }


        private void GetDataFromAccounts()
        {
            var lines = File.ReadAllLines(filepathOfAccounts);

            foreach (var line in lines)
            {
                var parts = line.Split('|');

                accounts.Add(new UserAccount
                {
                    Username = parts[0],
                    Password = parts[1]
                });
            }
        }

        private void GetDataFromVocabularies()
        {
            var lines = File.ReadAllLines(filepathOfVocabularies);

            foreach (var line in lines)
            {
                var parts = line.Split('|');

                setVocabularies.Add(new SetVocabulary
                {
                    Word = parts[0],
                    Meaning = parts[1],
                    Sentence = parts[2]
                });
            }
        }

        private void WriteDataToAccounts()
        {
            var lines = new string[accounts.Count];

            for (int i = 0; i < accounts.Count; i++)
            {
                lines[i] = $"{accounts[i].Username}|{accounts[i].Password}";
            }

            File.WriteAllLines(filepathOfAccounts, lines);
        }

        private void WriteDataToVocabularies()
        {
            var lines = new string[setVocabularies.Count];

            for (int i = 0; i < accounts.Count; i++)
            {
                lines[i] = $"{setVocabularies[i].Word}|{setVocabularies[i].Meaning}|{setVocabularies[i].Sentence}";
            }

            File.WriteAllLines(filepathOfVocabularies, lines);
        }


        public int FindIndex(UserAccount account)
        {
            for (int index = 0; index < accounts.Count; index++)
            {
                if (accounts[index].Username == account.Username)
                {
                    return index;
                }
            }

            return -1;
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
                WriteDataToAccounts();          
        }

        public bool DeleteAccount(string userName, string passWord)
        {
            {
                var account = accounts.FirstOrDefault(a =>
                    a.Username.Equals(userName, StringComparison.OrdinalIgnoreCase) && a.Password == passWord);

                if (account != null)
                {
                    accounts.Remove(account);
                    WriteDataToAccounts();
                    return true;
                }
                return false;
            }
        }

        public void AddWord(string word, string meaning, string sentence, string userName)
        {
            setVocabularies.Add(new SetVocabulary(word, meaning, sentence));
            WriteDataToVocabularies(); 
        }

        public bool RemoveWord(string remove, string userName)
        {
            GetDataFromVocabularies();
            remove = remove.Trim();
            int index1 = -1;

            for (int index2 = 0; index2 < setVocabularies.Count; index2++)
            {
                if (setVocabularies[index2].Word.Equals(remove, StringComparison.OrdinalIgnoreCase))
                {
                    index1 = 1;
                    break;
                    return true;
                }
            }
            if (index1 != -1)
            {
                setVocabularies.RemoveAt(index1);
                WriteDataToVocabularies();

                return true;
            }
            return false;
        }
        

        public bool UpdateWord(string oldWord, string newWord, string newMeaning, string newSentence, string userName)
        {
            var vocab = setVocabularies.FirstOrDefault(v =>
            v.Word.Equals(oldWord, StringComparison.OrdinalIgnoreCase));

            if (vocab != null)
            {
                
                vocab.Word = newWord;
                vocab.Meaning = newMeaning;
                vocab.Sentence = newSentence;
              
                WriteDataToVocabularies();
                return true;
            }
           return false;
        }


        public SetVocabulary SearchWord(string search, string userName)
        {
            GetDataFromVocabularies();
            foreach (var vocab in setVocabularies)
            {
                if (vocab.Word.Equals(search, StringComparison.OrdinalIgnoreCase))
                {
                    return vocab;
                }
            }
            return null;
        }
        public List<SetVocabulary> GetAllWords(string userName)
        {
            GetDataFromVocabularies();
            return setVocabularies;
        }
        public List<UserAccount> GetAllAccounts()
        {
            return accounts;
        }
    }
}
