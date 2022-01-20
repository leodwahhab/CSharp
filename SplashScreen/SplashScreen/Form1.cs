using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirForm02_Click(object sender, EventArgs e)
        {
            frmCadastro frmcad = new frmCadastro(txtForm1.Text);

            frmcad.Show();
            this.Hide();
        }
    }
}
