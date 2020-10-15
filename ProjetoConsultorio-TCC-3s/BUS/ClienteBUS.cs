using ProjetoTCC2020.DAO;
using ProjetoTCC2020.Models;
using System.Data;

namespace ProjetoTCC2020.BUS
{
    public class ClienteBUS
    {
        private ClienteDAO clienteDAO;

        public ClienteBUS()
        {
            clienteDAO = new ClienteDAO();
        }
        public RetornoBanco ProcInsert(Cliente cliente)
        {
            // Se precisar de alguma validação, faça aqui neste método
            return clienteDAO.Insert(cliente);
        }

        public RetornoBanco ProcUpdate(Cliente cliente)
        {
            // Se precisar de alguma validação, faça aqui neste método
            return clienteDAO.Update(cliente);
        }

        public Cliente SearchCliente(int CodCliente)
        {
            return clienteDAO.Get(CodCliente);
        }

        public DataTable SearchAllClientes(int AtivoInativo)
        {
            return clienteDAO.SearchAllClientes(AtivoInativo);

        }

        public DataTable SearchAClientCPF(string CPF, int AtivoInativo)
        {
            return clienteDAO.SearchAClientCPF(CPF, AtivoInativo);
        }

        public DataTable SearchAClientName(string Name, int AtivoInativo)
        {
            return clienteDAO.SearchAClientName(Name, AtivoInativo);
        }

        public Cliente SearchAClientByCPF(string CPF)
        {
            return clienteDAO.SearchAClientByCPF(CPF);
        }
    }
}
