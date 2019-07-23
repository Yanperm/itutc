﻿using System;
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
        public static void Insert(string ACTIVITY_ID, string ACTIVITY_NAME, string ACTIVITY_DATE, string ACTIVITY_STATUS)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"INSERT INTO tbTeacher(ACTIVITY_ID,ACTIVITY_NAME,ACTIVITY_DATE,ACTIVITY_STATUS) VALUES(@ACTIVITY_ID,@ACTIVITY_NAME,@ACTIVITY_DATE,@ACTIVITY_STATUS)";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@ACTIVITY_ID", ACTIVITY_ID);
                Command.Parameters.AddWithValue("@ACTIVITY_NAME", ACTIVITY_NAME);
                Command.Parameters.AddWithValue("@ACTIVITY_DATE", ACTIVITY_DATE);
                Command.Parameters.AddWithValue("@ACTIVITY_STATUS", ACTIVITY_STATUS);
                Command.ExecuteNonQuery();

                

            }
            finally
            {
                Database.Connection.Close();
            }
        }
        public static void Update(string ACTIVITY_ID, string ACTIVITY_NAME, string ACTIVITY_DATE, string ACTIVITY_STATUS)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = "UPDATE tbTeacher SET ACTIVITY_NAME=@ACTIVITY_NAME,ACTIVITY_DATE=@ACTIVITY_DATE,ACTIVITY_STATUS=@ACTIVITY_STATUS WHERE ACTIVITY_ID=@ACTIVITY_ID'" + ACTIVITY_ID + ACTIVITY_NAME + ACTIVITY_DATE + ACTIVITY_STATUS;
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@ACTIVITY_ID", ACTIVITY_ID);
                Command.Parameters.AddWithValue("@ACTIVITY_NAME", ACTIVITY_NAME);
                Command.Parameters.AddWithValue("@ACTIVITY_DATE", ACTIVITY_DATE);
                Command.Parameters.AddWithValue("@ACTIVITY_STATUS", ACTIVITY_STATUS);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }
        public static void Delete(string ACTIVITY_ID)
        {
            try
            {
                Database.Connection.Open();
                string sqlCommand = @"DELETE FROM tbTeacher WHERE ACTIVITY_ID=@ACTIVITY_ID";
                SqlCommand Command = new SqlCommand(sqlCommand, Database.Connection);
                Command.Prepare();
                Command.Parameters.AddWithValue("@ACTIVITY_ID", ACTIVITY_ID);
                Command.ExecuteNonQuery();
            }
            finally
            {
                Database.Connection.Close();
            }
        }

    }
}
