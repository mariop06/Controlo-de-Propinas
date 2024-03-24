using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControloDePropinas
{
    public partial class TelaDePagamentos : Form
    {

        private MySqlConnection conectar;

        // Classe com o médoto que possui as credencias de conexão
        DataBase br = new DataBase();


        public TelaDePagamentos()
        {
            InitializeComponent();
        }
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = br.conexao(conectar);
            try
            {
                string campo = comboBox1.Text;
                string valor = "Pago";
                string aluno = comboAlunos.Text;
                int turmaIndex = comboTurmas.SelectedIndex + 1;

                string verificacaoSql = "SELECT COUNT(*) FROM est_mes WHERE " + campo + " = @valor AND proc_a = (SELECT proc FROM lista WHERE Turma = @turma AND nome = @aluno)";

                MySqlCommand comandoVerificacao = new MySqlCommand(verificacaoSql, conexao);
                comandoVerificacao.Parameters.AddWithValue("@valor", valor);
                comandoVerificacao.Parameters.AddWithValue("@turma", turmaIndex);
                comandoVerificacao.Parameters.AddWithValue("@aluno", aluno);

                conexao.Open();
                int registrosExistentes = Convert.ToInt32(comandoVerificacao.ExecuteScalar());
                conexao.Close();

                if (registrosExistentes > 0)
                {
                    MessageBox.Show("Já existe um registro com o valor '" + valor + "' para o aluno selecionado nesta turma.");
                    return; 
                }

                string sql = "UPDATE est_mes SET " + campo + " = @valor WHERE proc_a = (SELECT proc FROM lista WHERE Turma = @turma AND nome = @aluno)";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@valor", valor);
                comando.Parameters.AddWithValue("@turma", turmaIndex);
                comando.Parameters.AddWithValue("@aluno", aluno);

                conexao.Open();
                comando.ExecuteNonQuery();

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


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            TelaArquivos telaArquivos = new TelaArquivos();
            telaArquivos.Show();
            this.Hide();
        }

        private void TelaDePagamentos_Load(object sender, EventArgs e)
        {
            comboxTurmas();
            comboxAlunos();
        }

        private void comboTurmas_TextChanged(object sender, EventArgs e)
        {
            comboxAlunos();
        }

        //Buscando Turmas do BAnco de Dados...
        public void comboxTurmas()
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


                conexao.Close();
                conexao.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Buscando Alunos do BAnco de Dados...
        public void comboxAlunos()
        {

            MySqlConnection conexao = br.conexao(conectar);
            try
            {
                string sql = "select nome from lista where Turma = @Turma";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                comando.Parameters.AddWithValue("@Turma",comboTurmas.SelectedIndex+1);
                DataSet ds = new DataSet();
                MySqlDataAdapter adpt = new MySqlDataAdapter(comando);
                adpt.Fill(ds);
                comboAlunos.DataSource = ds.Tables[0];
                comboAlunos.DisplayMember = "nome";


                conexao.Close();
                conexao.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
