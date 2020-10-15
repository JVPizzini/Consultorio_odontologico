using ProjetoTCC2020.BUS;
using ProjetoTCC2020.Models;
using System;
using System.Windows.Forms;

namespace ProjetoTCC2020.Serviços
{
    public partial class fmServicos : Form
    {
        Servico servico;
        public bool IsRefreshGrid;

        public fmServicos()
        {
            InitializeComponent();

        }
        bool flag = false;
        public fmServicos(bool flag)
        {
            InitializeComponent();
            this.flag = flag;
        }
        public fmServicos(Servico servico, bool flag = false)
        {
            InitializeComponent();
            this.flag = flag;
            this.servico = servico;

        }



        private void Serviços_Load(object sender, EventArgs e)
        {
            AlteraBotoes(flag);
            if (servico != null)
            {
                tbServNome.Text = servico.Descricao;
            }
        }

        private void gbServDados_Enter(object sender, EventArgs e)
        {

        }

        private void btServInserir_Click(object sender, EventArgs e)
        {
            pnServCadastroCat.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnServCadastroCat.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpar(Controls);
        }

        private void btAgInserir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbServNome.Text))
            {
                MessageBox.Show("Por favor, insira um nome.");
                tbServNome.Focus();
                return;
            }


            try
            {

                ServicosBUS servicosBUS = new ServicosBUS();

                if (servico != null)
                {
                    Servico servicoUpdate = new Servico();
                    servicoUpdate.CodServ = servico.CodServ;
                    servicoUpdate.Descricao = tbServNome.Text;


                    servicosBUS.UpdateServico(servicoUpdate.CodServ, servicoUpdate);

                    MessageBox.Show("Serviço atualizada com sucesso!");
                    IsRefreshGrid = true;
                    Close();
                    
                }
                else
                {
                    Servico servicos = new Servico();
                    servicos.Descricao = tbServNome.Text;
                    servicosBUS.Insert(servicos);

                    MessageBox.Show("Serviço cadastrado com sucesso!");
                    Close();
                    IsRefreshGrid = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível incluir o serviço > " + ex.StackTrace);
            }
        }

        private void fmServicos_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        public void AlteraBotoes(bool flag)
        {
            tbServNome.Enabled = flag;
            btServInserir.Enabled = flag;
            btServLimpar.Enabled = flag;
            btServAlterar.Enabled = !flag;
            btServDelete.Enabled = !flag;

        }

        private void btCadFunAlterar_Click(object sender, EventArgs e)
        {
            AlteraBotoes(true);
        }

        private void btAgDelete_Click(object sender, EventArgs e)
        {
            int id;
            id = servico.CodServ;

            DialogResult result = MessageBox.Show("Desejar realmente remover o serviço?", "Remover", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                try
                {
                    ServicosBUS servicosBUS = new ServicosBUS();
                    Servico servico = this.servico;
                    //servicosBUS.DeleteServico(id);

                    RetornoBanco retornoBanco = servicosBUS.DeleteServico(servico);

                    MessageBox.Show(retornoBanco.MsgRetorno);

                    if (retornoBanco.IsOk)
                    {
                        Close();
                        IsRefreshGrid = true;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Não foi possível incluir o serviço > " + ex.Message);
                }
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
    }
}
