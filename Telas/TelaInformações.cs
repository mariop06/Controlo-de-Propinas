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
    public partial class TelaInformações : Form
    {
        public TelaInformações()
        {
            InitializeComponent();
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TelaInformações_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel16_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if(gunaLabel9.Visible == false)
            {
                gunaLabel9.Visible = true;
                guna2PictureBox1.Image= ControloDePropinas.Properties.Resources.cima;
            }
            else
            {
                gunaLabel9.Visible = false;
                guna2PictureBox1.Image = ControloDePropinas.Properties.Resources.baixo;
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if (gunaLabel10.Visible == false)
            {
                gunaLabel10.Visible = true;
                guna2PictureBox2.Image = ControloDePropinas.Properties.Resources.cima;
            }
            else
            {
                gunaLabel10.Visible = false;
                guna2PictureBox2.Image = ControloDePropinas.Properties.Resources.baixo;
            }
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            if (gunaLabel11.Visible == false)
            {
                gunaLabel11.Visible = true;
                guna2PictureBox3.Image = ControloDePropinas.Properties.Resources.cima;
            }
            else
            {
                gunaLabel11.Visible = false;
                guna2PictureBox3.Image = ControloDePropinas.Properties.Resources.baixo;
            }
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            if (gunaLabel12.Visible == false)
            {
                gunaLabel12.Visible = true;
                guna2PictureBox4.Image = ControloDePropinas.Properties.Resources.cima;
            }
            else
            {
                gunaLabel12.Visible = false;
                guna2PictureBox4.Image = ControloDePropinas.Properties.Resources.baixo;
            }
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            if (gunaLabel13.Visible == false)
            {
                gunaLabel13.Visible = true;
                guna2PictureBox5.Image = ControloDePropinas.Properties.Resources.cima;
            }
            else
            {
                gunaLabel13.Visible = false;
                guna2PictureBox5.Image = ControloDePropinas.Properties.Resources.baixo;
            }
        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            if (gunaLabel14.Visible == false)
            {
                gunaLabel14.Visible = true;
                guna2PictureBox6.Image = ControloDePropinas.Properties.Resources.cima;
            }
            else
            {
                gunaLabel14.Visible = false;
                guna2PictureBox6.Image = ControloDePropinas.Properties.Resources.baixo;
            }
        }

        private void gunaLabel13_Click(object sender, EventArgs e)
        {

        }
    }
}
