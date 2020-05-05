using System.Data.SqlClient;

namespace Music2020
{
    //Data Source=GARYLAPTOP\SQLEXPRESS01;Initial Catalog=Music;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
    class Database
    {
        //Create a Connection, Command, Adapter
        private SqlConnection Connection = new SqlConnection(); //connect to db
        private SqlCommand Command = new SqlCommand();   //give it a query
        private SqlDataAdapter dataAdapter = new SqlDataAdapter(); //hold the results

        public Database()
        {
            string connectionString = @"Data Source=GARYLAPTOP\SQLEXPRESS01;Initial Catalog=Music;Integrated Security=True;Connect Timeout=30;";
            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;

        }




    }
}
