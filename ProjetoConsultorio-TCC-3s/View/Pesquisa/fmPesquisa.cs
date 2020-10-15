using ProjetoTCC2020.BUS;
using ProjetoTCC2020.Cadastro;
using ProjetoTCC2020.Models;
using System;
using System.Windows.Forms;

namespace ProjetoTCC2020.Pesquisa
{
    public partial class fmPesquisa : Form
    {
        
        int CodCliente = 0;
        int CodPro = 0;
        int CodFunc = 0;
        int indexPesq;
        // Atribuir 1 se estiver escolhido Ativo na opção e 0 para Inativo
        int AtivoInativo = 1;
        public fmPesquisa()
        {
            InitializeComponent();
            rbPesqCPF.Checked = true;
            cbPesq.SelectedItem = "Cliente";

        }

        private void btPesNovoCadastro_Click(object sender, EventArgs e)
        {

            CadastroCliente CadastroCliente = new CadastroCliente(true);
            CadastroCliente.ShowDialog();
            if (CadastroCliente.isRefreshGrid)
            {
                GridCLientes();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            fmCadastroProfissional cadastroProfissional = new fmCadastroProfissional(true);
            cadastroProfissional.ShowDialog();
            if (cadastroProfissional.isRefreshGrid)
            {
                GridProfissional();
            }
        }

        private void btPesqCanc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbPesqCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPesqCPF.Checked)
            {
                mkPesqNome.Visible = false;
                mkPesqCpf.Visible = true;
                mkPesqCpf.Clear();
                mkPesqNome.Clear();
            }
        }

        private void rdNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPesqNome.Checked)
            {
                mkPesqCpf.Visible = false;
                mkPesqNome.Visible = true;
                mkPesqNome.Clear();
                mkPesqCpf.Clear();
            }
        }

        private void fmPesquisa_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btPesqCadFunc_Click(object sender, EventArgs e)
        {
            fmCadastroFuncionario CadastroFuncionario = new fmCadastroFuncionario(true);
            CadastroFuncionario.ShowDialog();
            if (CadastroFuncionario.isRefreshGrid)
            {
                GridFuncionario();
            }
        }

        private void gridPesqCadastro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (indexPesq == 0)
            {
                CodCliente = Convert.ToInt32(gridPesqCadastro.Rows[e.RowIndex].Cells[0].Value);

                ClienteBUS clienteBUS = new ClienteBUS();
                Cliente clienteRecebido = new Cliente();
                clienteRecebido = clienteBUS.SearchCliente(CodCliente);

                CadastroCliente cliente = new CadastroCliente(clienteRecebido, flag: false);
                cliente.ShowDialog();
                if (cliente.isRefreshGrid)
                {
                    GridCLientes();
                }
            }
            else if (indexPesq == 1)
            {
                CodPro = Convert.ToInt32(gridPesqCadastro.Rows[e.RowIndex].Cells[0].Value);

                ProfissionalBUS profissionalBUS = new ProfissionalBUS();
                Profissional profissionalRecebido = new Profissional();
                profissionalRecebido = profissionalBUS.SearchProfissional(CodPro);

                fmCadastroProfissional profissional = new fmCadastroProfissional(profissionalRecebido, flag: false);
                profissional.ShowDialog();
                if (profissional.isRefreshGrid)
                {
                    GridProfissional();
                    
                }
            }
            else if (indexPesq == 2)
            {
                CodFunc = Convert.ToInt32(gridPesqCadastro.Rows[e.RowIndex].Cells[0].Value);

                FuncionarioBUS funcionarioBUS = new FuncionarioBUS();
                Funcionario funcionarioRecebido = new Funcionario();
                funcionarioRecebido = funcionarioBUS.SearchFuncionario(CodFunc);

                fmCadastroFuncionario funcionario = new fmCadastroFuncionario(funcionarioRecebido, flag: false);
                funcionario.ShowDialog();
                if (funcionario.isRefreshGrid)
                {
                    GridFuncionario();

                }
            }
        }
        private void btPesqBuscar_Click(object sender, EventArgs e)
        {

            if (cbPesq.SelectedIndex == 0)
            {
                indexPesq = 0;
                if ((String.IsNullOrEmpty(mkPesqCpf.Text) || mkPesqCpf.Text == "   .   .   -") && String.IsNullOrEmpty(mkPesqNome.Text))
                {
                    GridCLientes();
                }
                else if ((!String.IsNullOrEmpty(mkPesqCpf.Text) || mkPesqCpf.Text != "   .   .   -") && String.IsNullOrEmpty(mkPesqNome.Text))
                {
                    // BUSCAR POR CPF
                    BuscarClienteCPF();
                }
                else if ((String.IsNullOrEmpty(mkPesqCpf.Text) || mkPesqCpf.Text == "   .   .   -") && !String.IsNullOrEmpty(mkPesqNome.Text))
                {
                    // BUSCAR POR NOME
                    BuscarClienteNome();
                }
            }



            if (cbPesq.SelectedIndex == 1)
            {
                indexPesq = 1;
                if ((String.IsNullOrEmpty(mkPesqCpf.Text) || mkPesqCpf.Text == "   .   .   -") && String.IsNullOrEmpty(mkPesqNome.Text))
                {
                    GridProfissional();
                }
                else if ((!String.IsNullOrEmpty(mkPesqCpf.Text) || mkPesqCpf.Text != "   .   .   -") && String.IsNullOrEmpty(mkPesqNome.Text))
                {
                    // BUSCAR POR CPF
                    BuscarProfissionalCPF();
                }
                else if ((String.IsNullOrEmpty(mkPesqCpf.Text) || mkPesqCpf.Text == "   .   .   -") && !String.IsNullOrEmpty(mkPesqNome.Text))
                {
                    // BUSCAR POR NOME
                    BuscarProfissionalNome();
                }
            }


            if (cbPesq.SelectedIndex == 2)
            {
                indexPesq = 2;
                if ((String.IsNullOrEmpty(mkPesqCpf.Text) || mkPesqCpf.Text == "   .   .   -") && String.IsNullOrEmpty(mkPesqNome.Text))
                {
                    GridFuncionario();
                }
                else if ((!String.IsNullOrEmpty(mkPesqCpf.Text) || mkPesqCpf.Text != "   .   .   -") && String.IsNullOrEmpty(mkPesqNome.Text))
                {
                    // BUSCAR POR CPF
                    BuscarFuncionarioCPF();
                }
                else if ((String.IsNullOrEmpty(mkPesqCpf.Text) || mkPesqCpf.Text == "   .   .   -") && !String.IsNullOrEmpty(mkPesqNome.Text))
                {
                    // BUSCAR POR NOME
                    BuscarFuncionarioNome();
                }
            }

        }
        // BUSCAS DOS CLIENTES
        private void BuscarClienteCPF()
        {
            string CPF = mkPesqCpf.Text;

            ClienteBUS clienteBUS = new ClienteBUS();
            gridPesqCadastro.DataSource = clienteBUS.SearchAClientCPF(CPF, AtivoInativo);
            gridPesqCadastro.Refresh();
        }
        private void BuscarClienteNome()
        {
            string Name = mkPesqNome.Text;

            ClienteBUS clienteBUS = new ClienteBUS();
            gridPesqCadastro.DataSource = clienteBUS.SearchAClientName(Name, AtivoInativo);
            gridPesqCadastro.Refresh();
        }
        private void GridCLientes()
        {
            ClienteBUS clienteBUS = new ClienteBUS();
            gridPesqCadastro.DataSource = clienteBUS.SearchAllClientes(AtivoInativo);
            CriarTabela();
            gridPesqCadastro.Refresh();
        }
        //BUSCAS DO PROFISSIONAL
        private void GridProfissional()
        {
            ProfissionalBUS profissionalBUS = new ProfissionalBUS();
            gridPesqCadastro.DataSource = profissionalBUS.SearchAllProfissional(AtivoInativo);
            CriarTabela();
            gridPesqCadastro.Refresh();
        }
        private void BuscarProfissionalCPF()
        {
            string CPF = mkPesqCpf.Text;

            ProfissionalBUS profissionalBUS = new ProfissionalBUS();
            gridPesqCadastro.DataSource = profissionalBUS.SearchAProCPF(CPF, AtivoInativo);
            gridPesqCadastro.Refresh();
        }
        private void BuscarProfissionalNome()
        {
            string Name = mkPesqNome.Text;

            ProfissionalBUS profissionalBUS = new ProfissionalBUS();
            gridPesqCadastro.DataSource = profissionalBUS.SearchAProName(Name, AtivoInativo);
            gridPesqCadastro.Refresh();
        }
        // BUSCAS DO FUNCIONARIO
        private void GridFuncionario()
        {
            FuncionarioBUS funcionarioBUS = new FuncionarioBUS();
            gridPesqCadastro.DataSource = funcionarioBUS.SearchAllFuncionario(AtivoInativo);
            CriarTabela();
            gridPesqCadastro.Refresh();
        }
        private void BuscarFuncionarioCPF()
        {
            string CPF = mkPesqCpf.Text;

            FuncionarioBUS funcionarioBUS = new FuncionarioBUS();
            gridPesqCadastro.DataSource = funcionarioBUS.SearchAFuncionarioCPF(CPF, AtivoInativo);
            gridPesqCadastro.Refresh();
        }
        private void BuscarFuncionarioNome()
        {
            string Name = mkPesqNome.Text;

            FuncionarioBUS funcionarioBUS = new FuncionarioBUS();
            gridPesqCadastro.DataSource = funcionarioBUS.SearchAFuncionarioName(Name, AtivoInativo);
            gridPesqCadastro.Refresh();
        }
        private void CriarTabela()
        {
            foreach (DataGridViewColumn column in gridPesqCadastro.Columns)
            {
                if (column.Index == 0)
                {
                    column.Width = 70;
                }

                if (column.Index == 1)
                {
                    column.Width = 560;
                }

                if (column.Index == 2)
                {
                    column.Width = 100;
                }

                gridPesqCadastro.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gridPesqCadastro.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                gridPesqCadastro.Refresh();

            }
        }

        private void cbInativo_CheckedChanged(object sender, EventArgs e)
        {
            AtivoInativo = cbInativo.Checked ? 0 : 1;
        }
    }
}

