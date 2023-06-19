using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static unicatalog.Service.Service;
namespace unicatalog
{

    public partial class Form_studenti : Form
    {

        public Form_studenti()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();


        }

        private void lbl_medie_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var service = new Service.Service();
            string nr_matricol = tb_nr_matricol.Text;
            string nume = tb_nume.Text;
            string initiala = tb_initiala.Text;
            string prenume = tb_prenume.Text;
            string cnp = tb_cnp.Text;
            string ciclu = tb_ciclu.Text;
            string medie = tb_medie.Text;
            string grupaString = grupa.Text;
            service.addStudent(nume, prenume, initiala, cnp.ToInt(), ciclu, medie.ToInt(), grupaString);
            string password = "1234";
            service.addCont(nume, password, 1);

            Debug.WriteLine("...Student salvat...");



        }

        private void lbl_inscriere_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void adaugaStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_cadru_didactic.Visible = false;
            panel_student.Visible = true;
        }

        private void adaugaCadruDidacticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_cadru_didactic.Visible = true;
            panel_student.Visible = false;
        }
    }
}
