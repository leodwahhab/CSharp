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

namespace ProjetoConversoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StreamReader moedas = new StreamReader(@"C:\Leo\_etec\DS\ProjetoConversoes\csv\moedas.csv");
            string linha;
            string[] cotacao;

            while ((linha = moedas.ReadLine()) != null)
            {
                cotacao = linha.Split(';');
                cmbValor1.Items.Add(cotacao[3]);
                cmbValor2.Items.Add(cotacao[3]);
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            string guardar = txtValor1.Text;
            txtValor1.Text = txtValor2.Text;
            txtValor2.Text = guardar;
        }
    }
}
