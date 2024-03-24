using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ControloDePropinas.Telas
{
    public partial class TelaDashboard : Form
    {
        MySqlConnection conectar;

        // Classe com o médoto que possui as credencias de conexão
        DataBase br = new DataBase();

        private Label[] labels;
        public TelaDashboard()
        {
            InitializeComponent();
            obterTurma();
            teste();
            teste1();
        }

        private void Charts()
        {
            //MySqlConnection conexao = br.conexao(conectar);

            //try
            //{

            //}
            //catch ()
            //{

            //}

        }

        public void teste()
        {
            MySqlDataReader resultado;

            try
            {
                MySqlConnection conexao = br.conexao(conectar);
                conexao.Open();

                String sql = "select count(id) as 'turmas' from turma;";
                MySqlCommand s_sala = new MySqlCommand(sql, conexao);
                MySqlDataReader leitura;
                leitura = s_sala.ExecuteReader();

                while (leitura.Read() )
                {
                    label1.Text = leitura.GetString("turmas");
                }

                conexao.Close();
                conexao.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void teste1()
        {
            MySqlDataReader resultado;

            try
            {
                MySqlConnection conexao = br.conexao(conectar);
                conexao.Open();


                String sql1 = "select count(id) as 'listas' from lista;";
                MySqlCommand ret = new MySqlCommand(sql1, conexao);
                MySqlDataReader leitura1;
                leitura1 = ret.ExecuteReader();


                while (leitura1.Read())
                {
                    label4.Text = leitura1.GetString("listas");
                }

                conexao.Close();
                conexao.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void obterTurma()
        {
            labels = new Label[] { label8, label11, label13, label15, label17, label19};
            MySqlDataReader resultado;

            try
            {
                MySqlConnection conexao = br.conexao(conectar);
                conexao.Open();

                string sqlQuery = "SELECT nome_tur FROM turma LIMIT 6";
                MySqlCommand command = new MySqlCommand(sqlQuery, conexao);

                MySqlDataReader reader = command.ExecuteReader();

                int labelIndex = 0;

             
                while (reader.Read() && labelIndex < 6)
                {
                    string columnValue = reader.GetString(0); 
                    labels[labelIndex].Text = columnValue;
                    labelIndex++;
                }

                // Fecha o leitor de dados
                reader.Close();

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
