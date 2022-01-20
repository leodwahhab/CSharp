using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class frmCadastro : Form
    {
        public frmCadastro(string valor)
        {
            InitializeComponent();

            lblConteudo.Text = valor;

        }

        private void btnAbrirForm01_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();
            this.Hide();
        }
    }
}
