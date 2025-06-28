using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabularyCommon;

namespace PVBDataLogic
{
    internal class DBFile : IDataLogic
    {

        static string conectionString
            = "Data Source=DESKTOP-KK05HHB\\SQLEXPRESS; Initial Catalog = VocaBee; Integrated Security = True; TrustServerCertificate=True";
        static SqlConnection sqlConnection;

        public DBFile()
        {
        sqlConnection = new SqlConnection(conectionString);          
        }        

        public void CreateAccount (string userName, string passWord)
        {
            var insertStatement = "INSERT INTO Accounts (Username, Password) VALUES (@Username, @Password)";
            sqlConnection.Open();
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@Username", userName);
            insertCommand.Parameters.AddWithValue("@Password", passWord);            
           
            insertCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public bool DeleteAccount(string userName, string passWord)
        {
            sqlConnection.Open();

            var deleteStatement = $"DELETE FROM Accounts WHERE Username = @Username AND Password = @Password";
            SqlCommand updateCommand = new SqlCommand(deleteStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@Username", userName);
            updateCommand.Parameters.AddWithValue("@Password", passWord);

            int rowsAffected = updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return rowsAffected > 0;
        }

        public List<UserAccount> GetAccounts()
        {
            string selectStatement = "SELECT Username, Password FROM Accounts";
            sqlConnection.Open();

            SqlCommand command = new SqlCommand(selectStatement, sqlConnection);


            SqlDataReader reader = command.ExecuteReader();

            var accounts = new List<UserAccount>();

            while (reader.Read())
            {
                UserAccount userAccount = new UserAccount();
                userAccount.Username = reader["Username"].ToString().Trim();
                userAccount.Password = reader["Password"].ToString().Trim();

                accounts.Add(userAccount);
            }

            sqlConnection.Close();
            return accounts;

        }

        public List<SetVocabulary> GetAllWords(string userName)
        {
            string selectStatement = "SELECT Word, Meaning, Sentence FROM Vocabularies WHERE Username = @Username";

            SqlCommand command = new SqlCommand(selectStatement, sqlConnection);
            command.Parameters.AddWithValue("@Username", userName);
            sqlConnection.Open();

            SqlDataReader reader = command.ExecuteReader();

            var setVocabularies = new List<SetVocabulary>();

            while (reader.Read())
            {
                setVocabularies.Add(new SetVocabulary()
                {
                    Word = reader["Word"].ToString(),
                    Meaning = reader["Meaning"].ToString(),
                    Sentence = reader["Sentence"].ToString(),                   
                });

            }

            sqlConnection.Close();
            return setVocabularies;
        }

        public void AddWord(string word, string meaning, string sentence, string userName)
        {
            string insertStatement = @"INSERT INTO Vocabularies (Username, Word, Meaning, Sentence) 
                               VALUES (@Username, @Word, @Meaning, @Sentence)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);
            {
                insertCommand.Parameters.AddWithValue("@Username", userName);
                insertCommand.Parameters.AddWithValue("@Word", word);
                insertCommand.Parameters.AddWithValue("@Meaning", meaning);
                insertCommand.Parameters.AddWithValue("@Sentence", sentence);

                try
                {
                    sqlConnection.Open();
                    insertCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to add word: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }


        public bool RemoveWord(string remove, string userName)
        {
            var removeStatement = "DELETE FROM Vocabularies WHERE Word = @Word AND Username = @Username";
            sqlConnection.Open();
            SqlCommand removeCommand = new SqlCommand(removeStatement, sqlConnection);

            removeCommand.Parameters.AddWithValue("@Word", remove);
            removeCommand.Parameters.AddWithValue("@Username", userName);

            int rowsAffected = removeCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return rowsAffected > 0;
        }

        public SetVocabulary SearchWord(string search, string userName)
        {
            string query = "SELECT * FROM Vocabularies WHERE Word = @Word AND Username = @Username";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@Word", search);
            command.Parameters.AddWithValue("@Username", userName);

            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();

            SetVocabulary result = null;
            if (reader.Read())
            {
                result = new SetVocabulary
                {
                    Word = reader["Word"].ToString(),
                    Meaning = reader["Meaning"].ToString(),
                    Sentence = reader["Sentence"].ToString()
                };
            }

            reader.Close();
            sqlConnection.Close();
            return result;
        }


        public bool UpdateWord(string oldWord, string newWord, string newMeaning, string newSentence, string userName)
        {
            sqlConnection.Open();
            var updateStatement = "UPDATE Vocabularies SET Word = @newWord, Meaning = @newMeaning, Sentence = @newSentence WHERE Username = @Username AND Word = @oldWord";

            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@NewWord", newWord);
            updateCommand.Parameters.AddWithValue("@NewMeaning", newMeaning);
            updateCommand.Parameters.AddWithValue("@NewSentence", newSentence);
            updateCommand.Parameters.AddWithValue("@OldWord", oldWord);
            updateCommand.Parameters.AddWithValue("@Username", userName);


            int rowsAffected = updateCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return rowsAffected > 0;
        }

        
    }

       
    
}
    