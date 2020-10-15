using ProjetoTCC2020.DAO;
using ProjetoTCC2020.Models;
using System.Data;

namespace ProjetoTCC2020.BUS
{
    public class ProfissionalBUS
    {
        private ProfissionalDAO ProfissionalDAO;

        public ProfissionalBUS()
        {
            ProfissionalDAO = new ProfissionalDAO();
        }

        public void Insert(Profissional Profissional)
        {
            // Se precisar de alguma validação, faça aqui neste método
            ProfissionalDAO.Insert(Profissional);
        }

        public RetornoBanco ProcInsert(Profissional Profissional)
        {
            // Se precisar de alguma validação, faça aqui neste método
            return ProfissionalDAO.Insert(Profissional);
        }

        public RetornoBanco ProcUpdate(Profissional Profissional)
        {
            // Se precisar de alguma validação, faça aqui neste método
            return ProfissionalDAO.Update(Profissional);
        }

        public Profissional SearchProfissional(int CodPro)
        {
            Profissional profissional = new Profissional();
            profissional = ProfissionalDAO.Get(CodPro);

            return profissional;
        }

        public DataTable SearchAllProfissional(int AtivoInativo = 1)
        {
            DataTable profissional = new DataTable();
            profissional = ProfissionalDAO.SearchAllProfissional(AtivoInativo);

            return profissional;
        }

        public DataTable SearchAProCPF(string CPF, int AtivoInativo)
        {
            DataTable profissional = new DataTable();
            profissional = ProfissionalDAO.SearchAProCPF(CPF, AtivoInativo);

            return profissional;
        }

        public DataTable SearchAProName(string Name, int AtivoInativo)
        {
            DataTable profissional = new DataTable();
            profissional = ProfissionalDAO.SearchAProName(Name, AtivoInativo);

            return profissional;
        }

    }
}
