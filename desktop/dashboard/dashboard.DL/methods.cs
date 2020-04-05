using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace dashboard.DL
{
    public class methods
    {
        public static string ConnectionString { get { return "Server=localhost;UID=root;PWD=;database=ves_db;Convert Zero Datetime=True"; } }

        public static string EscapeString(String str)
        {
            return MySql.Data.MySqlClient.MySqlHelper.EscapeString(str.Trim());

        }


        public static long executeNonQueryLong(MySqlCommand _cmd)
        {

            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                long rslt = 0;
                MySqlCommand cmd = _cmd;
                MySqlTransaction trans = null;
                try
                {
                    cmd.CommandTimeout = 0;
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    trans = con.BeginTransaction();
                    try
                    {
                        if (cmd.ExecuteNonQuery() >= 1)
                        {
                            rslt = cmd.LastInsertedId;
                        }
                        trans.Commit();

                    }
                    catch (Exception ex)
                    {
                        rslt = 0;
                        trans.Rollback();
                        throw ex;

                    }
                    return rslt;
                }
                finally
                {
                    trans = null;
                }
            }
        }

        public static bool executeNonQueryBool(MySqlCommand _cmd)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                bool rslt = false;
                MySqlCommand cmd = _cmd;
                MySqlTransaction trans = null;
                try
                {
                    cmd.CommandTimeout = 0;
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    trans = con.BeginTransaction();
                    try
                    {
                        if (cmd.ExecuteNonQuery() >= 1)
                        {
                            rslt = true;
                        }
                        trans.Commit();

                    }
                    catch (Exception ex)
                    {
                        rslt = false;
                        trans.Rollback();
                        throw ex;

                    }
                    return rslt;
                }
                finally
                {
                    trans = null;
                }
            }
        }
        public static System.Data.DataTable executeQuery(MySqlCommand _cmd)
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                DataTable dt = new DataTable();
                try
                {
                    con.Open();
                    MySqlCommand cmd = _cmd;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

    }
}
