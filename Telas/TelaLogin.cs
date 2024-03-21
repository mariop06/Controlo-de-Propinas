
using System;
using System.Data;
using System.Windows.Forms;
using ControloDePropinas.Telas;
using System.Threading;
using MySql.Data.MySqlClient;

namespace ControloDePropinas
{
    public partial class TelaLogin : Form
    {
        MySqlConnection connection;
        string sql = "Server=localhost;Port=3306;Database=enti_uso;Uid=root;Pwd=mariopaulos06;Sslmode=none;";

        private TelaPrincipal telaPrincipal;

        public TelaLogin(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            connection = new MySqlConnection(sql);
            this.telaPrincipal = telaPrincipal;

        }

        private void button_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;
            string nome;

            // Verificar se os campos estão vazios
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Mostrar a ProgressBar
            circleProgress.Visible = true;

            // Desativar o botão enquanto o processo está ocorrendo
            buttonEntrar.Enabled = false;

            // Iniciar o processo de login em uma thread separada
            ThreadPool.QueueUserWorkItem((o) =>
            {
                // Realizar a validação do login
                bool loginValido = ValidarLogin(usuario, senha);

                // Atualizar a UI na thread principal
                this.Invoke((MethodInvoker)delegate
                {
                    // Esconder a ProgressBar
                    circleProgress.Visible = false;

                    // Ativar o botão novamente
                    buttonEntrar.Enabled = true;

                    // Verificar se o login é válido
                    if (loginValido)
                    {

                        connection.Open();

                        String q = "select nome from autorizado where username = '" + usuario + "'";
                        MySqlCommand comando = new MySqlCommand(q, connection);
                        MySqlDataReader leitura;

                        leitura = comando.ExecuteReader();
                        if (leitura.Read())
                        {
                            nome = leitura.GetString("nome");
                            MessageBox.Show("Login bem-sucedido!");

                            //Faça aqui o redirecionamento para a próxima tela, se necessário
                            TelaPrincipal telaPrincipal = new TelaPrincipal();
                            telaPrincipal.Acesso(nome, usuario);
                            this.Hide();
                            telaPrincipal.Show();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Credenciais inválidas. Tente novamente.");
                    }
                });
            });
        }

        private bool ValidarLogin(string usuario, string senha)
        {
            try
            {
                // Abre a conexão com o banco de dados
                connection.Open();

                // Query para verificar se o usuário e senha existem no banco de dados
                string query = "SELECT COUNT(*)  FROM autorizado WHERE username = @usuario AND senha = @senha";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);

                //MySqlDataReader reader = cmd.ExecuteReader();
                //if (reader.Read())
                //{
                //    string nome = reader["nome"].ToString();

                //    TelaPrincipal telaPrincipal = new TelaPrincipal();
                //    telaPrincipal.Acesso(nome, usuario);
                //}


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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //public partial class TelaPrincipal : Form
        //{


        //    public TelaPrincipal(string username)
        //    {
        //        InitializeComponent();
        //        //labelNome.Text = nome;
        //        labelUsername.Text = username;


        //    }



        //MySqlCommand command = new MySqlCommand();
        //MySqlDataReader reader = command.ExecuteReader();

        //string nome = reader["nome"].ToString();
        //string usernameFromDB = reader["username"].ToString();
        //}

    }
}