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

namespace ProjetoConversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //lendo o arquivo csv
            StreamReader moedas = new StreamReader(@"C:..\csv\20210811.csv");
            string linha;
            string[] cotacao;

            while ((linha = moedas.ReadLine()) != null)
            {
                //adicionando os dados do arquivo csv ao combobox
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

        private void btnConverter_Click_1(object sender, EventArgs e)
        {
            //instanciando a classe
            Conversoes cvs = new Conversoes();
            
            //verificando se o textbox está em branco
            if (txtReal.Text == null || txtReal.Text == "")
            {
                MessageBox.Show("Insira o valor a ser convertido!");
            }
            else
            {   //verificando se o valor digitado no textbox é numérico
                bool ehNumeroReal = double.TryParse(txtReal.Text, out cvs.valorReal);
                if (!ehNumeroReal)
                {   
                    MessageBox.Show("Digite apenas valores numéricos!");
                }
                else
                {   //lendo o arquivo csv
                    StreamReader moedas = new StreamReader(@"C:..\csv\20210811.csv");
                    string linha;
                    string[] cotacao;

                    while ((linha = moedas.ReadLine()) != null)
                    {
                        cotacao = linha.Split(';');
                        
                        if (cmbValor2.Text == cotacao[3])
                        {   
                            //pega a cotação da moeda selecionada e realiza os calculos
                            cvs.valorReal = Convert.ToDouble(txtReal.Text);
                            cvs.taxa = Convert.ToDouble(cotacao[4]);
                            txtValor2.Text = Convert.ToString(Math.Round(cvs.Conversao(),2));
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
    }
}
