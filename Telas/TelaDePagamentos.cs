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

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            TelaArquivos telaArquivos = new TelaArquivos();
            telaArquivos.Show();
            this.Close();
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
