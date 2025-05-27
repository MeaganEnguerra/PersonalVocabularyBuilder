using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyCommon;

namespace PVBDataLogic
{
    internal class DBFile : IDataLogic
    {

        static string conectionString
            = "Data Source=DESKTOP-IEJ8MT8\\MSSQLSERVER01; Initial Catalog = Vocabulary; Integrated Security = True; TrustServerCertificate=True";

        static SqlConnection sqlConnection;

        public DBFile()
        {
            sqlConnection = new SqlConnection(conectionString);
            sqlConnection.Open();
        }

        public void AddWord(string word, string meaning, string sentence)
        {
            throw new NotImplementedException();
        }

        public void CreateAccount(UserAccount account, string userName, string password)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount(UserAccount account, string userName)
        {
            throw new NotImplementedException();
        }

        public List<UserAccount> GetAccounts()
        {
            string selectStatement = "SELECT * FROM accounts";

            SqlCommand command = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();

            SqlDataReader reader = command.ExecuteReader();

            var userAccounts = new List<UserAccount>();

            while (reader.Read())
            {
                userAccounts.Add(new UserAccount
                {
                    UserName = reader["UserName"].ToString(),
                    Password = reader["Password"].ToString()
                });
            }
            sqlConnection.Close();
            return userAccounts;

        }

        public bool RemoveWord(string word)
        {
            throw new NotImplementedException();
        }

        public string SearchWord(string word)
        {
            throw new NotImplementedException();
        }

        public bool UpdateWord(string oldWord, string newWord, string newMeaning, string newSentence)
        {
            throw new NotImplementedException();
        }
    }
}
