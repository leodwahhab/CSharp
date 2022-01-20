using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDolarReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbConversoes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbConversoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbConversoes.Text == "Dólar para Real")
            {
                lblValor1.Text = "Valor em Dólar:";
                lblValor2.Text = "Valor em Reais:";
            }
            else
            {
                lblValor1.Text = "Valor em Reais:";
                lblValor2.Text = "Valor em Dólar:";
            }
            txtValor1.Text = "";
            txtValorConvertido.Text = "";
            lblMensagem.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Conversao conv = new Conversao();

            if(cmbConversoes.Text != null && cmbConversoes.Text != "")
            {
                if (txtValor1.Text != null && txtValor1.Text != "")
                {
                    bool nmr = double.TryParse(txtValor1.Text, out conv.valor);

                    if (nmr)
                    {
                        if (cmbConversoes.Text == "Dólar para Real")
                        {
                            conv.valor = Convert.ToDouble(txtValor1.Text);
                            txtValorConvertido.Text = Convert.ToString(conv.DolarReal());
                            lblMensagem.Text = "";
                        }
                        else
                        {
                            conv.valor = Convert.ToDouble(txtValor1.Text);
                            txtValorConvertido.Text = Convert.ToString(conv.RealDolar());
                            lblMensagem.Text = "";
                        }
                    }
                    else
                    {
                        lblMensagem.Text = "Digite somente valores numéricos";
                    }
                }
                else
                {
                    lblMensagem.Text = "Preencha os campos";
                }
            }
            else
            {
                lblMensagem.Text = "Selecione uma opção";
            }
            
        }
    }
}
