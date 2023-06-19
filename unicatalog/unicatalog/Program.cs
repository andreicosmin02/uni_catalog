using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Diagnostics;
using static unicatalog.Service.Service;
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
            ReadData(sqlite_conn);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new form_autentificare());


        }
        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=CATALOG.db; Version = 3; New = True; Compress = True; ");
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
            string student = "CREATE TABLE STUDENT (ID INT,NUME VARCHAR(20), PRENUME VARCHAR(20), INITIALA VARCHAR(2), CNP INT, CICLU VARCHAR(20),MEDIA INT,GRUPA VARCHAR(20))";
            string program_studiu = "CREATE TABLE PROGRAM_STUDIU (ID INT, CICLU VARCHAR(20),DURATA INT, COD INT)";
            string catalog = "CREATE TABLE CATALOG (MATRICOL INT, NUME VARCHAR(20), PRENUME VARCHAR(20),MED1 INT,MED2 INT, MED INT, PROMOVAT INT) ";
            string cont = "CREATE TABLE CONT (ID INT, NUME VARCHAR(20), PAROLA VARCHAR(20), TIP INT)";
            string discipline = "CREATE TABLE DISCIPLINE (ID INT, NUME VARCHAR(20), ACRONIM VARCHAR(20), CREDITE INT, PROFESOR VARCHAR(20));";
            string grupa = "CREATE TABLE GRUPA (ID INT, COD VARCHAR(20))";
            string note = "CREATE TABLE NOTE (MATRICOL INT, MATERIE VARCHAR(20), NOTA INT)";
            string profesor = "CREATE TABLE PROFESOR (ID INT, NUME VARCHAR(20))";

            sqlite_cmd = conn.CreateCommand();

            sqlite_cmd.CommandText = "DROP TABLE STUDENT";
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "DROP TABLE PROGRAM_STUDIU";
            sqlite_cmd.ExecuteNonQuery();

             sqlite_cmd.CommandText = "DROP TABLE CONT";
             sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "DROP TABLE DISCIPLINE";
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "DROP TABLE GRUPA";
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "DROP TABLE CATALOG";
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = "DROP TABLE NOTE";
            sqlite_cmd.ExecuteNonQuery();
            
            sqlite_cmd.CommandText = "DROP TABLE PROFESOR";
            //sqlite_cmd.ExecuteNonQuery();


            sqlite_cmd.CommandText = student;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = program_studiu;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = catalog;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = cont;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = discipline;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = grupa;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = note;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = profesor;
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

            var service = new Service.Service();

            service.addProfesor("coman");
            service.deleteProfesor("coman");

            conn.Close();
        }
    }
}
