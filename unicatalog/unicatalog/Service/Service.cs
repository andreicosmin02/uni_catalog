using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Diagnostics;
namespace unicatalog.Service
{
    public class Service
    {
        SQLiteConnection sqlite_conn;
        
        public void addStudent(string nume,string prenume,string initiala, int cnp, string ciclu, int media, string grupa)
        {
            sqlite_conn = new SQLiteConnection("Data Source=CATALOG.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();

<<<<<<< HEAD
            string query = $"INSERT INTO STUDENT (ID, NUME, PRENUME, INITIALA, CNP, CICLU, MEDIA, GRUPA) VALUES (1,'{nume}','{prenume}','{initiala}',{cnp},'{ciclu}',{media},'{grupa}');";
=======
            string query = $"INSERT INTO STUDENT (NUME, PRENUME, INITIALA, CNP, CICLU, MEDIA, GRUPA) VALUES ('{nume}','{prenume}','{initiala}',{cnp},'{ciclu}',{media},'{grupa}'); ";
>>>>>>> 7e3394fdc8fe9306ae5e3bf5069547e6b2b86e26
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = query;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_conn.Close();
            
        }

        public void addProgramStudiu(string ciclu,int durata, int cod)
        {
            sqlite_conn = new SQLiteConnection("Data Source=CATALOG.db; Version = 3; New = True; Compress = True;");
            sqlite_conn.Open();

            string query = $"INSERT INTO PROGRAM_STUDIU (CICLU, DURATA, COD) VALUES ('{ciclu}',{durata},{cod});";
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = query;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_conn.Close();
        }

        public void addCatalog(int matricol,string nume,string prenume, int med1,int med2, int med, int promovat)
        {
            sqlite_conn = new SQLiteConnection("Data Source=CATALOG.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();

            string query = $"INSERT INTO CATALOG (MATRICOL, NUME, PRENUME, MED1, MED2, MED, PROMOVATA) VALUES ({matricol},'{nume}','{prenume}', {med1},{med2},{med},{promovat});";
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = query;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_conn.Close();
        }

        public void addCont(string nume,string parola, int tip)
        {

            sqlite_conn = new SQLiteConnection("Data Source=CATALOG.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();

            string query = $"INSERT INTO CONT (NUME,PAROLA,TIP) VALUES ('{nume}', '{parola}', {tip});";
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = query;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_conn.Close();
        }

        public void addDiscipline(string nume,string acronim,int credite)
        {
            sqlite_conn = new SQLiteConnection("Data Source=CATALOG.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();

            string query = $"INSERT INTO DISCIPLINE (NUME,ACRONIM,CREDITE) VALUES('{nume}','{acronim}',{credite});";
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = query;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_conn.Close();
        }

        public void addGrupa(string cod)
        {
            sqlite_conn = new SQLiteConnection("Data Source=CATALOG.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();

            string query = $"INSERT INTO GRUPA (COD) VALUES ('{cod}');";
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = query;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_conn.Close();
        }

<<<<<<< HEAD
        public  void addNote(int matricol,string materie,int nota)
=======
        public void addNote(int matricol,string materie,int nota)
>>>>>>> 7e3394fdc8fe9306ae5e3bf5069547e6b2b86e26
        {
            sqlite_conn = new SQLiteConnection("Data Source=CATALOG.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();

            string query = $"INSERT INTO NOTE(MATRICOL,MATERIE,NOTA) VALUES({matricol},'{materie}',{nota});";
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = query;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_conn.Close();
        }

        public void addProfesor(string nume)
        {
            sqlite_conn = new SQLiteConnection("Data Source=CATALOG.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();

            string query = $"INSERT INTO PROFESOR(NUME) VALUES('{nume}');";
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = query;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_conn.Close();
        }

        public void deleteStudent(String name)
        {
            sqlite_conn = new SQLiteConnection("Data Source=CATALOG.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();

            string query = $"DELETE FROM STUDENT WHERE NAME= '{name}';";
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = query;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_conn.Close();
        }

        public void deleteProfesor(string name)
        {
            sqlite_conn = new SQLiteConnection("Data Source=CATALOG.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn.Open();

            string query = $"DELETE FROM PROFESOR WHERE NUME = '{name}';";
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = query;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_conn.Close();
        }
    }
}
