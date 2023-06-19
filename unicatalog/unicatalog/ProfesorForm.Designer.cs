namespace unicatalog
{
    partial class ProfesorForm
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
            lista_materii = new ListBox();
            lista_studenti = new ListBox();
            save_nota = new Button();
            adaugare_nota = new TextBox();
            Nota = new Label();
            SuspendLayout();
            // 
            // lista_materii
            // 
            lista_materii.FormattingEnabled = true;
            lista_materii.ItemHeight = 20;
            lista_materii.Location = new Point(35, 46);
            lista_materii.Name = "lista_materii";
            lista_materii.Size = new Size(150, 104);
            lista_materii.TabIndex = 0;
            // 
            // lista_studenti
            // 
            lista_studenti.FormattingEnabled = true;
            lista_studenti.ItemHeight = 20;
            lista_studenti.Location = new Point(220, 46);
            lista_studenti.Name = "lista_studenti";
            lista_studenti.Size = new Size(150, 104);
            lista_studenti.TabIndex = 1;
            lista_studenti.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // save_nota
            // 
            save_nota.Location = new Point(238, 232);
            save_nota.Name = "save_nota";
            save_nota.Size = new Size(94, 29);
            save_nota.TabIndex = 2;
            save_nota.Text = "Save";
            save_nota.UseVisualStyleBackColor = true;
            // 
            // adaugare_nota
            // 
            adaugare_nota.Location = new Point(444, 89);
            adaugare_nota.Name = "adaugare_nota";
            adaugare_nota.Size = new Size(125, 27);
            adaugare_nota.TabIndex = 3;
            // 
            // Nota
            // 
            Nota.AutoSize = true;
            Nota.Location = new Point(393, 89);
            Nota.Name = "Nota";
            Nota.Size = new Size(45, 20);
            Nota.TabIndex = 4;
            Nota.Text = "Nota:";
            // 
            // ProfesorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 301);
            Controls.Add(Nota);
            Controls.Add(adaugare_nota);
            Controls.Add(save_nota);
            Controls.Add(lista_studenti);
            Controls.Add(lista_materii);
            Name = "ProfesorForm";
            Text = "ProfesorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lista_materii;
        private ListBox lista_studenti;
        private Button save_nota;
        private TextBox adaugare_nota;
        private Label Nota;
    }
}