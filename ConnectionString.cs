//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOops
//{
//    class DataBaseConnection
//    {
//        string connectionstring;
//        SqlConnection connection;
//        public DataBaseConnection(string connstring)
//        {
//            connectionstring = connstring;
//            connection = new SqlConnection(connectionstring);//This is constructor which is used to initialize the class level variable

//        }
//        public void OpenConnection()
//        {
//            try//This is try catch block which is used to handle the exception if any exception occurs while opening the connection
//            {
//                connection.Open();
//                Console.WriteLine("Database connection open Succesfully");
//            }
//            catch (Exception e) //This is catch block which is used to catch the exception if any exception occurs while opening the connection
//            {
//                Console.WriteLine(e.Message);
//            }
//        }
//        public void CloseConnection()
//        {
//            if (connection.State == System.Data.ConnectionState.Open)
//            {
//                connection.Close();
//                Console.WriteLine("Database connection Closed");
//            }
//        }
//    }
//    internal class ConnectionString
//    {
//        static void Main(string[] args)
//        {
//            string connstring = "Server=SURESH\\MSSQLSERVER1;Initial Catalog=Oops;Integrated Security=True;";//This is connection string which is used to connect to the database
//            DataBaseConnection db = new DataBaseConnection(connstring);//This is object of the DataBaseConnection class which is used to call the methods of the class
//            db.OpenConnection();//This is method which is used to open the connection
//            db.CloseConnection();//This is method which is used to close the connection
//        }
//    }
//}
