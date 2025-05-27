using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using VocabularyCommon;

namespace PVBDataLogic
{
    public class TextFileData : IDataLogic
    {
        string filepath = "account.txt";
        List<UserAccount> userAccount = new List<UserAccount>();

        public TextFileData()
        {
            GetDataFromAccountFile();
        }

        private void GetDataFromAccountFile()
        {
            var lines = File.ReadAllLines(filepath);

            foreach (var line in lines)
            {
                var parts = line.Split('|');

                userAccount.Add(new UserAccount
                {
                    UserName = parts[0],
                    Password = parts[1]
                });
            }
        }

        private void WriteDataToFile()
        {
            var lines = new string[userAccount.Count];

            for (int i = 0; i < userAccount.Count; i++)
            {
                lines[i] = $"{userAccount[i].UserName}|{userAccount[i].Password}";
            }

            File.WriteAllLines(filepath, lines);
        }

        


        public List<UserAccount> GetAccounts()
        {
            return userAccount;
        }

        public void AddAccount(UserAccount account, string userName, int password)
        {
            var newLine = account.UserName + "|" + account.Password;

            File.AppendAllText(filepath, newLine);
          
        }

        public void RemoveAccount(UserAccount account, int password)
        {
            int index = -1;
            for (int i = 0; i < userAccount.Count; i++)
            {
                if (userAccount[i].UserName == account.UserName)
                {
                    index = i;
                }
            }
        }
    }
}
