using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using VocabularyCommon;

namespace PVBDataLogic
{
    public class JsonFileData : IDataLogic
    {
        List<UserAccount> accounts = new List<UserAccount>();
        List<SetVocabulary> setVocabularies = new List<SetVocabulary>();
        string jsonFilePathAccounts = "accounts.json";
        string jsonFilePathVocabularies = "vocabularies.json";
       

        public JsonFileData()
        {
            GetDataFromAccounts();
            GetDataFromVocabularies();
        }

        private void GetDataFromAccounts()
        {
            string jsonText = File.ReadAllText(jsonFilePathAccounts);

            accounts = JsonSerializer.Deserialize<List<UserAccount>>(jsonText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }

        private void GetDataFromVocabularies()
        {
            string jsonText = File.ReadAllText(jsonFilePathVocabularies);

            setVocabularies = JsonSerializer.Deserialize<List<SetVocabulary>>(jsonText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }

        private void WriteDataToAccounts()
        {
            string jsonString = JsonSerializer.Serialize(accounts, new JsonSerializerOptions
            { WriteIndented = true });

            File.WriteAllText(jsonFilePathAccounts, jsonString);
        }

        private void WriteDataToVocabularies()
        {
            string jsonString = JsonSerializer.Serialize(setVocabularies, new JsonSerializerOptions
            { WriteIndented = true });

            File.WriteAllText(jsonFilePathVocabularies, jsonString);
        }

        public int FindIndexOfAccounts(UserAccount account)
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

        public int FindIndexOfVocabularies(string word)
        {
            for (int index = 0; index < setVocabularies.Count; index++)
            {
                if (setVocabularies[index].Word.Equals(word, StringComparison.OrdinalIgnoreCase))
                {
                    return index;
                }
            }

            return -1;
        }
        public void CreateAccount(string username, string password)
        {

            if (accounts.Any(a => a.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }

            UserAccount newAccount = new UserAccount()
            {

                Username = username,
                Password = password
            };

            accounts.Add(newAccount);
            WriteDataToAccounts();
        }

        public List<UserAccount> GetAccounts()
        {
            return accounts;
        }


        public bool  DeleteAccount(string username, string password)
        {

            var account = accounts.FirstOrDefault(a =>
                a.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && a.Password == password);

            if (account != null)
            {
                accounts.Remove(account);
                WriteDataToAccounts();
                return true;
            }
            return false;
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
