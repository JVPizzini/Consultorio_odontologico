using ProjetoTCC2020.DAO;
using ProjetoTCC2020.Models;
using System.Data;

namespace ProjetoTCC2020.BUS
{
    public class ServicosBUS
    {
        private ServicosDAO servicosDAO;

        public ServicosBUS()
        {
            servicosDAO = new ServicosDAO();
        }

        public void Insert(Servico servicos)
        {
            servicosDAO.Insert(servicos);
        }


        public Servico SearchServico(int CodServ)
        {
            Servico servico = new Servico();
            servico = servicosDAO.SearchServico(CodServ);

            return servico;
        }

        public void UpdateServico(int CodServ, Servico servico)
        {
            servicosDAO.Update(CodServ, servico);
        }

        public DataTable SearchAService(string Descricao)
        {
            DataTable servico = new DataTable();
            servico = servicosDAO.SearchAService(Descricao);

            return servico;
        }

        public DataTable SearchAllService()
        {
            DataTable servico = new DataTable();
            servico = servicosDAO.SearchAllService();

            return servico;
        }
        public RetornoBanco DeleteServico(Servico servico)
        {
            return servicosDAO.DeleteServico(servico);
        }
    }
}
