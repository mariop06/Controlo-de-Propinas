﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControloDePropinas.Telas;
using MySql.Data.MySqlClient;

namespace ControloDePropinas
{
    public partial class TelaLogin : Form
    {
        MySqlConnection connection;
        string sql = "Server=localhost;Port=3306;Database=enti_uso;Uid=root;Pwd=mariopaulos06; Sslmode=none;";
        public TelaLogin()
        {
            InitializeComponent();
            connection = new MySqlConnection(sql);
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
          
        }

        private void button_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            // Verificar se os campos estão vazios
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Realizar a validação do login
            if (ValidarLogin(usuario, senha))
            {
                MessageBox.Show("Login bem-sucedido!");
                // Faça aqui o redirecionamento para a próxima tela, se necessário
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                telaPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas. Tente novamente.");
            }


        }

        private bool ValidarLogin(string usuario, string senha)
        {
            try
            {
                // Abre a conexão com o banco de dados
                connection.Open();

                // Query para verificar se o usuário e senha existem no banco de dados
                string query = "SELECT COUNT(*) FROM autorizado WHERE username = @usuario AND senha = @senha";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);

                // Executar a consulta
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                // Se count for maior que 0, o login é válido
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar login: " + ex.Message);
                return false;
            }
            finally
            {
                // Fechar a conexão com o banco de dados
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }


    }
}
