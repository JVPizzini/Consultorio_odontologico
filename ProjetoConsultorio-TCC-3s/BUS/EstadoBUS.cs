using ProjetoTCC2020.DAO;
using System.Data;

namespace ProjetoTCC2020.BUS
{
    class EstadoBUS
    {
        private EstadoDAO estadoDAO;

        public EstadoBUS()
        {
            estadoDAO = new EstadoDAO();
        }

        public DataTable GetAllEstados()
        {
            return estadoDAO.GetAllEstados();
        }
    }
}
