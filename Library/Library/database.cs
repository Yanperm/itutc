using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
    class Database
    {
        private static string strConnect = @"Data Source=softubon.database.windows.net;Initial Catalog=Db_Book;Persist Security Info=True;User ID=softubon;Password=xkiN8gdviN";
        private static SqlConnection con;
        static Database()
        {
            con = new SqlConnection(strConnect);
        }
        public static SqlConnection Connection
        {
            get { return con; }
        }
        public static int Query(string Command)
        {
            int RowAffect = 0;
            try
            {
                Connection.Open();
                SqlCommand Cmd = new SqlCommand(Command, Connection);
                RowAffect = Cmd.ExecuteNonQuery();
            }
            finally
            {
                Connection.Close();
            }
            return RowAffect;
        }
        public static DataTable getData(string Query)
        {
            DataTable data;
            try
            {
                Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, Connection);
                data = new DataTable();
                adapter.Fill(data);
            }
            finally
            {
                Connection.Close();
            }
            return data;
        }
    }
}
