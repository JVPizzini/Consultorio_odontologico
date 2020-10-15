//using Microsoft.Office.Interop.Excel;
//using Microsoft.Vbe.Interop;
using ProjetoTCC2020.Agendamento;
using ProjetoTCC2020.Models;
using ProjetoTCC2020.Pesquisa;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace ProjetoTCC2020
{
    public partial class Consultorio : Form
    {


        public Consultorio()
        {
            InitializeComponent();

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmPesquisa pesquisa = new fmPesquisa();
            pesquisa.ShowDialog();
        }
        private void listasDeAgendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAgenda agendamento = new fmAgenda();
            agendamento.ShowDialog();
        }
        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmPesquisaServico PesquisaServicos = new fmPesquisaServico();
            PesquisaServicos.ShowDialog();
        }

        private void Consultorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desejar fechar o programa?", "Encerrar", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.No))
            {
                e.Cancel = true;
            }
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmRelatorio Relatorio = new fmRelatorio();
            Relatorio.ShowDialog();
        }

        private void Consultorio_Load(object sender, EventArgs e)
        {
            lbData.Text = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            lbUser.Text = UsuarioSessao.NomeUsuario;
            timer1.Start();
        }

        private void Consultorio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}