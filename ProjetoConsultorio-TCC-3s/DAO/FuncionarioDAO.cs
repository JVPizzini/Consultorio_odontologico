using ProjetoTCC2020.DAL;
using ProjetoTCC2020.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoTCC2020.DAO
{

    class FuncionarioDAO : IDataAccessObject<Funcionario>
    {

        private DBHelper dbHelper;

        public FuncionarioDAO()
        {
            dbHelper = new DBHelper();
        }

        public Funcionario Get(int CodFunc)
        {

            try
            {
                Funcionario funcionario = new Funcionario();

                SqlDataReader registro = dbHelper.RetornarDataReader("Select * From Funcionarios Where Codfunc = " + CodFunc);

                if (registro.HasRows)
                {
                    registro.Read();
                    funcionario.CodFunc = Convert.ToInt32(registro["CodFunc"]);
                    funcionario.Nome = Convert.ToString(registro["Nome"]);
                    funcionario.CPF = Convert.ToString(registro["CPF"]);
                    funcionario.Senha = Convert.ToString(registro["Senha"]);
                    funcionario.Tel1 = Convert.ToString(registro["Tel1"]);
                    funcionario.Cep = Convert.ToString(registro["CEP"]);
                    funcionario.Rua = Convert.ToString(registro["Rua"]);
                    funcionario.Numero = Convert.ToInt32(registro["Numero"]);
                    funcionario.Compl = Convert.ToString(registro["Complemento"]);
                    funcionario.Bairro = Convert.ToString(registro["Bairro"]);
                    funcionario.codCidade = Convert.ToInt32(registro["CodCidade"]);
                    funcionario.Cidade = Convert.ToString(registro["Cidade"]);
                    funcionario.codEstado = Convert.ToInt32(registro["CodEstado"]);
                    funcionario.Uf = Convert.ToString(registro["Estado"]);
                    funcionario.Ativo = Convert.ToInt32(registro["Ativo"]);
                }
                return funcionario;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public RetornoBanco Insert(Funcionario obj)
        {

            try
            {
                return dbHelper.ExecuteProcWhitMsg("ProcInserirFuncionario",
                new SqlParameter("@Insert", 1),
                new SqlParameter("@Nome", obj.Nome),
                new SqlParameter("@CPF", obj.CPF),
                new SqlParameter("@Senha", obj.Senha),
                new SqlParameter("@Tel1", obj.Tel1),
                new SqlParameter("@CEP", obj.Cep),
                new SqlParameter("@Rua", obj.Rua),
                new SqlParameter("@Numero", obj.Numero),
                new SqlParameter("@Complemento", obj.Compl),
                new SqlParameter("@Bairro", obj.Bairro),
                new SqlParameter("@CodCidade", obj.codCidade),
                new SqlParameter("@CodEstado", obj.codEstado),
                new SqlParameter("@Ativo", 1));
            }
            catch (Exception)
            {
                throw;
            }
        }
        public RetornoBanco Update(Funcionario obj)
        {

            try
            {
                return dbHelper.ExecuteProcWhitMsg("ProcInserirFuncionario",
                new SqlParameter("@Update", 1),
                new SqlParameter("@CPF", obj.CPF),
                new SqlParameter("@CodFunc", obj.CodFunc),
                new SqlParameter("@Nome", obj.Nome),
                new SqlParameter("@Senha", obj.Senha),
                new SqlParameter("@Tel1", obj.Tel1),
                new SqlParameter("@CEP", obj.Cep),
                new SqlParameter("@Rua", obj.Rua),
                new SqlParameter("@Numero", obj.Numero),
                new SqlParameter("@Complemento", obj.Compl),
                new SqlParameter("@Bairro", obj.Bairro),
                new SqlParameter("@CodCidade", obj.codCidade),
                new SqlParameter("@CodEstado", obj.codEstado),
                new SqlParameter("@Ativo", obj.Ativo));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable SearchAllFuncionario(int AtivoInativo)
        {
            Funcionario funcionario = new Funcionario();
            try
            {
                return dbHelper.RetornarDataTable("Select CodFunc Código, Nome, CPF From Funcionarios Where Ativo = " + AtivoInativo);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable SearchAFuncionarioCPF(string CPF, int AtivoInativo)
        {
            Servico buscarCPF = new Servico();
            try
            {
                return dbHelper.RetornarDataTable("Select CodFunc Código, Nome, CPF From Funcionarios Where CPF Like '%" + CPF + "%' and Ativo = " + AtivoInativo);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable SearchAFuncionarioName(string Name, int AtivoInativo)
        {
            Servico buscarNome = new Servico();
            try
            {
                return dbHelper.RetornarDataTable("Select CodFunc Código, Nome, CPF From Funcionarios Where Nome Like '%" + Name + "%' and Ativo = " + AtivoInativo);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
