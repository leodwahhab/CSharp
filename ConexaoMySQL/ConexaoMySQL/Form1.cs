using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConexaoMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        //instanciando a classe conexao
        Conexao Conn = new Conexao();

        private void Form1_Load(object sender, EventArgs e)
        { 
            //abrindo conexao
            Conn.abrirConexao();
            
        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(txtNome.Text); 
            string email = Convert.ToString(txtEmail.Text); 
            string cpf = Convert.ToString(txtCPF.Text);

            //insere os dados no banco, dá uma mensagem e depois fecha a conexao
            MessageBox.Show(Conn.inserir(nome, email, cpf, Conn.abrirConexao()));
            Conn.fecharConexao();
        }

    }
    }
