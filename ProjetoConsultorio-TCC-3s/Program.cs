using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoTCC2020.Agendamento;
using ProjetoTCC2020.Cadastro;
using ProjetoTCC2020.Serviços;
using ProjetoTCC2020.View.Login;

namespace ProjetoTCC2020
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fmLogin());
        }
    }
}
