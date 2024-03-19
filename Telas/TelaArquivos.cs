using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ControloDePropinas
{
    public partial class TelaArquivos : Form
 
    {
        public TelaArquivos()
        {
            InitializeComponent();


        }
            MySqlConnection conexao = new MySqlConnection("datasource = localhost; username = root; database = controlo_propinas; password = dudoamarildo; Sslmode=none;");
        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
        }

        private void TelaArquivos_Load(object sender, EventArgs e)
        {
            combox();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

         private void combox()
        {
            try 
            {
                string sql = "select distinct(nome_tur) from turma";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();
                DataSet ds = new DataSet();
                MySqlDataAdapter  adpt = new MySqlDataAdapter(comando);
                adpt.Fill(ds);
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "nome_tur";

   
                conexao.Close();
                conexao.Dispose();

            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        // Mário Coloca num changty*************
        // *************************************
        private void gunaButton3_Click(object sender, EventArgs e)
        {
 
           
            DataTable dt = new DataTable();
            MySqlDataReader resultado;

            try
            {
                int pst = comboBox1.SelectedIndex+1;

                string sql = "select lista.proc as 'Processo',lista.num as 'Nº',nome as 'Nome do Aluno',lista.sexo as 'Sexo' from lista inner join turma on turma.id = lista.Turma where Turma = '"+pst+"';";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.CommandType = CommandType.Text;

                conexao.Open();
                resultado = comando.ExecuteReader();
                dt.Load(resultado);

                String sala = "select * from turma where nome_tur = '" + comboBox1.Text + "'";
                MySqlCommand s_sala = new MySqlCommand(sala, conexao);
                MySqlDataReader leitura;
                leitura = s_sala.ExecuteReader();
                while (leitura.Read())
                {
                    gunaLabel5.Text = leitura.GetString("classe");
                    gunaLabel6.Text = leitura.GetString("sala");
                    gunaLabel7.Text = leitura.GetString("turno");

                }

                conexao.Close();
                conexao.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gunaDataGridView1.DataSource = dt;
        }

        private void gunaCheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //Filtrando os Masculinos da tabela
            if (gunaCheckBox1.Checked)
            {

            DataTable dt = new DataTable();
            MySqlDataReader resultado;

            try
            {
                int pst = comboBox1.SelectedIndex+1;

                string sql = "select lista.proc as 'Processo',lista.num as 'Nº',nome as 'Nome do Aluno',lista.sexo as 'Sexo' from lista inner join turma on turma.id = lista.Turma where Turma = '"+pst+"' AND sexo = 'M';";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.CommandType = CommandType.Text;

                conexao.Open();
                resultado = comando.ExecuteReader();
                dt.Load(resultado);

                conexao.Close();
                conexao.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            gunaDataGridView1.DataSource = dt;
            }

            //Filtrando os Femeninos da tabela
            if (gunaCheckBox2.Checked)
            {
                DataTable dt = new DataTable();
                MySqlDataReader resultado;

                try
                {
                    int pst = comboBox1.SelectedIndex + 1;

                    string sql = "select lista.proc as 'Processo',lista.num as 'Nº',nome as 'Nome do Aluno',lista.sexo as 'Sexo' from lista inner join turma on turma.id = lista.Turma where Turma = '" + pst + "' AND sexo = 'F';";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.CommandType = CommandType.Text;

                    conexao.Open();
                    resultado = comando.ExecuteReader();
                    dt.Load(resultado);

                    conexao.Close();
                    conexao.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                gunaDataGridView1.DataSource = dt;
            }

            //Filtrando MAsculino e Femenino
            if (gunaCheckBox1.Checked && gunaCheckBox2.Checked)
            {
                DataTable dt = new DataTable();
                MySqlDataReader resultado;

                try
                {
                    int pst = comboBox1.SelectedIndex + 1;

                    string sql = "select lista.proc as 'Processo',lista.num as 'Nº',nome as 'Nome do Aluno',lista.sexo as 'Sexo' from lista inner join turma on turma.id = lista.Turma where Turma = '" + pst + "';";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.CommandType = CommandType.Text;

                    conexao.Open();
                    resultado = comando.ExecuteReader();
                    dt.Load(resultado);

                    conexao.Close();
                    conexao.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                gunaDataGridView1.DataSource = dt;
            }
        }
    }
}
