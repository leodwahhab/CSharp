using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoOpcao1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRealDolar.Checked)
            {
                rdoDolarReal.Checked = false;
                lbl1.Text = "Real (R$):";
                lbl2.Text = "Dólar (US$):";
                txtValor.Text = "";
                txtRes.Text = "";
            }
        }

        private void rdoOpcao2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDolarReal.Checked)
            {
                rdoRealDolar.Checked = false;
                lbl2.Text = "Reais (R$):";
                lbl1.Text = "Dólar (US$):";
                txtValor.Text = "";
                txtRes.Text = "";
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            Conversao conv = new Conversao();

            if (txtValor.Text == "")
            {
                MessageBox.Show("O campo está vazio!");
            }
            else
            {
                bool ehNum = double.TryParse(txtValor.Text, out conv.valor);
                if (!ehNum)
                {
                    MessageBox.Show("Digite valores numéricos!");
                }
                else
                {
                    conv.valor = Convert.ToDouble(txtValor.Text);

                    if (rdoRealDolar.Checked)
                    {
                        txtRes.Text = Convert.ToString(conv.DolarReal());
                    }
                    else
                    {
                        txtRes.Text = Convert.ToString(conv.RealDolar());
                    }
                }
            }
            
        }
    }
}
