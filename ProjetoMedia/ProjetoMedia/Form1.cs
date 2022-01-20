using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMedia.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Media media = new Media(); //instanciando a classe

            //verificando o valor digitado pelo usuario é numérico
            bool ehNumeroA1 = double.TryParse(txtAtividade1.Text, out media.atividade1);
            bool ehNumeroA2 = double.TryParse(txtAtividade2.Text, out media.atividade2);
            bool ehNumeroA3 = double.TryParse(txtAtividade3.Text, out media.atividade3);
            bool ehNumeroA4 = double.TryParse(txtAtividade4.Text, out media.atividade4);
            bool ehNumeroP1 = double.TryParse(txtProva1.Text, out media.prova1);
            bool ehNumeroP2 = double.TryParse(txtProva2.Text, out media.prova2);

            //verificando se o valor digitado pelo usuário está entre 0 e 10
            bool consisA1 = media.atividade1 >= 0 && media.atividade1 <= 10;
            bool consisA2 = media.atividade2 >= 0 && media.atividade2 <= 10;
            bool consisA3 = media.atividade3 >= 0 && media.atividade3 <= 10;
            bool consisA4 = media.atividade4 >= 0 && media.atividade4 <= 10;
            bool consisP1 = media.prova1 >= 0 && media.prova1  <= 10;
            bool consisP2 = media.prova2 >= 0 && media.prova2 <= 10;

            //se os campos não estiverem vazios
            if (txtAtividade1.Text != "" && txtAtividade2.Text != "" && txtAtividade3.Text != "" && txtAtividade4.Text != "" && txtProva1.Text != "" && txtProva2.Text != "")
            {
                //se os valores forem numéricos
                if (ehNumeroA1 && ehNumeroA2 && ehNumeroA3 && ehNumeroA4 && ehNumeroP1 && ehNumeroP2)
                {
                    //se os valores estiverem entre 0 e 10
                    if(consisA1 && consisA2 && consisA3 && consisA4 && consisP1 && consisP2)
                    {
                        //realizar os calculos
                        media.atividade1 = Convert.ToDouble(txtAtividade1.Text);
                        media.atividade2 = Convert.ToDouble(txtAtividade2.Text);
                        media.atividade3 = Convert.ToDouble(txtAtividade3.Text);
                        media.atividade4 = Convert.ToDouble(txtAtividade4.Text);
                        media.atividade1 = Convert.ToDouble(txtAtividade1.Text);
                        media.prova1 = Convert.ToDouble(txtProva1.Text);
                        media.prova2 = Convert.ToDouble(txtProva2.Text);
                        txtMedia.Text = Convert.ToString(media.calcularMedia());
                    }
                    else //se os valores não estiverem entre 0 e 10
                    {
                        MessageBox.Show("Os valores devem estar entre 0 e 10!");
                    }
                }
                else //se os valores não forem numéricos
                {
                    MessageBox.Show("Digite apenas valores numéricos!");
                }
            }
            else //se os campos estiverem vazios
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAtividade1.Text = "";
            txtAtividade2.Text = "";
            txtAtividade3.Text = "";
            txtAtividade4.Text = "";
            txtProva1.Text = "";
            txtProva2.Text = "";
            txtMedia.Text = "";

        }
    }
}
