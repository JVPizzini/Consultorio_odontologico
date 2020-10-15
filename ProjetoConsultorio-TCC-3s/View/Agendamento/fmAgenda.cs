using ProjetoTCC2020.BUS;
using ProjetoTCC2020.Cadastro;
using ProjetoTCC2020.Models;
using ProjetoTCC2020.View.Agendamento;
using System;
using System.Windows.Forms;

namespace ProjetoTCC2020.Agendamento
{
    public partial class fmAgenda : Form
    {
        int CodConsulta = 0;
        public fmAgenda()
        {
            InitializeComponent();
            lbAgData.Text = CalendarioAg.SelectionStart.ToString("dd/MM/yyyy");
        }

        private void AgCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            GridConsulta();
            lbAgData.Text = CalendarioAg.SelectionStart.ToString("dd/MM/yyyy");
        }

        private void btAgInserir_Click(object sender, EventArgs e)
        {
            fmCadatroDeConsulta CadastroConsulta = new fmCadatroDeConsulta(true);
            CadastroConsulta.ShowDialog();
            if (CadastroConsulta.isRefreshGrid)
            {
                GridConsulta();
            }
        }
        private void fmAgenda_Load(object sender, EventArgs e)
        {
            GridConsulta();
        }
        private void gbAgPesquisa_Enter(object sender, EventArgs e)
        {

        }
        private void gridAg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CodConsulta = Convert.ToInt32(gridAg.Rows[e.RowIndex].Cells[0].Value);

            AgendamentoBUS agendamentoBUS = new AgendamentoBUS();
            AgendamentoModel agendamentoRecebido = new AgendamentoModel();
            agendamentoRecebido = agendamentoBUS.SearchAgendamento(CodConsulta);

            fmCadatroDeConsulta agendamento = new fmCadatroDeConsulta(agendamentoRecebido, flag: false);
            agendamento.ShowDialog();
            if (agendamento.isRefreshGrid)
            {
                GridConsulta();
            }

        }
        private void GridConsulta()
        {
            string DataSelecionada = CalendarioAg.SelectionStart.ToString("dd/MM/yyyy");

            AgendamentoBUS agendamentoBUS = new AgendamentoBUS();
            gridAg.DataSource = agendamentoBUS.SearchAllConsultations(DataSelecionada);

            //Inicio, Fim , Código, Paciente, Serviço, Profissional
            foreach (DataGridViewColumn column in gridAg.Columns)
            {
                if (column.Index == 0)
                {
                    column.Width = 50;
                }

                if (column.Index == 1)
                {
                    column.Width = 50;
                }

                if (column.Index == 2)
                {
                    column.Width = 50;
                }

                if (column.Index == 3)
                {
                    column.Width = 210;
                }

                if (column.Index == 4)
                {
                    column.Width = 170;
                }

                if (column.Index == 5)
                {
                    column.Width = 190;
                }
            }

            gridAg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridAg.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridAg.CancelEdit();
            gridAg.Refresh();

        }
        private void btAgBuscar_Click(object sender, EventArgs e)
        {
            lbAgData.Text = "  Consulta";


            string DataIni;
            string DataFim;

            DataIni = dtAgIni.Value.ToString("dd/MM/yyyy");
            DataFim = dtAgFinal.Value.ToString("dd/MM/yyyy HH:mm:ss");

            AgendamentoBUS agendamentoBUS = new AgendamentoBUS();
            gridAg.Columns.Clear();
            gridAg.DataSource = agendamentoBUS.SearchQuery(DataIni, DataFim);

            foreach (DataGridViewColumn column in gridAg.Columns)
            {
                if (column.Index == 0)
                    column.Width = 50;
                if (column.Index == 1)
                    column.Width = 80;
                if (column.Index == 2)
                    column.Width = 50;
                if (column.Index == 3)
                    column.Width = 50;
                if (column.Index == 4)
                    column.Width = 170;
                if (column.Index == 5)
                    column.Width = 170;
                if (column.Index == 6)
                    column.Width = 170;
            }

            gridAg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridAg.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridAg.CancelEdit();
            gridAg.Refresh();
        }
        private void btAgHorariosDisp_Click(object sender, EventArgs e)
        {
            fmHorariosDisp fmHorarios = new fmHorariosDisp();
            fmHorarios.ShowDialog();
        }
        private void btAgCanc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
