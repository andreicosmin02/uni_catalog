using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using System.Diagnostics;

namespace unicatalog
{
    public partial class form_autentificare : Form
    {
        SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=CATALOG1.db; Version = 3; New = True; Compress = True; ");

        public form_autentificare()
        {
            InitializeComponent();
        }


        private void btn_signin_Click(object sender, EventArgs e)
        {
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
            SQLiteDataReader sqlite_datareader;
            sqlite_conn.Open();

            sqlite_cmd.CommandText = $"SELECT * FROM CONT WHERE NUME='{textBox1.Text}' AND PAROLA='{textBox2.Text}'";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(1) + " " + sqlite_datareader.GetString(2);
                Debug.WriteLine(myreader);
            }
            sqlite_conn.Close();
            // Se deschide forms-ul cu content
            var form2 = new Form2();
            form2.Show();
            this.Visible = false;
        }

        /// <summary>
        /// Cand este apasat enter 
        /// butonul de sign in este apasat automat
        /// </summary>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_signin_Click(sender, e);
            }
        }

        private void form_autentificare_Load(object sender, EventArgs e)
        {

        }
    }
}