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
        private Label[] labels2;
        public TelaDashboard()
        {
            InitializeComponent();
            obterTurma();
            teste();
            teste1();
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

                reader.Close();

                conexao.Close();
                conexao.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        void Testeon()
        {
            MySqlConnection conexao = br.conexao(conectar);
            conexao.Open();

            MySqlCommand countCommand = new MySqlCommand("SELECT COUNT(*) FROM sua_tabela", conexao);
            int totalRecords = Convert.ToInt32(countCommand.ExecuteScalar());

            // Conta quantos registros têm um determinado valor (por exemplo, "Pago") na coluna desejada
            MySqlCommand paidCommand = new MySqlCommand("SELECT COUNT(*) FROM sua_tabela WHERE sua_coluna = 'Pago'", conexao);
            int paidRecords = Convert.ToInt32(paidCommand.ExecuteScalar());

            // Calcula a porcentagem de registros que têm o valor "Pago"
            double paymentPercentage = (double)paidRecords / totalRecords * 100;

            // Atualiza a ProgressBar com o valor da porcentagem calculada
            progressBar1.Value = (int)Math.Round(paymentPercentage);

        }






        void obterPercentagem()
        {
            labels2 = new Label[] {label9, label10, label12, label14, label16, label18};
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
                    labels2[labelIndex].Text = columnValue;
                    labelIndex++;
                }

                reader.Close();

                conexao.Close();
                conexao.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TelaDashboard_Load(object sender, EventArgs e)
        {
            int num = 45;
            CircleProgressBar1.Value = num;
            label22.Text = num + "%";


            progressBar1.Value = 60;
            label9.Text =60+"%";

            progressBar2.Value = 3;
            label10.Text = 3 + "%";

            progressBar3.Value = 52;
            label12.Text = 52 + "%";

            progressBar4.Value = 23;
            label14.Text = 23 + "%";

            progressBar5.Value = 10;
            label16.Text = 10 + "%";

            progressBar6.Value = 15;
            label18.Text = 15 + "%";

        }
    }
}
