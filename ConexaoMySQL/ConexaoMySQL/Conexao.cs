using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;



namespace ConexaoMySQL
{
    class Conexao
    {
        //Metodos

         //abrir a conexao
        public MySqlConnection abrirConexao()
        {
            MySqlConnection conn = new MySqlConnection(@"server=localhost;user id=root;password=;database=sebrae;charset=utf8;pooling=false;SslMode = none");
            
            conn.Open();

            return conn;
        }

         //fechar a conexao
        public MySqlConnection fecharConexao()
        {
            MySqlConnection conn = new MySqlConnection(@"server=localhost;user id=root;password=;database=sebrae;charset=utf8;pooling=false;SslMode = none");

            conn.Dispose();
            conn.Close();

            return conn;
        }

        //inserir dados no banco
        public string inserir(string nome, string email, string cpf, MySqlConnection conexao)
        {
            MySqlCommand sqlQuery = new MySqlCommand("INSERT INTO aluno (nome, email, cpf) VALUES ('" + nome + "', '" + email + "', '" + cpf + "')", conexao);

            int n = sqlQuery.ExecuteNonQuery();

            if (n == 1)
            {
                return "Usuário cadastrado com sucesso!";
            }
            else
            {
                return "Houve um erro ao cadastrar. Tente novamente mais tarde.";
            }
        }
    }
}
