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

        private void button2_Click(object sender, EventArgs e)
        {

            MySqlConnection conexao = br.conexao(conectar);
            try
            {
                string sql = "insert into turma values (default,'"+tClasse.Text+"',''"+tNome.Text+"'','"+tSala.Text+"','"+tTurno.Text+"');";


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
    }
}
