using ProjetoTCC2020.BUS;
using ProjetoTCC2020.Models;
using System;
using System.Windows.Forms;

namespace ProjetoTCC2020.Cadastro
{
    public partial class fmCadastroProfissional : Form
    {
        Profissional profissional;
        public bool isRefreshGrid;

        bool flag = false;
        public fmCadastroProfissional(bool flag)
        {
            InitializeComponent();
            this.flag = flag;
            rdCadProAtivo.Checked = true;
            rdCadProAtivo.Enabled = false;
            rdCadProDesativado.Enabled = false;
        }
        public fmCadastroProfissional(Profissional profissional, bool flag = false)
        {

            InitializeComponent();
            this.flag = flag;
            this.profissional = profissional;
        }

        private void fmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            rdCadProAtivo.Checked = true;
            AlteraBotoes(flag);
            EstadoBUS estadoBUS = new EstadoBUS();
            cbCadProUf.DataSource = estadoBUS.GetAllEstados();
            cbCadProUf.ValueMember = "CodEstado";
            cbCadProUf.DisplayMember = "UF";
            cbCadProUf.Update();

            if (profissional != null)
            {
                if (profissional.Ativo == 1)
                {
                    rdCadProAtivo.Checked = true;
                }
                else
                {
                    rdCadProDesativado.Checked = true;
                }

                mkCadProCpf.Text = profissional.CPF;
                tbCadProCro.Text = profissional.CRO;
                mkCadProDtNasc.Text = Convert.ToString(profissional.DtNasc);
                tbCadProNome.Text = profissional.Nome;
                mkCadProCep.Text = Convert.ToString(profissional.Cep);
                cbCadProUf.SelectedValue = profissional.codEstado;
                tbCadProEnd.Text = profissional.Rua;
                tbCadProNum.Text = Convert.ToString(profissional.Numero);
                tbCadProBairro.Text = profissional.Bairro;
                tbCadProComp.Text = profissional.Compl;
                tbCadProEmail.Text = profissional.Email;
                mkCadProTel1.Text = profissional.Tel1;
                mkCadProTel2.Text = profissional.Tel2;
                tbCadProObs.Text = profissional.Obs;

                CidadeBUS cidadeBUS = new CidadeBUS();

                cbCadProCidade.DataSource = cidadeBUS.GetAllCidades(profissional.codEstado);
                cbCadProCidade.ValueMember = "CodCidade";
                cbCadProCidade.DisplayMember = "Nome";
                cbCadProCidade.Update();
                cbCadProCidade.SelectedValue = profissional.codCidade;

            }
        }


        private void lbCadUf_Click(object sender, EventArgs e)
        {

        }

        private void btCadCanc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCadInserir_Click(object sender, EventArgs e)
        {

            if (!Validacao.IsValidField(mkCadProCpf.Text))
            {
                pbCadCpfErrado.Visible = true;
                pbCadCpfCorreto.Visible = false;
                MessageBox.Show("O campo de CPF não pode estar vázio");
                mkCadProCpf.Focus();
                return;
            }
            else if (!Validacao.IsValidCPF(mkCadProCpf.Text))
            {
                pbCadCpfErrado.Visible = true;
                lbCadMsgErro.Text = "CPF inválido! Por favor, insira um novo número.";
                mkCadProCpf.Focus();
                mkCadProCpf.Clear();
                return;
            }


            if (!Validacao.IsValidField(tbCadProCro.Text))
            {
                MessageBox.Show("Campo CRO obrigatório");
                tbCadProCro.Focus();
                return;
            }
            if (!Validacao.IsValidField(mkCadProDtNasc.Text))
            {
                MessageBox.Show("Campo Data de Nasc. obrigatório");
                mkCadProDtNasc.Focus();
                return;
            }
            if (!Validacao.IsValidField(tbCadProNome.Text))
            {
                MessageBox.Show("Campo nome obrigatório");
                tbCadProNome.Focus();
                return;
            }
            if (!Validacao.IsValidField(mkCadProCep.Text) || !(Validacao.RemoverCaracteres(mkCadProCep.Text).Length == 8))
            {
                MessageBox.Show("Campo CEP obrigatório ou inválido");
                mkCadProCep.Focus();
                return;
            }
            if (!Validacao.IsValidField(cbCadProUf.Text))
            {
                MessageBox.Show("Campo Cidade/Estado obrigatório");
                cbCadProUf.Focus();
                return;
            }
            if (!Validacao.IsValidField(tbCadProEnd.Text))
            {
                MessageBox.Show("Campo rua obrigatório");
                tbCadProEnd.Focus();
                return;
            }
            if (!Validacao.IsValidField(tbCadProNum.Text))
            {
                MessageBox.Show("Campo número obrigatório");
                tbCadProNum.Focus();
                return;
            }
            if (!Validacao.IsValidField(tbCadProBairro.Text))
            {
                MessageBox.Show("Campo bairro obrigatório");
                tbCadProBairro.Focus();
                return;
            }
            if (!Validacao.IsValidField(mkCadProTel1.Text) || (Validacao.RemoverCaracteres(mkCadProTel1.Text).Length < 11))
            {
                MessageBox.Show("Campo telefone 1 obrigatório ou inválido");
                mkCadProTel1.Focus();
                return;
            }
            if (Validacao.RemoverCaracteres(mkCadProTel2.Text).Length > 0 && Validacao.RemoverCaracteres(mkCadProTel2.Text).Length < 11)
            {
                MessageBox.Show("Campo telefone 2 incompleto");
                mkCadProTel2.Focus();
                return;
            }

            try
            {
                int codEstado;
                int codCidade;

                bool parseOkuf = Int32.TryParse(cbCadProUf.SelectedValue.ToString(), out codEstado);
                bool parseOkcidade = Int32.TryParse(cbCadProCidade.SelectedValue.ToString(), out codCidade);

                if (profissional != null)
                {
                    // UPDATE
                    ProfissionalBUS profissionalBUS = new ProfissionalBUS();
                    Profissional profissionalUpdate = new Profissional();
                    profissionalUpdate.CodPro = profissional.CodPro;
                    profissionalUpdate.Nome = tbCadProNome.Text;
                    profissionalUpdate.CRO = tbCadProCro.Text;
                    profissionalUpdate.DtNasc = Convert.ToDateTime(mkCadProDtNasc.Text);
                    profissionalUpdate.Tel1 = mkCadProTel1.Text;
                    profissionalUpdate.Tel2 = mkCadProTel2.Text;
                    profissionalUpdate.Cep = mkCadProCep.Text;
                    profissionalUpdate.Rua = tbCadProEnd.Text;
                    profissionalUpdate.Numero = Convert.ToInt32(tbCadProNum.Text);
                    profissionalUpdate.Compl = tbCadProComp.Text;
                    profissionalUpdate.Bairro = tbCadProBairro.Text;
                    profissionalUpdate.Cidade = cbCadProCidade.Text;
                    profissionalUpdate.codCidade = codCidade;
                    profissionalUpdate.codEstado = codEstado;
                    profissionalUpdate.Uf = cbCadProUf.Text;
                    profissionalUpdate.Email = tbCadProEmail.Text;
                    profissionalUpdate.Obs = tbCadProObs.Text;
                    profissionalUpdate.Ativo = rdCadProAtivo.Checked ? 1 : 0;

                    RetornoBanco retornoBanco = profissionalBUS.ProcUpdate(profissionalUpdate);

                    MessageBox.Show(retornoBanco.MsgRetorno);

                    if (retornoBanco.IsOk)
                    {
                        Close();
                        isRefreshGrid = true;
                    }
                }
                else
                {
                    // INSERT
                    ProfissionalBUS profissionalBUS = new ProfissionalBUS();
                    Profissional Profissional = new Profissional();
                    Profissional.Nome = tbCadProNome.Text;
                    Profissional.CRO = tbCadProCro.Text;
                    Profissional.CPF = mkCadProCpf.Text;
                    Profissional.DtNasc = Convert.ToDateTime(mkCadProDtNasc.Text);
                    Profissional.Tel1 = mkCadProTel1.Text;
                    Profissional.Tel2 = mkCadProTel2.Text;
                    Profissional.Cep = mkCadProCep.Text;
                    Profissional.Rua = tbCadProEnd.Text;
                    Profissional.Numero = Convert.ToInt32(tbCadProNum.Text);
                    Profissional.Compl = tbCadProComp.Text;
                    Profissional.Bairro = tbCadProBairro.Text;
                    Profissional.Cidade = cbCadProCidade.Text;
                    Profissional.codCidade = codCidade;
                    Profissional.codEstado = codEstado;
                    Profissional.Uf = cbCadProUf.Text;
                    Profissional.Email = tbCadProEmail.Text;
                    Profissional.Obs = tbCadProObs.Text;
                    Profissional.Ativo = 1;

                    RetornoBanco retornoBanco = profissionalBUS.ProcInsert(Profissional);

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
                MessageBox.Show("Não foi possível incluir o Profissional > " + ex.Message + ex.StackTrace);
            }
        }
        private void mkCadCpf_Leave(object sender, EventArgs e)
        {

            if (Validacao.RemoverCaracteres(mkCadProCpf.Text).Length > 0)
            {
                if (!Validacao.IsValidCPF(mkCadProCpf.Text))
                {
                    VisualizarBotaoCpf(false, true);
                    mkCadProCpf.Focus();
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
        public void VisualizarBotaoCpf(bool correto, bool errado)
        {
            pbCadCpfCorreto.Visible = correto;
            pbCadCpfErrado.Visible = errado;

        }
        private void cbCadCliCidade_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void tbCadEmail_Leave(object sender, EventArgs e)
        {
            string Email = tbCadProEmail.Text;
            string EmailValido = Email.ToUpper();

            bool verificacaoDeEmail = (Email.Contains("@") && EmailValido.Contains(".COM"));

            if (Validacao.IsValidField(tbCadProEmail.Text) && Email.Length > 0)
            {
                if (verificacaoDeEmail == false)
                {
                    lbCadCliEmail.Text = "Inválido";
                    pbCadCliEmailErrado.Visible = true;
                    pbCadCliEmailCorreto.Visible = false;
                    tbCadProEmail.Focus();
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
        private void btCadLimpar_Click(object sender, EventArgs e)
        {
            limpar(Controls);

            cbCadProUf.SelectedIndex = 0;
            cbCadProCidade.SelectedIndex = 0;
            cbCadProCidade.Enabled = false;
        }
        private void cbCadProUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            CidadeBUS cidadeBUS = new CidadeBUS();

            int codEstado = 0;

            bool parseOkuf = Int32.TryParse(cbCadProUf.SelectedValue.ToString(), out codEstado);


            cbCadProCidade.DataSource = cidadeBUS.GetAllCidades(codEstado);
            cbCadProCidade.ValueMember = "CodCidade";
            cbCadProCidade.DisplayMember = "Nome";
            cbCadProCidade.Update();
        }
        private void tbCadProCro_Leave(object sender, EventArgs e)
        {

            string CRO = tbCadProCro.Text;
            string CROValido = CRO.ToUpper();

            bool verificacaoDeCro = CROValido.Contains("-");

            if (!String.IsNullOrEmpty(CRO) && CRO.Length > 0)
            {
                if (verificacaoDeCro == false)
                {
                    MessageBox.Show("Verifique a formatação");
                    tbCadProCro.Focus();
                }
            }

        }
        public void AlteraBotoes(bool flag)
        {
            tbCadProNome.Enabled = flag;
            tbCadProCro.Enabled = flag;
            gbCadProStatus.Enabled = flag;
            mkCadProCpf.Enabled = flag;
            mkCadProDtNasc.Enabled = flag;
            mkCadProCep.Enabled = flag;
            cbCadProCidade.Enabled = flag;
            cbCadProUf.Enabled = flag;
            tbCadProEnd.Enabled = flag;
            tbCadProNum.Enabled = flag;
            tbCadProBairro.Enabled = flag;
            tbCadProComp.Enabled = flag;
            tbCadProEmail.Enabled = flag;
            mkCadProTel1.Enabled = flag;
            mkCadProTel2.Enabled = flag;
            tbCadProObs.Enabled = flag;
            btCadProInserir.Enabled = flag;
            btCadProLimpar.Enabled = flag;
            btCadProAlterar.Enabled = !flag;


        }
        private void btCadProAlterar_Click(object sender, EventArgs e)
        {
            AlteraBotoes(true);
            rdCadProAtivo.Enabled = true;
            rdCadProDesativado.Enabled = true;
            mkCadProCpf.Enabled = false;
        }
        private void mkCadProDtNasc_Leave(object sender, EventArgs e)
        {
            DateTime Hoje = DateTime.Today;
            string dtNoCaracter = Validacao.RemoverCaracteres(mkCadProDtNasc.Text);
            if (dtNoCaracter.Length > 0)
            {
                if (dtNoCaracter.Length == 8)
                {
                    DateTime DataNasc = Convert.ToDateTime(mkCadProDtNasc.Text);


                    if (DataNasc >= Hoje)
                    {
                        MessageBox.Show("A data não pode ser maior que hoje");
                        mkCadProDtNasc.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Informe a data completa");
                    mkCadProDtNasc.Focus();
                }

            }

        }
        private void tbCadProNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}