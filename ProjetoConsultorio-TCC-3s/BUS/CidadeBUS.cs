using ProjetoTCC2020.DAO;
using System.Data;

namespace ProjetoTCC2020.BUS
{
    class CidadeBUS
    {
        private CidadeDAO cidadeDAO;

        public CidadeBUS()
        {
            cidadeDAO = new CidadeDAO();
        }

        public DataTable GetAllCidades(int CodEstado)
        {
            return cidadeDAO.GetAllCidades(CodEstado);
        }
    }
}
