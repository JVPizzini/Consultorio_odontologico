using ProjetoTCC2020.BUS;
using ProjetoTCC2020.Models;
using System;
using System.Windows.Forms;

namespace ProjetoTCC2020.Cadastro
{
    public partial class CadastroCliente : Form
    {
        Cliente cliente;
        public bool isRefreshGrid;

        bool flag = false;
        public CadastroCliente(bool flag)
        {
            InitializeComponent();
            this.flag = flag;
            rdCadCliAtivo.Checked = true;
            rdCadCliAtivo.Enabled = false;
            rdCadCliDesativado.Enabled = false;
        }
        public CadastroCliente(Cliente cliente, bool flag = false)
        {
            InitializeComponent();
            this.flag = flag;
            this.cliente = cliente;
        }

        private void fmCadastroCliente_Load(object sender, EventArgs e)
        {

            AlteraBotoes(flag);
            EstadoBUS estadoBUS = new EstadoBUS();
            cbCadCliUf.DataSource = estadoBUS.GetAllEstados();
            cbCadCliUf.ValueMember = "CodEstado";
            cbCadCliUf.DisplayMember = "UF";
            cbCadCliUf.Update();

            if (cliente != null)
            {
                if (cliente.Ativo == 1)
                {
                    rdCadCliAtivo.Checked = true;
                }
                else
                {
                    rdCadCliDesativado.Checked = true;
                }

                mkCadCpf.Text = cliente.CPF;
                mkCadDtNasc.Text = Convert.ToString(cliente.DtNasc);
                tbCadCliNome.Text = cliente.Nome;
                mkCadCliCep.Text = Convert.ToString(cliente.Cep);
                cbCadCliUf.SelectedValue = cliente.codEstado;
                tbCadCliEnd.Text = cliente.Rua;
                tbCadCliNum.Text = Convert.ToString(cliente.Numero);
                tbCadCliBairro.Text = cliente.Bairro;
                tbCadCliComplemento.Text = cliente.Compl;
                tbCadCliEmail.Text = cliente.Email;
                mkCadCliTel1.Text = cliente.Tel1;
                mkCadCliTel2.Text = cliente.Tel2;
                tbCadCliObs.Text = cliente.Obs;

                CidadeBUS cidadeBUS = new CidadeBUS();

                cbCadCliCidade.DataSource = cidadeBUS.GetAllCidades(cliente.codEstado);
                cbCadCliCidade.ValueMember = "CodCidade";
                cbCadCliCidade.DisplayMember = "Nome";
                cbCadCliCidade.Update();
                cbCadCliCidade.SelectedValue = cliente.codCidade;

            }

        }
        private void btCadCanc_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btCadInserir_Click(object sender, EventArgs e)
        {

            if (!Validacao.IsValidField(mkCadCpf.Text))
            {
                pbCadCpfErrado.Visible = true;
                pbCadCpfCorreto.Visible = false;
                MessageBox.Show("O campo de CPF não pode estar vázio");
                mkCadCpf.Focus();
                return;
            }
            else if (!Validacao.IsValidCPF(mkCadCpf.Text))
            {
                pbCadCpfErrado.Visible = true;
                lbCadMsgErro.Text = "CPF inválido! Por favor, insira um novo número.";
                mkCadCpf.Focus();
                mkCadCpf.Clear();
                return;
            }

            if (!Validacao.IsValidField(mkCadDtNasc.Text))
            {
                MessageBox.Show("Campo Data de nascimento obrigatório");
                mkCadDtNasc.Focus();
                return;
            }
            if (!Validacao.IsValidField(tbCadCliNome.Text))
            {
                MessageBox.Show("Campo nome obrigatório");
                tbCadCliNome.Focus();
                return;
            }
            if (!Validacao.IsValidField(mkCadCliCep.Text) || !(Validacao.RemoverCaracteres(mkCadCliCep.Text).Length == 8))
            {
                MessageBox.Show("Campo CEP obrigatório ou inválido");
                mkCadCliCep.Focus();
                return;
            }
            if (!Validacao.IsValidField(cbCadCliUf.Text))
            {
                MessageBox.Show("Campo Cidade/Estado obrigatório");
                cbCadCliUf.Focus();
                return;
            }
            if (!Validacao.IsValidField(tbCadCliEnd.Text))
            {
                MessageBox.Show("Campo rua obrigatório");
                tbCadCliEnd.Focus();
                return;
            }
            if (!Validacao.IsValidField(tbCadCliBairro.Text))
            {
                MessageBox.Show("Campo bairro obrigatório");
                tbCadCliBairro.Focus();
                return;
            }
            if (!Validacao.IsValidField(tbCadCliNum.Text))
            {
                MessageBox.Show("Campo número obrigatório");
                tbCadCliNum.Focus();
                return;
            }
            if (!Validacao.IsValidField(mkCadCliTel1.Text) || (Validacao.RemoverCaracteres(mkCadCliTel1.Text).Length < 11))
            {
                MessageBox.Show("Campo telefone 1 obrigatório ou inválido");
                mkCadCliTel1.Focus();
                return;
            }
            if (Validacao.RemoverCaracteres(mkCadCliTel2.Text).Length > 0 && Validacao.RemoverCaracteres(mkCadCliTel2.Text).Length < 11)
            {
                MessageBox.Show("Campo telefone 2 inválido");
                mkCadCliTel2.Focus();
                return;
            }
            if (!Validacao.IsValidField(mkCadCliCep.Text))
            {
                MessageBox.Show("Campo CEP obrigatório");
                mkCadCliCep.Focus();
                return;
            }


            try
            {
                int codEstado;
                int codCidade;

                bool parseOkuf = Int32.TryParse(cbCadCliUf.SelectedValue.ToString(), out codEstado);
                bool parseOkcidade = Int32.TryParse(cbCadCliCidade.SelectedValue.ToString(), out codCidade);
                if (cliente != null)
                {
                    //UPDATE
                    ClienteBUS clienteBUS = new ClienteBUS();
                    Cliente clienteUpdate = new Cliente();

                    clienteUpdate.CodCliente = cliente.CodCliente;
                    clienteUpdate.Nome = tbCadCliNome.Text;
                    clienteUpdate.DtNasc = Convert.ToDateTime(mkCadDtNasc.Text);
                    clienteUpdate.Tel1 = mkCadCliTel1.Text;
                    clienteUpdate.Tel2 = mkCadCliTel2.Text;
                    clienteUpdate.Cep = mkCadCliCep.Text;
                    clienteUpdate.Rua = tbCadCliEnd.Text;
                    clienteUpdate.Numero = Convert.ToInt32(tbCadCliNum.Text);
                    clienteUpdate.Compl = tbCadCliComplemento.Text;
                    clienteUpdate.Bairro = tbCadCliBairro.Text;
                    clienteUpdate.Cidade = cbCadCliCidade.Text;
                    clienteUpdate.codCidade = codCidade;
                    clienteUpdate.codEstado = codEstado;
                    clienteUpdate.Uf = cbCadCliUf.Text;
                    clienteUpdate.Email = tbCadCliEmail.Text;
                    clienteUpdate.Obs = tbCadCliObs.Text;
                    clienteUpdate.Ativo = rdCadCliAtivo.Checked ? 1 : 0;

                    RetornoBanco retornoBanco = clienteBUS.ProcUpdate(clienteUpdate);

                    MessageBox.Show(retornoBanco.MsgRetorno);

                    if (retornoBanco.IsOk)
                    {
                        Close();
                        isRefreshGrid = true;
                    }
                }
                else
                {

                    //INSERT
                    ClienteBUS clienteBUS = new ClienteBUS();
                    Cliente cliente = new Cliente();

                    cliente.Nome = tbCadCliNome.Text;
                    cliente.CPF = mkCadCpf.Text;
                    cliente.DtNasc = Convert.ToDateTime(mkCadDtNasc.Text);
                    cliente.Tel1 = mkCadCliTel1.Text;
                    cliente.Tel2 = mkCadCliTel2.Text;
                    cliente.Cep = mkCadCliCep.Text;
                    cliente.Rua = tbCadCliEnd.Text;
                    cliente.Numero = Convert.ToInt32(tbCadCliNum.Text);
                    cliente.Compl = tbCadCliComplemento.Text;
                    cliente.Bairro = tbCadCliBairro.Text;
                    cliente.Cidade = cbCadCliCidade.Text;
                    cliente.codCidade = codCidade;
                    cliente.codEstado = codEstado;
                    cliente.Uf = cbCadCliUf.Text;
                    cliente.Email = tbCadCliEmail.Text;
                    cliente.Obs = tbCadCliObs.Text;
                    cliente.Ativo = 1;

                    RetornoBanco retornoBanco = clienteBUS.ProcInsert(cliente);

                    MessageBox.Show(retornoBanco.MsgRetorno);

                    if (retornoBanco.IsOk)
                    {
                        Close();
                        isRefreshGrid = true;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível incluir o cliente > " + ex.Message);
            }

        }
        private void mkCadCpf_Leave(object sender, EventArgs e)
        {

            if (Validacao.RemoverCaracteres(mkCadCpf.Text).Length > 0)
            {
                if (!Validacao.IsValidCPF(mkCadCpf.Text))
                {
                    VisualizarBotaoCpf(false, true);
                    mkCadCpf.Focus();
                    lbCadMsgErro.Text = "O CPF não existe! Por favor, digite um numero válido.";
                }
                else
                {
                    VisualizarBotaoCpf(true, false);
                    lbCadMsgErro.Text = "";
                }
            }
            else
            {
                VisualizarBotaoCpf(false, false);
                lbCadMsgErro.Text = "";
            }
        }
        private void VisualizarBotaoCpf(bool correto, bool errado)
        {
            pbCadCpfCorreto.Visible = correto;
            pbCadCpfErrado.Visible = errado;

        }
        private void cbCadCliCidade_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void cbCadCliUf_SelectedIndexChanged(object sender, EventArgs e)
        {

            CidadeBUS cidadeBUS = new CidadeBUS();

            int codEstado = 0;

            bool parseOkuf = Int32.TryParse(cbCadCliUf.SelectedValue.ToString(), out codEstado);

            cbCadCliCidade.DataSource = cidadeBUS.GetAllCidades(codEstado);
            cbCadCliCidade.ValueMember = "CodCidade";
            cbCadCliCidade.DisplayMember = "Nome";
            cbCadCliCidade.Update();

        }
        private void tbCadEmail_Leave(object sender, EventArgs e)
        {
            string Email = tbCadCliEmail.Text;
            string EmailValido = Email.ToUpper();

            bool validacaoEmail = (Email.Contains("@") && EmailValido.Contains(".COM"));

            if (Validacao.RemoverCaracteres(tbCadCliEmail.Text).Length > 0)
            {
                if (validacaoEmail == false)
                {
                    lbCadCliEmail.Text = "Inválido";
                    pbCadCliEmailErrado.Visible = true;
                    pbCadCliEmailCorreto.Visible = false;
                    tbCadCliEmail.Focus();

                }
                else
                {
                    lbCadCliEmail.Text = "Ok";
                    pbCadCliEmailErrado.Visible = false;
                    pbCadCliEmailCorreto.Visible = true;

                }
            }
            else
            {
                lbCadCliEmail.Text = " ";
                pbCadCliEmailErrado.Visible = false;
                pbCadCliEmailCorreto.Visible = false;
            }

        }
        private void limpar(Control.ControlCollection controles)
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
        private void btCadLimpar_Click(object sender, EventArgs e)
        {
            limpar(Controls);
            //cbCadCliTipoPessoa.SelectedIndex = 0;
            cbCadCliUf.SelectedIndex = 0;
            cbCadCliCidade.SelectedIndex = 0;
            cbCadCliCidade.Enabled = false;
        }
        private void AlteraBotoes(bool flag)
        {
            tbCadCliNome.Enabled = flag;
            gbCadCliStatus.Enabled = flag;
            mkCadCpf.Enabled = flag;
            mkCadDtNasc.Enabled = flag;
            mkCadCliCep.Enabled = flag;
            cbCadCliUf.Enabled = flag;
            tbCadCliEnd.Enabled = flag;
            tbCadCliNum.Enabled = flag;
            tbCadCliBairro.Enabled = flag;
            cbCadCliCidade.Enabled = flag;
            tbCadCliComplemento.Enabled = flag;
            tbCadCliEmail.Enabled = flag;
            mkCadCliTel1.Enabled = flag;
            mkCadCliTel2.Enabled = flag;
            tbCadCliObs.Enabled = flag;
            btCadInserir.Enabled = flag;
            btCadLimpar.Enabled = flag;
            btCadAlterar.Enabled = !flag;
            rdCadCliAtivo.Enabled = !flag;
            rdCadCliDesativado.Enabled = !flag;

        }
        private void btCadAlterar_Click(object sender, EventArgs e)
        {
            AlteraBotoes(true);
            rdCadCliAtivo.Enabled = true;
            rdCadCliDesativado.Enabled = true;
            mkCadCpf.Enabled = false;
        }
        private void tbCadCliNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
        private void mkCadDtNasc_Leave(object sender, EventArgs e)
        {
            DateTime Hoje = DateTime.Today;
            string dtNoCaracter = Validacao.RemoverCaracteres(mkCadDtNasc.Text);
            if (dtNoCaracter.Length > 0)
            {
                if (dtNoCaracter.Length == 8)
                {
                    DateTime DataNasc = Convert.ToDateTime(mkCadDtNasc.Text);


                    if (DataNasc >= Hoje)
                    {
                        MessageBox.Show("A data não pode ser maior que hoje");
                        mkCadDtNasc.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Informe a data completa");
                    mkCadDtNasc.Focus();
                }

            }
        }

        private void tbCadCliEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void mkCadCliCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}