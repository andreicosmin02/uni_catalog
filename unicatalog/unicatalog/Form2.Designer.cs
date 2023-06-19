namespace unicatalog
{
    partial class Form_studenti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_nr_matricol = new Label();
            lbl_nume = new Label();
            lbl_initiala = new Label();
            dataGrid_studenti = new DataGridView();
            lbl_prenume = new Label();
            lbl_cnp = new Label();
            lbl_inscriere = new Label();
            lbl_ciclu = new Label();
            lbl_medie = new Label();
            tb_nr_matricol = new TextBox();
            tb_nume = new TextBox();
            tb_initiala = new TextBox();
            tb_prenume = new TextBox();
            tb_cnp = new TextBox();
            dateTime_inscriere = new DateTimePicker();
            tb_ciclu = new TextBox();
            tb_medie = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid_studenti).BeginInit();
            SuspendLayout();
            // 
            // lbl_nr_matricol
            // 
            lbl_nr_matricol.AutoSize = true;
            lbl_nr_matricol.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nr_matricol.Location = new Point(582, 30);
            lbl_nr_matricol.Name = "lbl_nr_matricol";
            lbl_nr_matricol.Size = new Size(137, 23);
            lbl_nr_matricol.TabIndex = 0;
            lbl_nr_matricol.Text = "Numar matricol";
            // 
            // lbl_nume
            // 
            lbl_nume.AutoSize = true;
            lbl_nume.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nume.Location = new Point(614, 87);
            lbl_nume.Name = "lbl_nume";
            lbl_nume.Size = new Size(58, 23);
            lbl_nume.TabIndex = 1;
            lbl_nume.Text = "Nume";
            // 
            // lbl_initiala
            // 
            lbl_initiala.AutoSize = true;
            lbl_initiala.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_initiala.Location = new Point(588, 144);
            lbl_initiala.Name = "lbl_initiala";
            lbl_initiala.Size = new Size(122, 23);
            lbl_initiala.TabIndex = 2;
            lbl_initiala.Text = "Initiala tatalui";
            // 
            // dataGrid_studenti
            // 
            dataGrid_studenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_studenti.Location = new Point(12, 30);
            dataGrid_studenti.Name = "dataGrid_studenti";
            dataGrid_studenti.RowHeadersWidth = 51;
            dataGrid_studenti.RowTemplate.Height = 29;
            dataGrid_studenti.Size = new Size(530, 466);
            dataGrid_studenti.TabIndex = 3;
            // 
            // lbl_prenume
            // 
            lbl_prenume.AutoSize = true;
            lbl_prenume.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_prenume.Location = new Point(605, 201);
            lbl_prenume.Name = "lbl_prenume";
            lbl_prenume.Size = new Size(81, 23);
            lbl_prenume.TabIndex = 4;
            lbl_prenume.Text = "Prenume";
            // 
            // lbl_cnp
            // 
            lbl_cnp.AutoSize = true;
            lbl_cnp.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cnp.Location = new Point(620, 258);
            lbl_cnp.Name = "lbl_cnp";
            lbl_cnp.Size = new Size(44, 23);
            lbl_cnp.TabIndex = 5;
            lbl_cnp.Text = "CNP";
            // 
            // lbl_inscriere
            // 
            lbl_inscriere.AutoSize = true;
            lbl_inscriere.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_inscriere.Location = new Point(588, 315);
            lbl_inscriere.Name = "lbl_inscriere";
            lbl_inscriere.Size = new Size(121, 23);
            lbl_inscriere.TabIndex = 6;
            lbl_inscriere.Text = "Data inscrierii";
            // 
            // lbl_ciclu
            // 
            lbl_ciclu.AutoSize = true;
            lbl_ciclu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ciclu.Location = new Point(566, 372);
            lbl_ciclu.Name = "lbl_ciclu";
            lbl_ciclu.Size = new Size(170, 23);
            lbl_ciclu.TabIndex = 7;
            lbl_ciclu.Text = "Ciclu de invatamant";
            // 
            // lbl_medie
            // 
            lbl_medie.AutoSize = true;
            lbl_medie.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_medie.Location = new Point(585, 429);
            lbl_medie.Name = "lbl_medie";
            lbl_medie.Size = new Size(132, 23);
            lbl_medie.TabIndex = 8;
            lbl_medie.Text = "Medie inscriere";
            lbl_medie.Click += lbl_medie_Click;
            // 
            // tb_nr_matricol
            // 
            tb_nr_matricol.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tb_nr_matricol.Location = new Point(776, 23);
            tb_nr_matricol.Name = "tb_nr_matricol";
            tb_nr_matricol.Size = new Size(125, 30);
            tb_nr_matricol.TabIndex = 9;
            tb_nr_matricol.TextAlign = HorizontalAlignment.Center;
            tb_nr_matricol.TextChanged += textBox1_TextChanged;
            // 
            // tb_nume
            // 
            tb_nume.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tb_nume.Location = new Point(776, 83);
            tb_nume.Name = "tb_nume";
            tb_nume.Size = new Size(125, 30);
            tb_nume.TabIndex = 10;
            tb_nume.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_initiala
            // 
            tb_initiala.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tb_initiala.Location = new Point(776, 140);
            tb_initiala.Name = "tb_initiala";
            tb_initiala.Size = new Size(125, 30);
            tb_initiala.TabIndex = 11;
            tb_initiala.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_prenume
            // 
            tb_prenume.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tb_prenume.Location = new Point(776, 197);
            tb_prenume.Name = "tb_prenume";
            tb_prenume.Size = new Size(125, 30);
            tb_prenume.TabIndex = 12;
            tb_prenume.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_cnp
            // 
            tb_cnp.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tb_cnp.Location = new Point(776, 254);
            tb_cnp.Name = "tb_cnp";
            tb_cnp.Size = new Size(125, 30);
            tb_cnp.TabIndex = 13;
            tb_cnp.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTime_inscriere
            // 
            dateTime_inscriere.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dateTime_inscriere.Location = new Point(713, 311);
            dateTime_inscriere.Name = "dateTime_inscriere";
            dateTime_inscriere.Size = new Size(306, 30);
            dateTime_inscriere.TabIndex = 14;
            // 
            // tb_ciclu
            // 
            tb_ciclu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tb_ciclu.Location = new Point(776, 365);
            tb_ciclu.Name = "tb_ciclu";
            tb_ciclu.Size = new Size(125, 30);
            tb_ciclu.TabIndex = 15;
            tb_ciclu.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_medie
            // 
            tb_medie.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tb_medie.Location = new Point(776, 425);
            tb_medie.Name = "tb_medie";
            tb_medie.Size = new Size(125, 30);
            tb_medie.TabIndex = 16;
            tb_medie.TextAlign = HorizontalAlignment.Center;
            // 
            // Form_studenti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 563);
            Controls.Add(tb_medie);
            Controls.Add(tb_ciclu);
            Controls.Add(dateTime_inscriere);
            Controls.Add(tb_cnp);
            Controls.Add(tb_prenume);
            Controls.Add(tb_initiala);
            Controls.Add(tb_nume);
            Controls.Add(tb_nr_matricol);
            Controls.Add(lbl_medie);
            Controls.Add(lbl_ciclu);
            Controls.Add(lbl_inscriere);
            Controls.Add(lbl_cnp);
            Controls.Add(lbl_prenume);
            Controls.Add(dataGrid_studenti);
            Controls.Add(lbl_initiala);
            Controls.Add(lbl_nume);
            Controls.Add(lbl_nr_matricol);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_studenti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Studenti";
            FormClosed += Form2_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGrid_studenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nr_matricol;
        private Label lbl_nume;
        private Label lbl_initiala;
        private DataGridView dataGrid_studenti;
        private Label lbl_prenume;
        private Label lbl_cnp;
        private Label lbl_inscriere;
        private Label lbl_ciclu;
        private Label lbl_medie;
        private TextBox tb_nr_matricol;
        private TextBox tb_nume;
        private TextBox tb_initiala;
        private TextBox tb_prenume;
        private TextBox tb_cnp;
        private DateTimePicker dateTime_inscriere;
        private TextBox tb_ciclu;
        private TextBox tb_medie;
    }
}