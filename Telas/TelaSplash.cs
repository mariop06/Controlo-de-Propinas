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
    public partial class TelaSplash : Form
    {
        public TelaSplash()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {

            timer1.Interval = 100; 
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        private void TelaSplash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            ProgressBar.Value += 1; 
            if (ProgressBar.Value >= 100)
            {
                timer1.Stop();
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                TelaLogin telaLogin = new TelaLogin(telaPrincipal);
                telaLogin.Show();
                this.Hide();
            }
        }
    }
}
