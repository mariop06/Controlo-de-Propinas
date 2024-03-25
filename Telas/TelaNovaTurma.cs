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

namespace ControloDePropinas
{
    public partial class TelaNovaTurma : Form
    {
        MySqlConnection conectar;

        // Classe com o médoto que possui as credencias de conexão
        DataBase br = new DataBase();
        public TelaNovaTurma()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tClasse.Text) ||
               string.IsNullOrWhiteSpace(tNome.Text) ||
               string.IsNullOrWhiteSpace(tSala.Text) ||
               string.IsNullOrWhiteSpace(tTurno.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de continuar.");
                tClasse.Text = "";
                tNome.Text = "";
                tSala.Text = "";
                tTurno.Text = "";
                return;
            }



            MySqlConnection conexao = br.conexao(conectar);
            try
            {
                //insert into turma  values (default,'8','BT','5','Manhã');
                string sql = "insert into turma  values (default,@classe,@turma,@Nu_sala,@turno);";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                conexao.Open();
              
                //string sql = "insert into turma values (default,'" + tClasse.Text + "',''" + tNome.Text + "'','" + tSala.Text + "','" + tTurno.Text + "');";
                comando.Parameters.AddWithValue("@classe", tClasse.Text);
                comando.Parameters.AddWithValue("@turma", tNome.Text);
                comando.Parameters.AddWithValue("@Nu_sala", tSala.Text);
                comando.Parameters.AddWithValue("@turno", tTurno.Text);
                comando.ExecuteReader();

                MessageBox.Show("OPERAÇÃO BEM SUCEDIDA!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
            finally
            {
               tClasse.Text="";
               tNome.Text="";
               tSala.Text="";
               tTurno.Text="";
                conexao.Close();
            }
        }
    }
}
