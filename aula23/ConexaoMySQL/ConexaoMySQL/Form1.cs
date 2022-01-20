using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexaoMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MySqlConnection Conn;

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            Conn = new MySqlConnection("server=localhost;user id=root;password=;database=sebrae;charset=utf8;pooling=false;SslMode = none");

            Conn.Open();

            MySqlCommand sqlQuery = new MySqlCommand("INSERT INTO aluno (nome, email, cpf)VALUES('" + txtNome.Text + "','" + txtEmail.Text + "','" + txtCPF.Text + "')", Conn);

            sqlQuery.ExecuteNonQuery();

            Conn.Close();

            Limpar();
        }

        public void Limpar()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCPF.Text = "";
        }
    }
}
