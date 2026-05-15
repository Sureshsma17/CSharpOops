using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOops
{
    class DataBaseConnection
    {
        string connectionstring;
        SqlConnection connection;
        public DataBaseConnection(string connstring)
        {
            connectionstring = connstring;
            connection=new SqlConnection(connectionstring);

        }
        public void OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Database connection open Succesfully");
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
        public void CloseConnection()
        {
            if(connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Close();
                Console.WriteLine("Database connection Closed");
            }
        }
    }
    internal class ParameterizedDataBaseConnection
    {
        static void Main(string[] args)
        {
            string connstring = "Server=SURESH\\MSSQLSERVER1;Initial Catalog=Oops;Integrated Security=True;";
            DataBaseConnection db= new DataBaseConnection(connstring);
            db.OpenConnection();
            db.CloseConnection();
        }
    }
}
