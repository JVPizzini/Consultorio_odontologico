using ProjetoTCC2020.DAO;
using ProjetoTCC2020.Models;

namespace ProjetoTCC2020.BUS
{
    class UsuarioBUS
    {
        private UsuarioDAO usuarioDAO;

        public UsuarioBUS()
        {
            usuarioDAO = new UsuarioDAO();
        }

        public Usuario VerificarLogin(string login, string senha)
        {
            Usuario user = new Usuario();
            user = usuarioDAO.VerificarLogin(login, senha);
            if (user.isOK)
            {
                UsuarioSessao.NomeUsuario = user.nomeUsuario;
                UsuarioSessao.UsuarioId = user.codUsuario;
            }

            return user;
        }
    }
}
