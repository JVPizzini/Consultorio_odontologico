using ProjetoTCC2020.DAL;
using System;
using System.Data;

namespace ProjetoTCC2020.DAO
{
    public class EstadoDAO
    {
        private DBHelper dbHelper;

        public EstadoDAO()
        {
            dbHelper = new DBHelper();
        }

        public DataTable GetAllEstados()
        {
            try
            {
                String query = "SELECT CodEstado, UF FROM Estado";

                return dbHelper.RetornarDataTable(query);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
