
using ControloDePropinas.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControloDePropinas
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TelaPrincipal telaPrincipal = new TelaPrincipal();
            TelaArquivos telaArquivos = new TelaArquivos();
            TelaLogin telaLogin = new TelaLogin(telaPrincipal);

            Application.Run(telaLogin);

        }
    }
}


