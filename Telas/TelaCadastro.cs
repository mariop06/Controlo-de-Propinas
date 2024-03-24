using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ControloDePropinas.Telas
{
    public partial class TelaCadastro : Form
    {
        MySqlConnection conectar;

        // Classe com o médoto que possui as credencias de conexão
        DataBase br = new DataBase();
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {
            combox();
        }


        // Métodos para extrair as turma da BD para a comboBox
        public void combox()
        {
            MySqlConnection conexao = br.conexao(conectar);

            try
            {
                string sql = "select distinct(nome_tur) from turma";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                DataSet ds = new DataSet();
                MySqlDataAdapter adpt = new MySqlDataAdapter(comando);
                adpt.Fill(ds);
                comboTurmas.DataSource = ds.Tables[0];
                comboTurmas.DisplayMember = "nome_tur";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open) { }
                conexao.Close();
                conexao.Dispose();

            }
        }

        void insereNaTabela_est_mes()
        {
            MySqlConnection conexao = br.conexao(conectar);
            try
            {
                // string sql = "insert into est_mes(est_mes.id, est_mes.proc_a, est_mes.Setembro) value (default,'"+TxtProc.Text+"','Pago');";
                 string sql = "insert into est_mes(est_mes.id, est_mes.proc_a, est_mes.Setembro, est_mes.Outubro, est_mes.Novembro, est_mes.Dezembro," +
                    " est_mes.Janeiro, est_mes.Fevereiro, est_mes.Marco, est_mes.Abril,est_mes.Maio, est_mes.Junho) value (default,'"+TxtProc.Text+ "'," +
                    "'Pago','NÃO Pago','NÃO Pago','NÃO Pago','NÃO Pago','NÃO Pago','NÃO Pago','NÃO Pago','NÃO Pago','NÃO Pago');";


                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();

                //comando.Parameters.AddWithValue("@num", (TxtProc.Text));
                comando.ExecuteReader();

                MessageBox.Show("OPERAÇÃO BEM SUCEDIDA!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtProc.Text) ||
                string.IsNullOrWhiteSpace(TxtNum.Text) ||
                string.IsNullOrWhiteSpace(TxtNome.Text) ||
                string.IsNullOrWhiteSpace(comboSexo.Text) ||
                string.IsNullOrWhiteSpace(comboTurmas.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de continuar.");
                TxtProc.Text = "";
                TxtNum.Text = "";
                TxtNome.Text = "";
                comboSexo.Text = "";
                comboTurmas.Text = "";
                return;
            }

            MySqlConnection conexao = br.conexao(conectar);

            try
            {
                string sql = "insert into lista values (default, @TxtProc, @TxtNum, @TxtNome, @comboSexo, @comboTurmas);";
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                bool validarNum = ValidarNum(TxtNum.Text, (comboTurmas.SelectedIndex + 1).ToString());
                conexao.Open();

                if (validarNum == true)
                {
                    MessageBox.Show("Nº na turma já existente");
                }
                else
                {
                    comando.Parameters.AddWithValue("@TxtProc", TxtProc.Text);
                    comando.Parameters.AddWithValue("@TxtNum", TxtNum.Text);
                    comando.Parameters.AddWithValue("@TxtNome", TxtNome.Text);
                    comando.Parameters.AddWithValue("@comboSexo", comboSexo.Text);
                    comando.Parameters.AddWithValue("@comboTurmas", comboTurmas.SelectedIndex + 1);
                    comando.ExecuteReader();

                    MessageBox.Show("OPERAÇÃO BEM SUCEDIDA!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                    conexao.Dispose();
                }

                
            insereNaTabela_est_mes();

                TxtProc.Text = "";
                TxtNum.Text = "";
                TxtNome.Text = "";
                comboSexo.Text = "";
                comboTurmas.Text = "";

            }

        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TxtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidarNum(string Numero, string Turma)
        {
            MySqlConnection conexao = br.conexao(conectar);
            try
            {
                // Abre a conexão com o banco de dados
                conexao.Open();

                // Query para verificar se o usuário e senha existem no banco de dados
                string query = "SELECT num FROM lista WHERE num = @Numero AND Turma = @Turma;";

                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@Numero", Numero);
                cmd.Parameters.AddWithValue("@Turma", Turma);



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
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        private void TelaCadastro_DoubleClick(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }
    }


}

