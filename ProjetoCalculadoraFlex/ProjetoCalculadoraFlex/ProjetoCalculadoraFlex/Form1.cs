using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadoraFlex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pctBomba_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if(txtEtanol.Text != "" || txtGasolina.Text != "")
            {
                double etanol = Convert.ToDouble(txtEtanol.Text);
                double gasolina = Convert.ToDouble(txtGasolina.Text);
                double valor = (etanol / gasolina);
                string combustivel;

                if(valor > 0.7)
                {
                    combustivel = "GASOLINA";
                }
                else
                {
                    combustivel = "ETANOL";
                }

                Form2 frm2 = new Form2(combustivel);
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEtanol.Text = "";
            txtGasolina.Text = "";
        }

        private void txtEtanol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar!= 08 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtGasolina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
    }
}
