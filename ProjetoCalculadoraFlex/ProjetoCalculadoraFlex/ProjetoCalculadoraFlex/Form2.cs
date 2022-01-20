using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoCalculadoraFlex
{
    public partial class Form2 : Form
    {
        public Form2(string combustivel)
        {
            InitializeComponent();

            lblCombustivel.Text = combustivel;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }

        private void pctBomba1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}
