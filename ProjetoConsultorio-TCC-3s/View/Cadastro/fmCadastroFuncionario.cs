using ProjetoTCC2020.BUS;
using ProjetoTCC2020.Models;
using System;
using System.Windows.Forms;

namespace ProjetoTCC2020.Cadastro
{
    public partial class fmCadastroFuncionario : Form
    {
        Funcionario funcionario;
        public bool isRefreshGrid;
        bool flag = false;
        public fmCadastroFuncionario(bool flag)
        {
            InitializeComponent();
            this.flag = flag;
            rdCadfunAtivo.Checked = true;
            rdCadfunAtivo.Enabled = false;
            rdCadFunDesativado.Enabled = false;
        }
        public fmCadastroFuncionario(Funcionario funcionario, bool flag = false)
        {

            InitializeComponent();
            this.flag = flag;
            this.funcionario = funcionario;

        }

        private void fmCadastroCliente_Load(object sender, EventArgs e)
        {
            AlteraBotoes(flag);
            EstadoBUS estadoBUS = new EstadoBUS();
            cbCadFunUf.DataSource = estadoBUS.GetAllEstados();
            cbCadFunUf.ValueMember = "CodEstado";
            cbCadFunUf.DisplayMember = "UF";
            cbCadFunUf.Update();

            if (funcionario != null)
            {
                if (funcionario.Ativo == 1)
                {
                    rdCadfunAtivo.Checked = true;
                }
                else
                {
                    rdCadFunDesativado.Checked = true;
                }

                mkCadFunCpf.Text = funcionario.CPF;
                tbCadFunNome.Text = funcionario.Nome;
                mkCadFunCep.Text = Convert.ToString(funcionario.Cep);
                cbCadFunUf.SelectedValue = funcionario.codEstado;
                tbCadFunEnd.Text = funcionario.Rua;
                tbCadFunNum.Text = Convert.ToString(funcionario.Numero);
                tbCadFunBairro.Text = funcionario.Bairro;
                tbCadFunComplemento.Text = funcionario.Compl;
                mkCadFunTel1.Text = funcionario.Tel1;
                tbCadFunSenha.Text = funcionario.Senha;


                CidadeBUS cidadeBUS = new CidadeBUS();

                cbCadFunCidade.DataSource = cidadeBUS.GetAllCidades(funcionario.codEstado);
                cbCadFunCidade.ValueMember = "CodCidade";
                cbCadFunCidade.DisplayMember = "Nome";
                cbCadFunCidade.Update();
                cbCadFunCidade.SelectedValue = funcionario.codCidade;

            }
        }
        private void btCadCanc_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btCadInserir_Click(object sender, EventArgs e)
        {

            if (!Validacao.IsValidField(mkCadFunCpf.Text))
            {
                pbCadCpfErrado.Visible = true;
                pbCadCpfCorreto.Visible = false;
                MessageBox.Show("O campo de CPF não pode estar vázio");
                mkCadFunCpf.Focus();
                return;
            }
            else if (!Validacao.IsValidCPF(mkCadFunCpf.Text))
            {
                pbCadCpfErrado.Visible = true;
                lbCadMsgErro.Text = "CPF inválido! Por favor, insira um novo número.";
                mkCadFunCpf.Focus();
                mkCadFunCpf.Clear();
                return;
            }

            if (!Validacao.IsValidField(tbCadFunNome.Text))

            {
                MessageBox.Show("Campo nome obrigatório");
                tbCadFunNome.Focus();
                return;
            }
            if (!Validacao.IsValidField(mkCadFunCep.Text) || !(Validacao.RemoverCaracteres(mkCadFunCep.Text).Length == 8))
            {
                MessageBox.Show("Campo CEP obrigatório");
                mkCadFunCep.Focus();
                return;
            }
            if (!Validacao.IsValidField(cbCadFunUf.Text))
            {
                MessageBox.Show("Campo Cidade/Estado obrigatório");
                cbCadFunUf.Focus();
                return;
            }

            if (!Validacao.IsValidField(tbCadFunEnd.Text))
            {
                MessageBox.Show("Campo rua obrigatório");
                tbCadFunEnd.Focus();
                return;
            }

            if (!Validacao.IsValidField(tbCadFunNum.Text))
            {
                MessageBox.Show("Campo número obrigatório");
                tbCadFunNum.Focus();
                return;
            }

            if (!Validacao.IsValidField(tbCadFunBairro.Text))
            {
                MessageBox.Show("Campo bairro obrigatório");
                tbCadFunBairro.Focus();
                return;
            }

            if ((!Validacao.IsValidField(mkCadFunTel1.Text)) || (Validacao.RemoverCaracteres(mkCadFunTel1.Text).Length <= 11))
            {
                MessageBox.Show("Campo telefone obrigatório ou inválido");
                mkCadFunTel1.Focus();
                return;
            }

            if (!Validacao.IsValidField(tbCadFunSenha.Text))
            {
                MessageBox.Show("Campo Senha obrigatório");
                tbCadFunSenha.Focus();
                return;
            }
            try
            {
                int codEstado;
                int codCidade;

                bool parseOkuf = Int32.TryParse(cbCadFunUf.SelectedValue.ToString(), out codEstado);
                bool parseOkcidade = Int32.TryParse(cbCadFunCidade.SelectedValue.ToString(), out codCidade);

                if (funcionario != null)
                {
                    FuncionarioBUS FuncionarioBUS = new FuncionarioBUS();
                    Funcionario FuncionarioUpdate = new Funcionario();

                    FuncionarioUpdate.CodFunc = funcionario.CodFunc;
                    FuncionarioUpdate.CPF = funcionario.CPF;
                    FuncionarioUpdate.Nome = tbCadFunNome.Text;
                    FuncionarioUpdate.Senha = tbCadFunSenha.Text;
                    FuncionarioUpdate.Tel1 = mkCadFunTel1.Text;
                    FuncionarioUpdate.Cep = mkCadFunCep.Text;
                    FuncionarioUpdate.Rua = tbCadFunEnd.Text;
                    FuncionarioUpdate.Numero = Convert.ToInt32(tbCadFunNum.Text);
                    FuncionarioUpdate.Compl = tbCadFunComplemento.Text;
                    FuncionarioUpdate.Bairro = tbCadFunBairro.Text;
                    FuncionarioUpdate.Cidade = cbCadFunCidade.Text;
                    FuncionarioUpdate.codCidade = codCidade;
                    FuncionarioUpdate.codEstado = codEstado;
                    FuncionarioUpdate.Uf = cbCadFunUf.Text;
                    FuncionarioUpdate.Ativo = rdCadfunAtivo.Checked ? 1 : 0;


                    RetornoBanco retornoBanco = FuncionarioBUS.ProcUpdate(FuncionarioUpdate);

                    MessageBox.Show(retornoBanco.MsgRetorno);

                    if (retornoBanco.IsOk)
                    {
                        Close();
                        isRefreshGrid = true;
                    }
                }
                else
                {

                    FuncionarioBUS FuncionarioBUS = new FuncionarioBUS();
                    Funcionario Funcionario = new Funcionario();

                    Funcionario.Nome = tbCadFunNome.Text;
                    Funcionario.CPF = mkCadFunCpf.Text;
                    Funcionario.Senha = tbCadFunSenha.Text;
                    Funcionario.Tel1 = mkCadFunTel1.Text;
                    Funcionario.Cep = mkCadFunCep.Text;
                    Funcionario.Rua = tbCadFunEnd.Text;
                    Funcionario.Numero = Convert.ToInt32(tbCadFunNum.Text);
                    Funcionario.Compl = tbCadFunComplemento.Text;
                    Funcionario.Bairro = tbCadFunBairro.Text;
                    Funcionario.Cidade = cbCadFunCidade.Text;
                    Funcionario.codCidade = codCidade;
                    Funcionario.codEstado = codEstado;
                    Funcionario.Uf = cbCadFunUf.Text;
                    Funcionario.Ativo = 1;

                    RetornoBanco retornoBanco = FuncionarioBUS.ProcInsert(Funcionario);

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
                    MessageBox.Show("Não foi possível incluir o funcionário > " + ex.Message + ex.StackTrace);
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

        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            tbCadFunSenha.UseSystemPasswordChar = false;
        }
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            tbCadFunSenha.UseSystemPasswordChar = true;
        }
        private void mkCadFunCpf_Leave(object sender, EventArgs e)
        {
            if (Validacao.RemoverCaracteres(mkCadFunCpf.Text).Length > 0)
            {
                if (!Validacao.IsValidCPF(mkCadFunCpf.Text))
                {
                    VisualizarBotaoCpf(false, true);
                    mkCadFunCpf.Focus();
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
        private void cbCadFunUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            CidadeBUS cidadeBUS = new CidadeBUS();

            int codEstado = 0;

            bool parseOkuf = Int32.TryParse(cbCadFunUf.SelectedValue.ToString(), out codEstado);

            cbCadFunCidade.DataSource = cidadeBUS.GetAllCidades(codEstado);
            cbCadFunCidade.ValueMember = "CodCidade";
            cbCadFunCidade.DisplayMember = "Nome";
            cbCadFunCidade.Update();

        }
        public void AlteraBotoes(bool flag)
        {
            tbCadFunNome.Enabled = flag;
            gbCadFunStatus.Enabled = flag;
            mkCadFunCpf.Enabled = flag;
            mkCadFunCep.Enabled = flag;
            cbCadFunUf.Enabled = flag;
            tbCadFunEnd.Enabled = flag;
            tbCadFunNum.Enabled = flag;
            tbCadFunBairro.Enabled = flag;
            cbCadFunCidade.Enabled = flag;
            tbCadFunComplemento.Enabled = flag;
            mkCadFunTel1.Enabled = flag;
            btCadInserir.Enabled = flag;
            btCadLimpar.Enabled = flag;
            btCadFunAlterar.Enabled = !flag;
            tbCadFunSenha.Enabled = flag;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            AlteraBotoes(true);
            rdCadfunAtivo.Enabled = true;
            rdCadFunDesativado.Enabled = true;
            mkCadFunCpf.Enabled = false;
        }
        private void tbCadFunNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}