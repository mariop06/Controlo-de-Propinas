
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
        }


        public void LoadForm(object Form)
        {
            //form = new Telas.Configuracoes();
            //paneljanela.Controls.Clear();
            //form.TopLevel = false;
            //form.Visible = true;
            //form.Dock = DockStyle.Fill;
            //paneljanela.Controls.Add(form);
            //btnconfig.FillColor = Color.Orange;
            //btnhome.FillColor = Color.Transparent;
            //btnadd.FillColor = Color.Transparent;
            //btnhelp.FillColor = Color.Transparent;
            //btn_ver.FillColor = Color.Transparent;

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



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
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



        private void sideBarP_MouseHover(object sender, EventArgs e)
        {
            sideBarP.BringToFront();
            sidebarTimer.Start();
        }

        private void btn_more_MouseHover(object sender, EventArgs e)
        {
            sideBarP.BringToFront();
            sidebarTimer.Start();
        }
        private void btn_Inicio_Click(object sender, EventArgs e)
        {

        }

        private void btn_Inicio_MouseHover(object sender, EventArgs e)
        {
            sideBarP.BringToFront();
            sidebarTimer.Start();
        }

        private void btn_dash_MouseHover(object sender, EventArgs e)
        {
            sideBarP.BringToFront();
            sidebarTimer.Start();
        }

        private void btn_atividade_MouseHover(object sender, EventArgs e)
        {
            sideBarP.BringToFront();
            sidebarTimer.Start();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            LoadForm(new TelaInformações());
        }

        private void btn_info_MouseHover(object sender, EventArgs e)
        {

        }


        private void btn_Inicio_MouseUp(object sender, MouseEventArgs e)
        {
            sideBarP.BringToFront();
            sidebarTimer.Start();
        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
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
            timerButtonMore.Start();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_atividade_Click(object sender, EventArgs e)
        {
            mainPanel.Visible = true;
            LoadForm(new TelaArquivos());
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
