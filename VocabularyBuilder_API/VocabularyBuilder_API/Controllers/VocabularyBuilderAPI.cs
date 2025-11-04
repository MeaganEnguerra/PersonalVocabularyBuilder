using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PVBBusinessLogic;
using VocabularyCommon;
using PVBDataLogic;

namespace VocabularyBuilder_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VocabularyBuilderAPI : ControllerBase
    {
        //VocabularyBusinessLogic vocabularyBusinessLogic = new VocabularyBusinessLogic();
        private readonly PVBBusinessLogic.VocabularyBusinessLogic _vocabularyBusinessLogic;

        public VocabularyBuilderAPI(PVBBusinessLogic.VocabularyBusinessLogic vocabularyBusinessLogic)
        {
            _vocabularyBusinessLogic = vocabularyBusinessLogic;
        }


        [HttpGet("AddWord")]
        public void AddWord(string addWord, string addMeaning, string addSentence, string userName)
        {
            _vocabularyBusinessLogic.AddWord(addWord, addMeaning, addSentence, userName);
        }

        [HttpDelete("RemoveWord")]
        public bool RemoveWord(string remove, string userName)
        {
            return _vocabularyBusinessLogic.RemoveWord(remove, userName);
        }

        [HttpPatch("UpdateWord")]
        public bool UpdateWord(string oldWord, string newWord, string newMeaning, string newSentence, string userName)
        {
            return _vocabularyBusinessLogic.UpdateWord(oldWord, newWord, newMeaning, newSentence, userName);
        }

        [HttpPost("CreateAccount")]
        public void CreateAccount(string username, string password)
        {
            _vocabularyBusinessLogic.CreateAccount(username, password);
        }

        [HttpDelete("DeleteAccount")]
        public bool DeleteAccount(string userName, string passWord)
        {
            return _vocabularyBusinessLogic.DeleteAccount(userName, passWord);
        }

        [HttpGet("SearchWord")]
        public SetVocabulary SearchWord(string search, string userName)
        {
            return _vocabularyBusinessLogic.SearchWord(search, userName);
        }

        [HttpGet("GetAllWords")]
        public List<SetVocabulary> GetAllWords(string userName)
        {
            return _vocabularyBusinessLogic.GetAllWords(userName);
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

        [HttpGet ("GetRandom")]
        public (string Meaning, string Word) GetRandom(string userName)
        {

            var allWords = _vocabularyBusinessLogic.GetAllWords(userName);

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

        [HttpGet("ValidateVocabularyAccount")]
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

        [HttpGet("GetAccount")]
        public UserAccount GetAccount(string userName, string passWord)
        {
            var Accounts = _vocabularyBusinessLogic.GetAllAccounts();

            foreach (var account in Accounts)
            {
                if (account.Username.Trim() == userName.Trim() && account.Password.Trim() == passWord.Trim())
                {
                    return account;
                }
            }
            return null;
        }


        [HttpGet("ExistedAccounts")]
        public bool ExistedAccounts(string userName)
        {
            var allAccounts = _vocabularyBusinessLogic.GetAllAccounts();
            return allAccounts.Any(acc => acc.Username.Equals(userName.Trim(), StringComparison.OrdinalIgnoreCase));


        }
    }
}
