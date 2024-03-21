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
        MySqlConnection conexao = new MySqlConnection("datasource = localhost; username = root; database = controlo_propinas; password = dudoamarildo; Sslmode=none;");

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

        

        private void buttonEntrar_Click(object sender, EventArgs e)
        { 
      

            try
            {
      

                string sql = "insert into lista values (default, @TxtProc, @TxtNum, @TxtNome, @comboSexo, @comboTurmas);";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();


                comando.Parameters.AddWithValue("@TxtProc", TxtProc.Text);
                comando.Parameters.AddWithValue("@TxtNum", TxtNum.Text);
                comando.Parameters.AddWithValue("@TxtNome", TxtNome.Text);
                comando.Parameters.AddWithValue("@comboSexo", comboSexo.Text);
                comando.Parameters.AddWithValue("@comboTurmas", comboTurmas.SelectedIndex+1);
                comando.ExecuteReader();

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
                MessageBox.Show("OPERAÇÃO BEM SUCEDIDA!");

                TxtProc.Text = "";
                TxtNum.Text = "";
                TxtNome.Text = "";
                comboSexo.Text="";
                comboTurmas.Text = "";
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.Show();
            this.Hide();
        }

        private void TxtNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

