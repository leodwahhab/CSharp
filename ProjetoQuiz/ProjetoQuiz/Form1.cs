using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            if (txtNome.Text == "")
            {
                lblMensagem1.Text = "Insira um nome";
            }
            else
            {
                Form2 p1 = new Form2();
                p1.ShowDialog();
                

            }
        }
    }
}
