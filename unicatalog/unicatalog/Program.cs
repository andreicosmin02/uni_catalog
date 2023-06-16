using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Diagnostics;
namespace unicatalog
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            
            //CreateTable(sqlite_conn);
            //InsertData(sqlite_conn);
           // ReadData(sqlite_conn);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new form_autentificare());


        }
        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=CATALOG1.db; Version = 3; New = True; Compress = True; ");
         // Open the connection:
         try
            {
                sqlite_conn.Open();
                Debug.WriteLine("CONN OPEN!");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return sqlite_conn;
        }

        static void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;
            string student = "CREATE TABLE STUDENT (ID INT,NUME VARCHAR(20), PRENUME VARCHAR(20), INITIALA VARCHAR(2), CNP INT, Col2 INT)";
            string program_studiu = "CREATE TABLE PROGRAM_STUDIU (Col1 VARCHAR(20), Col2 INT)";
            string catalog = "CREATE TABLE CATALOG (Col1 VARCHAR(20), Col2 VARCHAR(20), Col3 INT)";
            string cicluri_invatare = "CREATE TABLE CICLURI_INVATARE (Col1 VARCHAR(20), Col2 VARCHAR(20), Col3 INT)";
            string cont = "CREATE TABLE CONT (ID INT, NUME VARCHAR(20), PAROLA VARCHAR(20))";
            string discipline = "CREATE TABLE DISCIPLINE (Col1 VARCHAR(20), Col2 VARCHAR(20), Col3 INT)";
            string grupa = "CREATE TABLE GRUPA (Col1 VARCHAR(20), Col2 VARCHAR(20), Col3 INT)";
            string note = "CREATE TABLE NOTE (Col1 VARCHAR(20), Col2 VARCHAR(20), Col3 INT)";


            sqlite_cmd = conn.CreateCommand();

            sqlite_cmd.CommandText = student;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = program_studiu;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = catalog;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = cicluri_invatare;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = cont;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = discipline;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = grupa;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = note;
            sqlite_cmd.ExecuteNonQuery();
        }

        static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO STUDENT (ID, NUME) VALUES(1, 'MIHAI'); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO STUDENT (ID, NUME) VALUES(2, 'ELENA'); ";
            sqlite_cmd.ExecuteNonQuery();
            
            sqlite_cmd.CommandText = "INSERT INTO CONT (ID, NUME, PAROLA) VALUES(1, 'admin', 'admin'); ";
            sqlite_cmd.ExecuteNonQuery();


            // sqlite_cmd.CommandText = "INSERT INTO SampleTable1 (Col1, Col2) VALUES('Test3 Text3 ', 3); ";
            // sqlite_cmd.ExecuteNonQuery();

        }

        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM CONT";
            
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(1);
                Debug.WriteLine(myreader);
            }
            conn.Close();
        }
    }
}
