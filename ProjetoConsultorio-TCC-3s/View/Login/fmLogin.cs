using ProjetoTCC2020.BUS;
using ProjetoTCC2020.Models;
using System;
using System.Windows.Forms;

namespace ProjetoTCC2020.View.Login
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void fmLogin_FormClosing(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Login = mkLogin.Text;
            string Senha = tbSenha.Text;
            string LoginV = Login.Trim();
            string SenhaV = Senha.Trim();

            bool validaCampoLogin = Validacao.IsValidField(LoginV);
            bool validaCampoSenha = Validacao.IsValidField(SenhaV);

            if (!validaCampoLogin)
            {
                MessageBox.Show("É obrigatório informar o login corretamente");
                return;
            }
            if (!validaCampoSenha)
            {
                MessageBox.Show("É obrigatório informar a senha");
                return;
            }

            UsuarioBUS usuarioBUS = new UsuarioBUS();
            Usuario user = usuarioBUS.VerificarLogin(LoginV, SenhaV);

            if (!user.isOK)
            {
                MessageBox.Show(user.MsgRetorno);
                return;
            }
            Visible = false;
            Consultorio consultorio = new Consultorio();
            consultorio.ShowDialog();

        }
    }
}
