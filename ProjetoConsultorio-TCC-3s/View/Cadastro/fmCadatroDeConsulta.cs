using ProjetoTCC2020.BUS;
using ProjetoTCC2020.Models;
using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace ProjetoTCC2020.Cadastro
{
    public partial class fmCadatroDeConsulta : Form
    {

        private char statusConsulta;
        private int CodClienteSelecionado;
        private DateTime DtConsulta;
        private bool isSearch;
        private readonly bool flag;
        private readonly AgendamentoModel agendamento;
        public bool isRefreshGrid = false;


        public fmCadatroDeConsulta()
        {
            InitializeComponent();

            cbCcStatus.SelectedIndex = 0;
        }
        public fmCadatroDeConsulta(bool flag = false)
        {
            InitializeComponent();
            this.flag = flag;

        }
        public fmCadatroDeConsulta(AgendamentoModel agendamento, bool flag = false)
        {
            InitializeComponent();
            this.flag = flag;
            this.agendamento = agendamento;
        }
        private void CadatroDeConsulta_Load(object sender, EventArgs e)
        {
            AlteraBotoes(flag);
            BuscarTodosPro();
            BuscarTodosServicos();
            cbCcStatus.SelectedIndex = 0;
            cbCcStatus.Enabled = false;

            if (agendamento != null)
            {
                //agendamento.DtConsulta.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                CodClienteSelecionado = agendamento.CodCli;
                DtConsulta = agendamento.DtConsulta;
                dtCcDtConsulta.Value = DtConsulta;
                cbCcDtIni.SelectedValue = agendamento.CodHrIni;
                cbCcDtFinal.SelectedValue = agendamento.CodHrFinal;
                tbCcNome.Text = agendamento.NomeCli;
                cbCcSelecDoc.SelectedValue = agendamento.CodDoc;
                cbCcSelecServ.SelectedValue = agendamento.CodServ;


            }
            else
            {
                dtCcDtConsulta.Value = DateTime.Now;
            }
        }
        private void BuscarClienteCPF(string CPF)
        {

            ClienteBUS clienteBUS = new ClienteBUS();
            tbCcNome.Text = Convert.ToString(clienteBUS.SearchAClientByCPF(CPF));

            Cliente clienteRetorno = new Cliente();
            clienteRetorno = clienteBUS.SearchAClientByCPF(CPF);
            tbCcNome.Text = clienteRetorno.Nome;
            CodClienteSelecionado = clienteRetorno.CodCliente;
            tbCcNome.Refresh();
        }
        private void BuscarTodosPro()
        {
            ProfissionalBUS profissionalBUS = new ProfissionalBUS();
            cbCcSelecDoc.DataSource = profissionalBUS.SearchAllProfissional();
            cbCcSelecDoc.ValueMember = "Código";
            cbCcSelecDoc.DisplayMember = "Nome";
            cbCcSelecDoc.Update();
        }
        private void BuscarTodosServicos()
        {
            ServicosBUS servicosBUS = new ServicosBUS();
            cbCcSelecServ.DataSource = servicosBUS.SearchAllService();
            cbCcSelecServ.ValueMember = "Código";
            cbCcSelecServ.DisplayMember = "Descricao";
            cbCcSelecServ.Update();
        }
        private void BuscarHorarioInicio(DateTime dtAgendamento, int CodAgendamento = 0)
        {
            AgendamentoBUS agendamentoBUS = new AgendamentoBUS();
            isSearch = false;
            DataTable tableTimes = CodAgendamento > 0 ? agendamentoBUS.SearchAllStartTimesUpdate(CodAgendamento, dtAgendamento)
                                                      : agendamentoBUS.SearchAllStartTimes(dtAgendamento);
            if (tableTimes.Rows.Count == 0)
                tableTimes.Rows.Add("29", "00:00:00");


            isSearch = true;
            cbCcDtIni.DataSource = tableTimes;
            cbCcDtIni.ValueMember = "CodHorario";
            cbCcDtIni.DisplayMember = "Horario";

            cbCcDtIni.Update();
        }
        private void BuscarHorarioFinal(int HorarioIni, DateTime DtConsulta)
        {
            AgendamentoBUS agendamentoBUS = new AgendamentoBUS();
            DataTable tableFinais = agendamentoBUS.SearchAllEndTimes(DtConsulta, HorarioIni);
            if (tableFinais.Rows.Count == 0)
                tableFinais.Rows.Add("0", "00:00:00");


            cbCcDtFinal.DataSource = tableFinais;
            cbCcDtFinal.ValueMember = "CodHorario";
            cbCcDtFinal.DisplayMember = "Horario";
            cbCcDtFinal.Update();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void mkCadConsCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        public void limpar(Control.ControlCollection controles)
        {

            foreach (Control ctrl in controles)
            {

                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }

                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)(ctrl)).Text = String.Empty;
                }
            }
        }
        private void btCcLimpar_Click(object sender, EventArgs e)
        {
            limpar(Controls);

            cbCcDtFinal.SelectedIndex = -1;
            cbCcSelecDoc.SelectedIndex = -1;
            cbCcSelecServ.SelectedIndex = -1;
            dtCcDtConsulta.Value = DateTime.Today;
            cbCcStatus.SelectedIndex = 0;
        }
        public void AlteraBotoes(bool flag)
        {

            cbCcStatus.Enabled = flag;
            mkCcCpf.Enabled = flag;
            tbCcNome.Enabled = flag;
            cbCcSelecDoc.Enabled = flag;
            cbCcSelecServ.Enabled = flag;
            dtCcDtConsulta.Enabled = flag;
            cbCcDtIni.Enabled = flag;
            cbCcDtFinal.Enabled = flag;
            btCcInserir.Enabled = flag;
            btLimpar.Enabled = flag;
            btnSearchCPF.Enabled = flag;
            btAlterar.Enabled = !flag;
        }
        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (agendamento != null && agendamento.DtConsulta < DateTime.Now)
            {
                cbCcStatus.Enabled = true;
                mkCcCpf.Enabled = false;
                tbCcNome.Enabled = false;
                cbCcSelecDoc.Enabled = false;
                cbCcSelecServ.Enabled = false;
                dtCcDtConsulta.Enabled = false;
                cbCcDtIni.Enabled = false;
                cbCcDtFinal.Enabled = false;
                btCcInserir.Enabled = true;
                btLimpar.Enabled = false;
                btnSearchCPF.Enabled = false;
                btAlterar.Enabled = false;
            }
            else
            {
                AlteraBotoes(true);
                btLimpar.Enabled = false;
            }
        }
        public void UpdateConsulta(char Status)
        {
            try
            {
                AgendamentoBUS agendamentoBUS = new AgendamentoBUS();
                AgendamentoModel agendamentoUpdate = new AgendamentoModel
                {
                    CodCli = CodClienteSelecionado,
                    CodAgendamento = agendamento.CodAgendamento,
                    StatusConsulta = Status,
                    DtConsulta = dtCcDtConsulta.Value,
                    CodDoc = int.Parse(cbCcSelecDoc.SelectedValue.ToString()),
                    CodServ = int.Parse(cbCcSelecServ.SelectedValue.ToString()),
                    CodHrIni = int.Parse(cbCcDtIni.SelectedValue.ToString()),
                    CodHrFinal = int.Parse(cbCcDtFinal.SelectedValue.ToString()),
                    CodFunc = UsuarioSessao.UsuarioId,
                    MotivoCanc = tbMotivoCancelamento.Text
                };

                RetornoBanco retorno = agendamentoBUS.Update(agendamentoUpdate);
                MessageBox.Show(retorno.MsgRetorno);

                if (retorno.IsOk)
                {
                    this.Close();
                    //Atualizar o grid
                    isRefreshGrid = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível atualizar o agendamento >" + ex.Message);
            }

        }
        public void InserirConsulta(char Status)
        {
            try
            {
                AgendamentoBUS agendamentoBUS = new AgendamentoBUS();
                AgendamentoModel agendamento = new AgendamentoModel
                {
                    StatusConsulta = Status,
                    CodCli = CodClienteSelecionado,
                    DtConsulta = dtCcDtConsulta.Value,
                    CodDoc = int.Parse(cbCcSelecDoc.SelectedValue.ToString()),
                    CodServ = int.Parse(cbCcSelecServ.SelectedValue.ToString()),
                    CodHrIni = int.Parse(cbCcDtIni.SelectedValue.ToString()),
                    CodHrFinal = int.Parse(cbCcDtFinal.SelectedValue.ToString()),
                    CodFunc = UsuarioSessao.UsuarioId
                };

                RetornoBanco retornoBanco = agendamentoBUS.Insert(agendamento);

                MessageBox.Show(retornoBanco.MsgRetorno);

                if (retornoBanco.IsOk)
                {
                    isRefreshGrid = true;
                    Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível incluir o agendamento > " + ex.Message);
            }
        }
        private void btCcInserir_Click(object sender, EventArgs e)
        {

            if (!Validacao.IsValidField(tbCcNome.Text) || CodClienteSelecionado == 0)
            {
                MessageBox.Show("Pesquie um cliente pelo CPF para preencher o campo");
                return;
            }

            if (cbCcDtIni.SelectedValue.ToString().Equals("29"))
            {
                MessageBox.Show("Não existe horário disponível para este dia, por favor escolha outro dia.");
                return;
            }

            if (cbCcDtFinal.SelectedValue.ToString().Equals("0"))
            {
                MessageBox.Show("Selecione um horário Final.");
                return;
            }

            if (agendamento != null)
            {
                //Update
                if (cbCcStatus.SelectedIndex == 2)
                {
                    pnMovitoCancelamento.Visible = true;
                }
                else
                {
                    UpdateConsulta(statusConsulta);
                }
            }
            else
            {
                //Insert
                InserirConsulta('A');
            }
        }
        private void btMotivoCancelamento_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(tbMotivoCancelamento.Text))
            {
                MessageBox.Show("Deve ser inserido um motivo para confirmar o cancelamento!");
                tbMotivoCancelamento.Focus();
            }
            else
            {
                UpdateConsulta('C');
                pnMovitoCancelamento.Visible = false;

            }
        }
        private void btCancMotivoCancelar_Click(object sender, EventArgs e)
        {
            pnMovitoCancelamento.Visible = false;
            tbMotivoCancelamento.Clear();
        }
        private void btnSearchCPF_Click(object sender, EventArgs e)
        {
            string CPF = mkCcCpf.Text;

            //if (String.IsNullOrEmpty(CPF) || CPF == "   .   .   -")
            if (!Validacao.IsValidField(CPF) || !Validacao.IsCpf(CPF))
            {
                MessageBox.Show("O campo de CPF está vazio ou incorreto");
                mkCcCpf.Focus();
                return;
            }

            BuscarClienteCPF(CPF);
        }
        private void dtCcDtConsulta_ValueChanged(object sender, EventArgs e)
        {

            DtConsulta = dtCcDtConsulta.Value;
            int codAgd = 0;
            if (agendamento != null)
                codAgd = agendamento.CodAgendamento;

            BuscarHorarioInicio(DtConsulta, CodAgendamento: codAgd);
        }
        private void cbCcDtIni_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (isSearch)
            {

                bool parseOk = Int32.TryParse(cbCcDtIni.SelectedValue.ToString(), out int selectedValHrIni);
                if (parseOk)
                    BuscarHorarioFinal(selectedValHrIni, DtConsulta);
            }

        }

        private void cbCcStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCcStatus.SelectedIndex == 0)
            {
                statusConsulta = 'A';
            }
            else if (cbCcStatus.SelectedIndex == 1)
            {
                statusConsulta = 'E';
            }
            else
            {
                statusConsulta = 'C';
            }
        }

        private void tbCcNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
