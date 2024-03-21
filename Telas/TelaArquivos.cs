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
        MySqlConnection conexao = new MySqlConnection("datasource = localhost; username = root; database = controlo_propinas; password = mariopaulos06; Sslmode=none;");
        // MySqlConnection conexao = new MySqlConnection("datasource = localhost; username = root; database = controlo_propinas; password = dudoamarildo; Sslmode=none;");
        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            btn_ListaPag.BaseColor = Color.DarkGray;
            Btn_Visualizar.BaseColor = Color.DimGray;
            btn_RefreshPag.BaseColor = Color.DimGray;

            labelFiltroM_Pago.Text = "Filtrar Pago";
            labelF_Npag.Text = "Filtrar Não Pago";

            labelMes.Visible = true;
            comboxMeses.Visible = true;
        }

        private void TelaArquivos_Load(object sender, EventArgs e)
        {
            combox();

            Btn_Visualizar.BaseColor = Color.DarkGray;
            btn_ListaPag.BaseColor = Color.DimGray;
            btn_RefreshPag.BaseColor = Color.DimGray;
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
            Btn_Visualizar.BaseColor = Color.DarkGray;
            btn_ListaPag.BaseColor = Color.DimGray;
            btn_RefreshPag.BaseColor = Color.DimGray;

            labelFiltroM_Pago.Text = "Filtrar Masculino";
            labelF_Npag.Text = "Filtrar Femenino";

            labelMes.Visible = false;
            comboxMeses.Visible = false;

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
            if (Btn_Visualizar.BaseColor == Color.DarkGray && (btn_ListaPag.BaseColor == Color.DimGray && btn_RefreshPag.BaseColor == Color.DimGray))
            {
                //Filtrando os Masculinos da tabela

                if (labelFiltroM_Pago.Text == "Filtrar Masculino")
                {

                    MessageBox.Show("Filtrar Masculino");

                    if (labelFiltroM_Pago.Checked)
                    {

                        DataTable dt = new DataTable();
                        MySqlDataReader resultado;

                        try
                        {
                            int pst = comboBox1.SelectedIndex + 1;

                            string sql = "select lista.proc as 'Processo',lista.num as 'Nº',nome as 'Nome do Aluno',lista.sexo as 'Sexo' from lista inner join turma on turma.id = lista.Turma where Turma = '" + pst + "' AND sexo = 'M';";

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

                //Filtrando os Femeninos da tabela
                if (labelF_Npag.Text == "Filtrar Femenino" )
                {
                    MessageBox.Show("Filtrar Femenino");
                    if (labelF_Npag.Checked)
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
                }

                //Filtrando MAsculino e Femenino

                if ((labelF_Npag.Text == "Filtrar Femenino" && labelFiltroM_Pago.Text == "Filtrar Masculino"))
                {
                    MessageBox.Show("Filtar ambos");

                    if (labelFiltroM_Pago.Checked && labelF_Npag.Checked)
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


            if (btn_ListaPag.BaseColor==Color.DarkGray)
            {
                MessageBox.Show("Botao Lista de Pagamento");
            }

            
        }
    }
}
