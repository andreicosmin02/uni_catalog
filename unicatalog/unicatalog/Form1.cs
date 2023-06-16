namespace unicatalog
{
    public partial class form_autentificare : Form
    {
        public form_autentificare()
        {
            InitializeComponent();
        }


        private void btn_signin_Click(object sender, EventArgs e)
        {
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
    }
}