using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace it.schule
{
    class DBConnectorMysql
    {

        private MySqlConnection actCon = null;
        private string username;
        private static DBConnectorMysql singleInstance = null;
        public static DBConnectorMysql GetInstance()
        {
            if (singleInstance == null)
                singleInstance = new DBConnectorMysql();
            return singleInstance;

        }
        public string Username
        {
            get { return username; }
            set { username = value; UpdateConnectionString(); }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; UpdateConnectionString(); }
        }
        private string server;

        public string Server
        {
            get { return server; }
            set { server = value; UpdateConnectionString(); }
        }
        private string datenbank;

        public string Database
        {
            get { return datenbank; }
            set { datenbank = value; UpdateConnectionString(); }
        }
        public void CloseConnection()
        {
            actCon.Close();

        }

        public DBConnectorMysql(string pServer, string pDatabase, string pUser, string pPassword) : this()
        {

            server = pServer;
            datenbank = pDatabase;
            username = pUser;
            password = pPassword;
            UpdateConnectionString();
        }

        private DBConnectorMysql()
        {
            actCon = new MySqlConnection();

        }
        void UpdateConnectionString()
        {
            actCon.ConnectionString = string.Format("server={0};database={1};userid={2}; password= {3}", server, datenbank, username, password);

        }
        public DataTable ExecuteTable(string parQuery)
        {
            DataTable tempTable = new DataTable();
            //tempTable.
            MySqlCommand tempCom = new MySqlCommand(parQuery, actCon);

            actCon.Open();

            MySqlDataReader tempReader = tempCom.ExecuteReader();
            tempTable.Load(tempReader);
            actCon.Close();
            return tempTable;
        }
        public int ExecuteScalar(string Query)
        {
            MySqlCommand tempCom = new MySqlCommand(Query, actCon);

            actCon.Open();
            object buffer = tempCom.ExecuteScalar();
            int result = Convert.ToInt32(buffer);
            actCon.Close();
            return result;
        }

        public void ExecuteNonQuery(string Query)
        {

            MySqlCommand tempCom = new MySqlCommand(Query, actCon);

            actCon.Open();
            tempCom.CommandText = Query;
            tempCom.ExecuteNonQuery();
            actCon.Close();
          
        }

        public MySqlDataReader Execute(string parQuery)
        {

            try
            {
                MySqlCommand tempCom = new MySqlCommand(parQuery, actCon);
                actCon.Open();
                MySqlDataReader tempReader = tempCom.ExecuteReader();
                return tempReader;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
