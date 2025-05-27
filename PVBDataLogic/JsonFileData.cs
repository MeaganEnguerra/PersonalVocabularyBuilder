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
        static List<UserAccount> userAccount = new List<UserAccount>();
        static string jsonFilePath = "accounts.json";

        public JsonFileData()
        {
            GetJsonDataFromFile();
        }

        private void GetJsonDataFromFile()
        {
            string jsonText = File.ReadAllText(jsonFilePath);

            userAccount = JsonSerializer.Deserialize<List<UserAccount>>(jsonText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }

        private void WriteJsonDataToFile()
        {
            string jsonString = JsonSerializer.Serialize(userAccount, new JsonSerializerOptions
            { WriteIndented = true });

            File.WriteAllText(jsonFilePath, jsonString);
        }

        public void CreateAccount(UserAccount account,string userName, int password)
        {
            userAccount.Add(account);
            WriteJsonDataToFile();
        }

    }
}
