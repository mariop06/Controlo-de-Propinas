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
        bool sidebarExpand=true;
        public TelaPrincipal()
        {
            InitializeComponent();
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

                //label3.Width -= 10;
                //label3.Location = new Point(label3.Location.X + 10, label3.Location.Y);

                if (sideBarP.Width == sideBarP.MaximumSize.Width)
                {
                    label3.Location = new Point(210, label3.Location.Y);
                    label3.Width = 1250;
                   
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

                label3.Width -= 10;
                label3.Location = new Point(label3.Location.X - 10, label3.Location.Y);

                if (sideBarP.Width==sideBarP.MinimumSize.Width)
                {
                    //label3.Location = new Point(138, label3.Location.Y);
                    //label3.Width = 1320;
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void sideBarP_MouseHover(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
    }
}
