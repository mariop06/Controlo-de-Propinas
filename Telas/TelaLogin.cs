
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

        //Instanciando a string de conexão da classe DataBase... {Amarildo]
        DataBase sql = new DataBase();
        bool t = true;
        private TelaPrincipal telaPrincipal;

        public TelaLogin(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            

            connection = new MySqlConnection(sql.ConetarUsuario());
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

                this.Invoke((MethodInvoker)delegate
                {
                    
                    circleProgress.Visible = false;

                    buttonEntrar.Enabled = true;

                    
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
                connection.Open();

                // Query para verificar se o usuário e senha existem no banco de dados {Mario}
                string query = "SELECT COUNT(*)  FROM autorizado WHERE username = @usuario AND senha = @senha";

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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaLogin_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            pictureBox1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            if (t)
            {
                pictureBox1.BackgroundImage = Properties.Resources.eye;
                txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;
                t = false;
            }
            else
            {
                pictureBox1.BackgroundImage = Properties.Resources.eyebrow;
                txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;
                t = true;
            }
        }
    }
}