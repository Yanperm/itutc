using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ITUTCSQLSERVER
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
        public static void Insert(string TEACHERID, string TEACHER_NAME, string TEACHER_ADVISOR_GROUP)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"INSERT INTO tbTeacher(ACTIVITY_ID,ACTIVITY_NAME,ACTIVITY_DATE,ACTIVITY_STATUS) VALUES(@ACTIVITY_ID,@ACTIVITY_NAME,@ACTIVITY_DATE,@ACTIVITY_STATUS)";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@ACTIVITY_ID", TEACHERID);
                Command.Parameters.AddWithValue("@ACTIVITY_NAME", TEACHER_NAME);
                Command.Parameters.AddWithValue("@ACTIVITY_DATE", TEACHER_ADVISOR_GROUP);
                Command.Parameters.AddWithValue("@ACTIVITY_STATUS", TEACHER_ADVISOR_GROUP);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        public static void Update(string Var1, string Var2)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = "UPDATE table SET Field=@field WHERE field_id='" + Var1 + Var2;
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@var1", Var1);
                Command.Parameters.AddWithValue("@var2", Var2);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        public static void Delete(string VarID)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"DELETE FROM table WHERE VarID=@VarID";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@StudentID", VarID);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

    }
}
