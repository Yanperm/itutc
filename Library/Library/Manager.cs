using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
    class Manager
    {
        public static void Query(string Command)
        {
            Database.Connection.Open();
            SqlCommand cmd = new SqlCommand(Command, Database.Connection);
            cmd.ExecuteNonQuery();
            Database.Connection.Close();
        }

        //Function Insert
        public static void Insertbook(string Book_id, string Book_name, string Book_amount, string Book_cat)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"INSERT INTO table_book(Book_id,Book_name,Book_amount,Book_cat) VALUES(@Book_id,@Book_name,@Book_amount,@Book_cat)";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@Book_id", Book_id);
                Command.Parameters.AddWithValue("@Book_name", Book_name);
                Command.Parameters.AddWithValue("@Book_amount", Book_amount);
                Command.Parameters.AddWithValue("@Book_cat", Book_cat);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        //Function Update
        public static void Updatebook(string Book_id, string Book_name, string Book_amount, string Book_cat)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"UPDATE table_book SET Book_name=@Book_name,Book_amount=@Book_amount,Book_cat=@Book_cat WHERE Book_id='" + Book_id + "'";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@Book_id", Book_id);
                Command.Parameters.AddWithValue("@Book_name", Book_name);
                Command.Parameters.AddWithValue("@Book_amount", Book_amount);
                Command.Parameters.AddWithValue("@Book_cat", Book_cat);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        // Function Delete
        public static void Deletebook(string Book_id)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"DELETE FROM table_book WHERE Book_id=@Book_id";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@Book_id", Book_id);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
    }
}