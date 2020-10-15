using ProjetoTCC2020.BUS;
using ProjetoTCC2020.Models;
using ProjetoTCC2020.Serviços;
using System;
using System.Windows.Forms;

namespace ProjetoTCC2020.Pesquisa
{
    public partial class fmPesquisaServico : Form
    {
        int codServ = 0;
        public fmPesquisaServico()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fmServicos Servicos = new fmServicos(true);
            Servicos.ShowDialog();
            if (Servicos.IsRefreshGrid)
            {
                GridServicos();
            }
        }

        private void btPesqCanc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fmPesquisaServico_Load(object sender, EventArgs e)
        {
            GridServicos();
        }

        private void gridServ_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codServ = Convert.ToInt32(gridServ.Rows[e.RowIndex].Cells[0].Value);

            ServicosBUS ServicosBUS = new ServicosBUS();
            Servico ServicoRecebido = new Servico();
            ServicoRecebido = ServicosBUS.SearchServico(codServ);

            fmServicos Servico = new fmServicos(ServicoRecebido, flag: false);
            Servico.ShowDialog();
            if (Servico.IsRefreshGrid)
            {
                GridServicos();
            }
        }

        private void btServBuscar_Click(object sender, EventArgs e)
        {
            GridServicos();
        }
        private void GridServicos()
        {
            string Descricao = mkPesqServNome.Text;

            ServicosBUS servicosBUS = new ServicosBUS();
            gridServ.DataSource = servicosBUS.SearchAService(Descricao);

            foreach (DataGridViewColumn column in gridServ.Columns)
            {
                if (column.DataPropertyName == "Código")
                {
                    column.Width = 70;
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }

            gridServ.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridServ.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridServ.Refresh();

        }
    }
}
