using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace ATM
{
    class Manager
    {
        public string ConnectionString = @"Server=localhost;Database=atm;Uid=root;Pwd=1234";
        User UO = new User();


        public Object Authenticate(string PinCode)
        {
            //Create Connection
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConnectionString;
            Console.WriteLine(connection.Ping().ToString());
            connection.Open();

            string queryString = "Select Count(*) From userdata Where PinCode = '"+PinCode+"'";

            MySqlCommand command = new MySqlCommand();

            command.CommandText = queryString;
            command.Connection = connection;

            Object result = command.ExecuteScalar();
            return result;
        }
        public DataSet CheckBalance(int Pincode)
        {
            //Create Connection
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConnectionString;
            Console.WriteLine(connection.Ping().ToString());
            connection.Open();

            string queryString = "Select balance From userdata Where PinCode = '"+ Pincode + "'";

            MySqlCommand command = new MySqlCommand();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(queryString,ConnectionString);
            da.Fill(ds);

          

            return ds;

        }
        public void Withdraw()
        {
            //Create Connection
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConnectionString;
            Console.WriteLine(connection.Ping().ToString());
            connection.Open();

            string queryString = "";

            MySqlCommand command = new MySqlCommand();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(queryString, ConnectionString);
            da.Fill(ds);



            //return ds;
        }
        public void Deposit()
        {
            //Create Connection
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = ConnectionString;
            Console.WriteLine(connection.Ping().ToString());
            connection.Open();

            string queryString = "";

            MySqlCommand command = new MySqlCommand();

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(queryString, ConnectionString);
            da.Fill(ds);



            //return ds;
        }
    }
}
