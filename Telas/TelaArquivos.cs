﻿using System;
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
using static System.Windows.Forms.LinkLabel;

namespace ControloDePropinas
{
    public partial class TelaArquivos : Form
    {
       private MySqlConnection conectar;
        // Classe com o médoto que possui as credencias de conexão
        DataBase br = new DataBase();


        public TelaArquivos()
        {
            InitializeComponent();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            btn_ListaPag.BaseColor = Color.DarkGray;
            Btn_Visualizar.BaseColor = Color.DimGray;
            btn_RefreshPag.BaseColor = Color.DimGray;
            btactualizar.Visible = false;
            btApagar.Visible = false;   
            lbmesf.Visible = true;

            panelsexo.Visible = false;


            labelFiltroM_Pago.Text = "Filtrar Pago";
            labelFiltroM_Pago.Visible = false;
            labelF_Npag.Text = "Filtrar Não Pago";
            labelF_Npag.Visible = false;

            labelMes.Visible = true;
            comboxMeses.Visible = true;

           comboxMeses.Text = comboxMeses.Items[0].ToString();
            MesFiltro(); 
        }

        private void TelaArquivos_Load(object sender, EventArgs e)
        { 
            combox();
            ListaTurmas();

            Btn_Visualizar.BaseColor = Color.DarkGray;
            btn_ListaPag.BaseColor = Color.DimGray;
            btn_RefreshPag.BaseColor = Color.DimGray;
            lbmesf.Visible= false;
        }

         private void combox()
        {

           MySqlConnection conexao = br.conexao(conectar);
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

        
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Btn_Visualizar.BaseColor = Color.DarkGray;
            btn_ListaPag.BaseColor = Color.DimGray;
            btn_RefreshPag.BaseColor = Color.DimGray;
            btactualizar.Visible = true;
            btApagar.Visible = true;    

            labelFiltroM_Pago.Text = "Filtrar Masculino";
            labelFiltroM_Pago.Visible = true;
            labelF_Npag.Text = "Filtrar Femenino";
            labelF_Npag.Visible = true;
            lbmesf.Visible = false;

            labelMes.Visible = false;
            comboxMeses.Visible = false;
            panelsexo.Visible = true;

            ListaTurmas();

        }
           
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (Btn_Visualizar.BaseColor == Color.DarkGray && (btn_ListaPag.BaseColor == Color.DimGray && btn_RefreshPag.BaseColor == Color.DimGray))
            {
                //Filtrando os Masculinos da tabela
                if (labelFiltroM_Pago.Text == "Filtrar Masculino")
                {
                    if (labelFiltroM_Pago.Checked)
                    {
                        DataTable dt = new DataTable();
                        MySqlDataReader resultado;

                        try
                        {
                            MySqlConnection conexao = br.conexao(conectar);
                            int pst = comboBox1.SelectedIndex + 1;
                            string sql = "select lista.proc as 'Processo',lista.num as 'Nº',nome as 'Nome do Aluno',lista.sexo as 'Sexo' from lista inner join turma on turma.id = lista.Turma where Turma = '" + pst + "' AND sexo = 'M' order by lista.num asc;";

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
                    if (labelF_Npag.Checked)
                    {
                        DataTable dt = new DataTable();
                        MySqlDataReader resultado;
                        try
                        {
                            MySqlConnection conexao = br.conexao(conectar);
                            int pst = comboBox1.SelectedIndex + 1;
                            string sql = "select lista.proc as 'Processo',lista.num as 'Nº',nome as 'Nome do Aluno',lista.sexo as 'Sexo' from lista inner join turma on turma.id = lista.Turma where Turma = '" + pst + "' AND sexo = 'F' order by lista.num asc;";

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
                    if (labelFiltroM_Pago.Checked && labelF_Npag.Checked)
                    {
                        DataTable dt = new DataTable();
                        MySqlDataReader resultado;

                        try
                        {
                            MySqlConnection conexao = br.conexao(conectar);
                            int pst = comboBox1.SelectedIndex + 1;
                            string sql = "select lista.proc as 'Processo',lista.num as 'Nº',nome as 'Nome do Aluno',lista.sexo as 'Sexo' from lista inner join turma on turma.id = lista.Turma where Turma = '" + pst + "' order by lista.num asc;";

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
                
            }
        }

        private void TelaArquivos_DoubleClick(object sender, EventArgs e)
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

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (Btn_Visualizar.BaseColor == Color.DarkGray)
            {
                ListaTurmas();
            }if (btn_ListaPag.BaseColor == Color.DarkGray)
            {
                comboxMeses.Text = comboxMeses.Items[0].ToString();
                MesFiltro();
            }
            
        }

        //#######################################################                        Métodos                    ###############################################################
        public void ListaTurmas()
        {
            DataTable dt = new DataTable();
            MySqlDataReader resultado;

            try
            {
                MySqlConnection conexao = br.conexao(conectar);
                int pst = comboBox1.SelectedIndex + 1;
                string sql = "select lista.proc as 'Processo',lista.num as 'Nº',nome as 'Nome do Aluno',lista.sexo as 'Sexo' from lista inner join turma on turma.id = lista.Turma where Turma = '" + pst + "' order by lista.num asc;";

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


        public void MostraPagos()
        {
            DataTable dt = new DataTable();
            MySqlDataReader resultado;
            try
            {
                MySqlConnection conexao = br.conexao(conectar);
                int pst = comboBox1.SelectedIndex + 1;

                string sql = "select lista.num as 'Nº',lista.nome as 'Aluno',est_mes.Setembro as 'SET',est_mes.Outubro as 'OUT', est_mes.Novembro as 'NOV', est_mes.Dezembro as 'DEZ'," +
                    " est_mes.Janeiro as 'JAN', est_mes.Fevereiro as 'FEV', est_mes.Marco as 'MAÇ', est_mes.Abril as 'ABR',est_mes.Maio as 'MAI', est_mes.Junho as 'JUN' from lista inner join est_mes on proc_a = lista.proc order by lista.num asc;";

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


        public void MesFiltro() 
        {
            DataTable dt = new DataTable();
            MySqlDataReader resultado;
            try
            {
                MySqlConnection conexao = br.conexao(conectar);
                int pst = comboBox1.SelectedIndex + 1;
    
                if (comboxMeses.SelectedIndex==0) 
                {
                    string sql = " select lista.nome as 'Aluno',est_mes.Setembro as 'SET', est_mes.Outubro as 'OUT', est_mes.Novembro as 'NOV'," +
                        " est_mes.Dezembro as 'DEZ', est_mes.Janeiro as 'JAN', est_mes.Fevereiro as 'FEV', est_mes.Marco as 'MAR', est_mes.Abril as 'ABR', est_mes.Maio as 'MAI'," +
                        " est_mes.Junho as 'JUN' from lista inner join est_mes on est_mes.proc_a = lista.proc where lista.Turma = @Turma order by lista.num asc;";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.CommandType = CommandType.Text;

                    conexao.Open();
                    comando.Parameters.AddWithValue("@Turma", pst);

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
                else 
                {
                    string sql = " select lista.proc as 'Processo', lista.num as 'Nº', lista.nome as 'Nome do Aluno', " + (comboxMeses.Text).ToString() + " from lista inner join est_mes on est_mes.proc_a = lista.proc where lista.Turma = @Turma order by lista.num asc;";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.CommandType = CommandType.Text;

                    conexao.Open();
                    comando.Parameters.AddWithValue("@Turma", pst);

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
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            gunaDataGridView1.DataSource = dt;
        }

        private void comboxMeses_TextChanged(object sender, EventArgs e)
        {
            MesFiltro();
        }

        private void btn_RefreshPag_Click(object sender, EventArgs e)
        {
            btn_ListaPag.BaseColor = Color.DimGray;
            Btn_Visualizar.BaseColor = Color.DimGray;
            btn_RefreshPag.BaseColor = Color.DarkGray;

            panelsexo.Visible = false;
            btactualizar.Visible = false;
            btApagar.Visible = false;
            TelaDePagamentos telaDePagamentos = new TelaDePagamentos();
            telaDePagamentos.ShowDialog();
        }

     
        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;

            DataGridViewRow linha = gunaDataGridView1.Rows[indexRow];

            lbApagar.Text = linha.Cells[0].Value.ToString();
            lbnum.Text = linha.Cells[1].Value.ToString();
            lbnome.Text = linha.Cells[2].Value.ToString();
            lbsexo.Text = linha.Cells[3].Value.ToString();


        }

        private void gunaDataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;

            DataGridViewRow linha = gunaDataGridView1.Rows[indexRow];

            lbApagar.Text = linha.Cells[0].Value.ToString();
            lbnum.Text = linha.Cells[1].Value.ToString();
            lbnome.Text = linha.Cells[2].Value.ToString();
            lbsexo.Text = linha.Cells[3].Value.ToString();
        }

        private void btactualizar_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataReader resultado;
            MySqlConnection conexao = br.conexao(conectar);
            btactualizar.BackColor = Color.Gainsboro;

            try
            {
                string sql = " update  lista set  num = '" + lbnum.Text + "', nome='" + lbnome.Text + "', sexo ='" + lbsexo.Text + "' where proc = '" + lbApagar.Text + "';";
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

            finally
            {
                ListaTurmas();

            }
        }

        private void btApagar_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataReader resultado, resultado1;
            MySqlConnection conexao = br.conexao(conectar);

            try
            {
                string sql = " delete from est_mes where proc_a = '" + lbApagar.Text + "';";
                string sql1 = " delete from lista where proc = '" + lbApagar.Text + "';";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                MySqlCommand comando1 = new MySqlCommand(sql1, conexao);

                comando.CommandType = CommandType.Text;
                comando1.CommandType = CommandType.Text;

                conexao.Open();
                resultado = comando.ExecuteReader();
                dt.Load(resultado);
                conexao.Close();
                conexao.Dispose();

                conexao.Open();
                resultado1 = comando1.ExecuteReader();
                dt.Load(resultado1);
                conexao.Close();
                conexao.Dispose();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                ListaTurmas();
            }
        }
    }
}
