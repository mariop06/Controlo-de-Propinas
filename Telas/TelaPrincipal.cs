
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

namespace ControloDePropinas.Telas
{
    public partial class TelaPrincipal : Form
    {
        bool sidebarExpand = true;
        bool visible = true;
        private MySqlConnection connection = new MySqlConnection();

        public TelaPrincipal()
        {
            InitializeComponent();

            if (visible)
            {
                mainPanel.Visible = false;

            }

        }

        public void Acesso(string nome, string username)
        {
            labelNome.Text = nome;
            labelUsername.Text = "@" + username;

            labelBV.Text = "BEM-VINDO " + nome;
        }


        public void LoadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }


        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            labelBV.Visible = true;
            mainPanel.Visible = false;
            btn_Inicio.BaseColor = Color.Gray;
            btn_dash.BaseColor = Color.Transparent;
            btn_more.BaseColor = Color.Transparent;
            btn_atividade.BaseColor = Color.Transparent;
            btn_info.BaseColor = Color.Transparent;
            sair.BaseColor = Color.Transparent;
        }

       
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            sideBarP.BringToFront();
            if (sidebarExpand)
            {
                sideBarP.Width += 10;
                btn_Inicio.Width += 10;
                btn_dash.Width += 10;
                btn_more.Width += 10;
                btn_atividade.Width += 10;
                btn_info.Width += 10;
                label1.Width += 10;
                sair.Width += 10;

                if (sideBarP.Width == sideBarP.MaximumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sideBarP.Width -= 10;
                btn_Inicio.Width -= 10;
                btn_dash.Width -= 10;
                btn_more.Width -= 10;
                btn_atividade.Width -= 10;
                btn_info.Width -= 10;
                sair.Width -=10;

                panelOpcoes.Height -= 10;
                if (panelOpcoes.Height <= panelOpcoes.MinimumSize.Height)
                    panelOpcoes.Height = panelOpcoes.MinimumSize.Height;


                if (panelOpcoes.Height > 65)
                    btn_atividade.Location = new Point(btn_atividade.Location.X, btn_atividade.Location.Y - 10);


                if (sideBarP.Width == sideBarP.MinimumSize.Width)
                {
                    btn_atividade.Location = new Point(btn_atividade.Location.X, 298);
                    panelOpcoes.Height = 65;
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            labelBV.Visible = true;
            mainPanel.Visible = false;
             btn_Inicio.BaseColor = Color.Gray;
            btn_dash.BaseColor = Color.Transparent;
            btn_more.BaseColor = Color.Transparent;
            btn_atividade.BaseColor = Color.Transparent;
            btn_info.BaseColor = Color.Transparent;
            sair.BaseColor = Color.Transparent;
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            labelBV.Visible = false;

            btn_Inicio.BaseColor = Color.Transparent;
            btn_dash.BaseColor = Color.Transparent;
            btn_more.BaseColor = Color.Transparent;
            btn_atividade.BaseColor = Color.Transparent;
            btn_info.BaseColor = Color.Gray;
            sair.BaseColor = Color.Transparent;

            mainPanel.Visible = true;
            LoadForm(new TelaInformações());
        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
            btn_Inicio.BaseColor = Color.Transparent;
            btn_dash.BaseColor = Color.Gray;
            btn_more.BaseColor = Color.Transparent;
            btn_atividade.BaseColor = Color.Transparent;
            btn_info.BaseColor = Color.Transparent;
            sair.BaseColor = Color.Transparent;

            labelBV.Visible = false;
            mainPanel.Visible = true;
            LoadForm(new TelaDashboard());

        }

        private void timerButtonMore_Tick(object sender, EventArgs e)
        {
            bool valido = Convert.ToBoolean(sideBarP.MaximumSize.Width);
            if (valido)
            {
                btn_atividade.Location = new Point(btn_atividade.Location.X, btn_atividade.Location.Y + 10);
                panelOpcoes.Height += 10;

                if (panelOpcoes.Height >= panelOpcoes.MaximumSize.Height)
                {
                    btn_atividade.Location = new Point(btn_atividade.Location.X, 420);
                    btn_atividade.BringToFront();
                    panelOpcoes.Height = 210;
                    timerButtonMore.Stop();
                }
            }
        }

        private void btn_more_Click(object sender, EventArgs e)
        {

            sideBarP.BringToFront();
            sidebarTimer.Start();
            labelBV.Visible = false;

            btn_Inicio.BaseColor = Color.Transparent;
            btn_dash.BaseColor = Color.Transparent;
            btn_more.BaseColor = Color.Gray;
            btn_atividade.BaseColor = Color.Transparent;
            btn_info.BaseColor = Color.Transparent;
            sair.BaseColor = Color.Transparent;
            timerButtonMore.Start();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.ShowDialog();
        }

        private void btn_atividade_Click(object sender, EventArgs e)
        {
            labelBV.Visible = false;

            btn_Inicio.BaseColor = Color.Transparent;
            btn_dash.BaseColor = Color.Transparent;
            btn_more.BaseColor = Color.Transparent;
            btn_atividade.BaseColor = Color.Gray;
            btn_info.BaseColor = Color.Transparent;
            sair.BaseColor = Color.Transparent;


            mainPanel.Visible = true;
            LoadForm(new TelaArquivos());
        }

        private void TelaPrincipal_DoubleClick(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void sideBarP_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void mainPanel_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void sair_Click(object sender, EventArgs e)
        {
            btn_Inicio.BaseColor = Color.Transparent;
            btn_dash.BaseColor = Color.Transparent;
            btn_more.BaseColor = Color.Transparent;
            btn_atividade.BaseColor = Color.Transparent;
            btn_info.BaseColor = Color.Transparent;
            sair.BaseColor = Color.Gray;


                connection.Close();
            

            // Fecha o formulário principal
            TelaLogin telaLogin = new TelaLogin(new TelaPrincipal());
            telaLogin.Show();
            this.Close();
        }

        private void timerMainPanel_Tick(object sender, EventArgs e)
        {
            
            if (sidebarExpand)
            {
              
                sideBarP.Width += 10;
                btn_Inicio.Width += 10;
                btn_dash.Width += 10;
                btn_more.Width += 10;
                btn_atividade.Width += 10;
                btn_info.Width += 10;
                label1.Width += 10;
                sair.Width += 10;

                if (sideBarP.Width == sideBarP.MaximumSize.Width)
                {
                    sidebarExpand = false;
                    timerMainPanel.Stop();
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

     
     

        private void timerPanelLeave_Tick(object sender, EventArgs e)
        {

        
            sideBarP.Width -= 10;
            btn_Inicio.Width -= 10;
            btn_dash.Width -= 10;
            btn_more.Width -= 10;
            btn_atividade.Width -= 10;
            btn_info.Width -= 10;
            sair.Width -= 10;

            panelOpcoes.Height -= 10;
            if (panelOpcoes.Height <= panelOpcoes.MinimumSize.Height)
                panelOpcoes.Height = panelOpcoes.MinimumSize.Height;



            if (panelOpcoes.Height > 65)
                btn_atividade.Location = new Point(btn_atividade.Location.X, btn_atividade.Location.Y - 10);


            if (sideBarP.Width == sideBarP.MinimumSize.Width)
            {
               
                btn_atividade.Location = new Point(btn_atividade.Location.X, 298);
                panelOpcoes.Height = 65;
                sidebarExpand = true;
                timerPanelLeave.Stop();
            }
        }

        private void buttonExpand_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
    }
}
