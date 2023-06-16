

namespace unicatalog
{
    partial class form_autentificare
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            username = new TextBox();
            password = new TextBox();
            btn_signin = new Button();
            label_invalid = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(71, 39);
            label1.Name = "label1";
            label1.Size = new Size(282, 32);
            label1.TabIndex = 0;
            label1.Text = "Sign in to your account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(63, 92);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 169);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // textBox1
            // 
            username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(63, 110);
            username.Name = "textBox1";
            username.Size = new Size(298, 29);
            username.TabIndex = 3;
            username.KeyDown += Form1_KeyDown;
            // 
            // textBox2
            // 
            password.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            password.Location = new Point(63, 187);
            password.Name = "textBox2";
            password.PasswordChar = '*';
            password.Size = new Size(298, 29);
            password.TabIndex = 4;
            password.KeyDown += Form1_KeyDown;
            // 
            // btn_signin
            // 
            btn_signin.BackColor = SystemColors.MenuHighlight;
            btn_signin.FlatAppearance.BorderSize = 0;
            btn_signin.FlatStyle = FlatStyle.Popup;
            btn_signin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_signin.ForeColor = SystemColors.ControlLightLight;
            btn_signin.Location = new Point(63, 270);
            btn_signin.Name = "btn_signin";
            btn_signin.Size = new Size(298, 32);
            btn_signin.TabIndex = 5;
            btn_signin.Text = "Sign in";
            btn_signin.UseVisualStyleBackColor = false;
            btn_signin.Click += btn_signin_Click;
            // 
            // label_invalid
            // 
            label_invalid.AutoSize = true;
            label_invalid.ForeColor = Color.Red;
            label_invalid.Location = new Point(126, 237);
            label_invalid.Name = "label_invalid";
            label_invalid.Size = new Size(169, 15);
            label_invalid.TabIndex = 6;
            label_invalid.Text = "*Invalid username or password";
            label_invalid.Visible = false;
            // 
            // form_autentificare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 354);
            Controls.Add(label_invalid);
            Controls.Add(btn_signin);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "form_autentificare";
            Opacity = 0.98D;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autentificare";
            Load += form_autentificare_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username;
        private TextBox password;
        private Button btn_signin;
        private Label label_invalid;
    }
}