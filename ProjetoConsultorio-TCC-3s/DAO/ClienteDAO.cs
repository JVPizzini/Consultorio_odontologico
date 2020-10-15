using ProjetoTCC2020.DAL;
using ProjetoTCC2020.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace ProjetoTCC2020.DAO
{
    class ClienteDAO : IDataAccessObject<Cliente>
    {

        private DBHelper dbHelper;

        public ClienteDAO()
        {
            dbHelper = new DBHelper();
        }

        public Cliente Get(int CodCliente)
        {
            try
            {
                Cliente cliente = new Cliente();

                SqlDataReader registro = dbHelper.RetornarDataReader("Select * From Clientes Where CodCliente = " + CodCliente);

                if (registro.HasRows)
                {
                    registro.Read();
                    cliente.CodCliente = Convert.ToInt32(registro["CodCliente"]);
                    cliente.Nome = Convert.ToString(registro["Nome"]);
                    cliente.CPF = Convert.ToString(registro["CPF"]);
                    cliente.DtNasc = Convert.ToDateTime(registro["Nascimento"]);
                    cliente.Tel1 = Convert.ToString(registro["Tel1"]);
                    cliente.Tel2 = Convert.ToString(registro["Tel2"]);
                    cliente.Cep = Convert.ToString(registro["CEP"]);
                    cliente.Rua = Convert.ToString(registro["Rua"]);
                    cliente.Numero = Convert.ToInt32(registro["Numero"]);
                    cliente.Compl = Convert.ToString(registro["Complemento"]);
                    cliente.Bairro = Convert.ToString(registro["Bairro"]);
                    cliente.codCidade = Convert.ToInt32(registro["CodCidade"]);
                    cliente.Cidade = Convert.ToString(registro["Cidade"]);
                    cliente.codEstado = Convert.ToInt32(registro["CodEstado"]);
                    cliente.Uf = Convert.ToString(registro["Estado"]);
                    cliente.Email = Convert.ToString(registro["Email"]);
                    cliente.Obs = Convert.ToString(registro["Observacao"]);
                    cliente.Ativo = Convert.ToInt32(registro["Ativo"]);
                }
                return cliente;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public RetornoBanco Insert(Cliente obj)
        {

            try
            {
                string dtNasc = obj.DtNasc.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

                return dbHelper.ExecuteProcWhitMsg("ProcInserirCliente",
                new SqlParameter("@Insert", 1),
                new SqlParameter("@Nome", obj.Nome),
                new SqlParameter("@CPF", obj.CPF),
                new SqlParameter("@Nascimento", dtNasc),
                new SqlParameter("@Tel1", obj.Tel1),
                new SqlParameter("@Tel2", obj.Tel2),
                new SqlParameter("@CEP", obj.Cep),
                new SqlParameter("@Rua", obj.Rua),
                new SqlParameter("@Numero", obj.Numero),
                new SqlParameter("@Complemento", obj.Compl),
                new SqlParameter("@Bairro", obj.Bairro),
                new SqlParameter("@CodCidade", obj.codCidade),
                new SqlParameter("@CodEstado", obj.codEstado),
                new SqlParameter("@Email", obj.Email),
                new SqlParameter("@Observacao", obj.Obs),
                new SqlParameter("@Ativo", 1));

            }
            catch (Exception)
            {
                throw;
            }
        }
        public RetornoBanco Update(Cliente obj)
        {
            try
            {
                string dtNasc = obj.DtNasc.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

                return dbHelper.ExecuteProcWhitMsg("ProcInserirCliente",
                new SqlParameter("@Update", 1),
                new SqlParameter("@CodCliente", obj.CodCliente),
                new SqlParameter("@Nome", obj.Nome),
                new SqlParameter("@Nascimento", dtNasc),
                new SqlParameter("@Tel1", obj.Tel1),
                new SqlParameter("@Tel2", obj.Tel2),
                new SqlParameter("@CEP", obj.Cep),
                new SqlParameter("@Rua", obj.Rua),
                new SqlParameter("@Numero", obj.Numero),
                new SqlParameter("@Complemento", obj.Compl),
                new SqlParameter("@Bairro", obj.Bairro),
                new SqlParameter("@CodCidade", obj.codCidade),
                new SqlParameter("@CodEstado", obj.codEstado),
                new SqlParameter("@Email", obj.Email),
                new SqlParameter("@Observacao", obj.Obs),
                new SqlParameter("@Ativo", obj.Ativo));
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable SearchAllClientes(int AtivoInativo)
        {
            try
            {
                return dbHelper.RetornarDataTable("Select CodCliente Código, Nome, CPF From Clientes Where Ativo = " + AtivoInativo);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable SearchAClientCPF(string CPF, int AtivoInativo)
        {
            Servico buscarCPF = new Servico();
            try
            {
                DataTable registro = dbHelper.RetornarDataTable("Select CodCliente Código, Nome, CPF From Clientes Where CPF Like '%" + CPF + "%' and Ativo = " + AtivoInativo);
                return registro;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Cliente SearchAClientByCPF(string CPF)
        {
            try
            {
                Cliente cliente = new Cliente();

                SqlDataReader registro = dbHelper.RetornarDataReader("Select CodCliente Código, Nome From Clientes Where CPF Like '%" + CPF + "%'and Ativo = 1");
                if (registro.HasRows)
                {
                    registro.Read();
                    cliente.CodCliente = Convert.ToInt32(registro["Código"]);
                    cliente.Nome = Convert.ToString(registro["Nome"]);
                }
                dbHelper.Close();
                return cliente;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable SearchAClientName(string Name, int AtivoInativo)
        {
            Servico buscarNome = new Servico();
            try
            {
                DataTable registro = dbHelper.RetornarDataTable("Select CodCliente Código, Nome, CPF From Clientes Where Nome Like '%" + Name + "%' and Ativo = " + AtivoInativo);
                return registro;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
