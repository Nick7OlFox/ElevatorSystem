using System;
using System.Data.Common;
using System.IO;
using System.Reflection;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment1
{
    class Database
    {
        private String Query, Location, RelativePath, Parentdir, TrimmedPath, AbsolutePath;
        public String LogS;

        public Database()
        {
            RelativePath = @"Database\Database.db";
            Parentdir = Path.GetDirectoryName(Application.StartupPath);
            TrimmedPath = Parentdir.Remove(Parentdir.Length - 24, 24);
            AbsolutePath = Path.Combine(TrimmedPath, RelativePath);

            Location = string.Format("DataSource={0}", AbsolutePath);
        }

        public void Log (String Detail)
        {

            Query = "INSERT INTO Lift_Log (Log) VALUES (" + "\"" + Detail + "\"" + ");";

            using (SQLiteConnection conn = new SQLiteConnection(Location))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    conn.Open();
                    cmd.CommandText = Query;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    catch (Exception e)
                    {
                        conn.Close();
                        Console.WriteLine(e);
                    }
                }
            }
        }

        public void Get()
        {
            Query = "SELECT * FROM Lift_Log;";

            using (SQLiteConnection conn = new SQLiteConnection(Location))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    conn.Open();
                    cmd.CommandText = Query;
                    try
                    {
                        cmd.ExecuteNonQuery();
            
                       using (System.Data.SQLite.SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                LogS = LogS + dr["Time_Stamp"].ToString() + ": " + dr["Log"].ToString() + "@" ;
                                
                            }
                            conn.Close();
                        }
                    }
                    catch (Exception e)
                    {
                        conn.Close();
                        Console.WriteLine(e);
                    }
                }
            }
            LogS = LogS.Replace("@", System.Environment.NewLine);
        }
    }
}
