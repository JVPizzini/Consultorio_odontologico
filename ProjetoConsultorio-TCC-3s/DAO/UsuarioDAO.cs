using ProjetoTCC2020.DAL;
using ProjetoTCC2020.Models;
using System;
using System.Data.SqlClient;

namespace ProjetoTCC2020.DAO
{
    class UsuarioDAO
    {
        private DBHelper dbHelper;

        public UsuarioDAO()
        {
            dbHelper = new DBHelper();
        }

        public Usuario VerificarLogin(string login, string senha)
        {
            Usuario user = new Usuario();
            user = dbHelper.VerificarLogin("ProcVerificarLogin",
                new SqlParameter("@Login", login),
                new SqlParameter("@Senha", senha));

            return user;
        }
        
    }
}
