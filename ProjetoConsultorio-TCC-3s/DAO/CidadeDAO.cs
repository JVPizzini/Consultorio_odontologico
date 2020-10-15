using ProjetoTCC2020.DAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoTCC2020.DAO
{
    public class CidadeDAO
    {
        private DBHelper dbHelper;

        public CidadeDAO()
        {
            dbHelper = new DBHelper();
        }

        public DataTable GetAllCidades(int CodEstado)
        {
            try
            {
                String query = "SELECT CodCidade, Nome FROM Cidade Where CodEstado = @CodEstado";

                return dbHelper.RetornarDataTable(query, new SqlParameter("@CodEstado", CodEstado));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
