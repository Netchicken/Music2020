using System.Collections.Generic;
using System.Data;
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

        #region Code not needed delete is necessary
        /*  public DataTable FillDGVOwnerWithOwner()
          {
              DataTable dt = new DataTable(); //temp table to hold the data

              using (dataAdapter = new SqlDataAdapter("select * from Owner", Connection))
              {
                  //connect to DB and get SQL
                  Connection.Open();

                  dataAdapter.Fill(dt);

                  Connection.Close();

              }
              return dt;
          }
  */

        /*  public DataTable FillDGVCDWithCD()
          {
              DataTable dt = new DataTable(); //temp table to hold the data

              using (dataAdapter = new SqlDataAdapter("select * from CD", Connection))
              {
                  //connect to DB and get SQL
                  Connection.Open();

                  dataAdapter.Fill(dt);

                  Connection.Close();

              }
              return dt;
          }*/

        #endregion


        public DataTable FillDGVs(string TableName)
        {
            DataTable dt = new DataTable(); //temp table to hold the data

            string query = "select * from " + TableName;

            using (dataAdapter = new SqlDataAdapter(query, Connection))
            {
                //connect to DB and get SQL
                Connection.Open();

                dataAdapter.Fill(dt);

                Connection.Close();

            }
            return dt;
        }

        public DataTable FillOtherDGVs(string TableName, string ForeignKey, int ID)
        {
            DataTable dt = new DataTable(); //temp table to hold the data

            string query = "select * from " + TableName + " where " + ForeignKey + "=" + ID;

            using (dataAdapter = new SqlDataAdapter(query, Connection))
            {
                //connect to DB and get SQL
                Connection.Open();

                dataAdapter.Fill(dt);

                Connection.Close();

            }
            return dt;
        }







        public List<string> FillListBoxWithGenre()
        {

            var myCommand = new SqlCommand("select genre from UniqueGenreToday", Connection);
            var newgenre = new List<string>();

            //connect to DB and get SQL
            Connection.Open();

            SqlDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                newgenre.Add(reader["genre"].ToString());

            }
            reader.Close();

            Connection.Close();
            return newgenre;

        }



    }
}
