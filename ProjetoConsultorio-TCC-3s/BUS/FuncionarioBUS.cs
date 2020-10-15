using ProjetoTCC2020.DAO;
using ProjetoTCC2020.Models;
using System.Data;

namespace ProjetoTCC2020.BUS
{
    public class FuncionarioBUS
    {
        private FuncionarioDAO FuncionarioDAO;

        public FuncionarioBUS()
        {
            FuncionarioDAO = new FuncionarioDAO();
        }

        public void Insert(Funcionario Funcionario)
        {
            // Se precisar de alguma validação, faça aqui neste método
            FuncionarioDAO.Insert(Funcionario);
        }

        public RetornoBanco ProcInsert(Funcionario funcionario)
        {
            // Se precisar de alguma validação, faça aqui neste método
            return FuncionarioDAO.Insert(funcionario);
        }

        public RetornoBanco ProcUpdate(Funcionario funcionario)
        {
            // Se precisar de alguma validação, faça aqui neste método
            return FuncionarioDAO.Update(funcionario);
        }

        public Funcionario SearchFuncionario(int CodFunc)
        {
            Funcionario funcionario = new Funcionario();
            funcionario = FuncionarioDAO.Get(CodFunc);

            return funcionario;
        }

        public DataTable SearchAllFuncionario(int AtivoInativo)
        {
            DataTable funcionario = new DataTable();
            funcionario = FuncionarioDAO.SearchAllFuncionario(AtivoInativo);

            return funcionario;
        }

        public DataTable SearchAFuncionarioCPF(string CPF, int AtivoInativo)
        {
            DataTable funcionario = new DataTable();
            funcionario = FuncionarioDAO.SearchAFuncionarioCPF(CPF, AtivoInativo);

            return funcionario;
        }

        public DataTable SearchAFuncionarioName(string Name, int AtivoInativo)
        {
            DataTable funcionario = new DataTable();
            funcionario = FuncionarioDAO.SearchAFuncionarioName(Name, AtivoInativo);

            return funcionario;
        }
    }
}
