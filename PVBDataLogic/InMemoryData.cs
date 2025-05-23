using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using VocabularyCommon;

namespace PVBDataLogic
{
    public class InMemoryData : IDataLogic
    {
        private List<UserAccount> accounts = new List<UserAccount>();
        
        public InMemoryData()
        {
        AddUserAccount();
        }
        private void AddUserAccount()
        {
            UserAccount account1 = new UserAccount();
            account1.UserName = "meagan";
            account1.Password = "1234";
            accounts.Add(account1);

            UserAccount account2 = new UserAccount();
            account2.UserName = "mina";
            account2.Password = "0000";
            accounts.Add(account2);

            UserAccount account3 = new UserAccount();
            account3.UserName = "zy";
            account3.Password = "1111";
            accounts.Add(account3);
        }

        public void CreateAccount(UserAccount account, string userName, string password)
        {
            {
                accounts.Add(new UserAccount
                {
                    UserName = userName,
                    Password = password,
                });
            }
        }

        public void DeleteAccount(UserAccount account, string userName)
        {
            var accountToRemove = accounts.FirstOrDefault(a => a.UserName == userName);
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].UserName == userName)
                {
                    accounts.RemoveAt(i);
                    break;
                }
            }
        }

        public bool ValidateVocabularyAccount(string userName, string passWord) //dapat nasa bussiness logic
        {
            foreach (var account in accounts)
            {
                if (account.UserName == userName && account.Password == passWord)
                {
                    return true;
                }
            }
            return false;
        }

        
    }
}

