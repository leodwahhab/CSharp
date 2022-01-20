using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjConversoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StreamReader moedas = new StreamReader(@"C:..\..\csv\20210811.csv");
            string linha;
            string[] cotacao;

            while ((linha = moedas.ReadLine()) != null)
            {
                cotacao = linha.Split(';');
                cmbValor1.Items.Add(cotacao[3]);
                cmbValor2.Items.Add(cotacao[3]);
                cmbValor2.Text = cotacao[3];
            }

            cmbValor1.Text = ("Real (BRL)");
            cmbValor1.Enabled = false;
            txtValor2.Enabled = false;
            cmbValor2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            Conversoes cvs = new Conversoes();
            
            if(txtValor1.Text == null || txtValor1.Text == "")
            {
                MessageBox.Show("Insira o valor a ser convertido!");
            }
            else
            {
                bool ehNumeroReal = double.TryParse(txtValor1.Text, out cvs.valorReal);
                if (!ehNumeroReal)
                {
                    MessageBox.Show("Digite apenas valores numéricos!");
                }
                else
                {
                    StreamReader moedas = new StreamReader(@"C:..\..\csv\20210811.csv");
                    string linha;
                    string[] cotacao;

                    while ((linha = moedas.ReadLine()) != null)
                    {
                        cotacao = linha.Split(';');

                        if (cmbValor2.Text == cotacao[3])
                        {
                            cvs.valorReal = Convert.ToDouble(txtValor1.Text);
                            cvs.taxa = Convert.ToDouble(cotacao[4]);
                            txtValor2.Text = Convert.ToString(cvs.ConversaoA());
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            string guardar = cmbValor2.Text;
            cmbValor1.Text = guardar;
            cmbValor2.Text = "Real (BRL)";
            if (cmbValor2.Enabled)
            {
                cmbValor1.Enabled = true;
                cmbValor2.Enabled = false;
            }
            else
            {
                cmbValor2.Enabled = true;
                cmbValor1.Enabled = false;
            }
        }
    }
}
