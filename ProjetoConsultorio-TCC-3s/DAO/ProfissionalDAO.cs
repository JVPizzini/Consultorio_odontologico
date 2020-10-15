using ProjetoTCC2020.DAL;
using ProjetoTCC2020.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace ProjetoTCC2020.DAO
{
    class ProfissionalDAO : IDataAccessObject<Profissional>
    {

        private DBHelper dbHelper;

        public ProfissionalDAO()
        {
            dbHelper = new DBHelper();
        }

        public Profissional Get(int CodPro)
        {
            try
            {
                Profissional profissional = new Profissional();

                SqlDataReader registro = dbHelper.RetornarDataReader("Select * From Profissionais Where CodProfis = " + CodPro);

                if (registro.HasRows)
                {
                    registro.Read();
                    profissional.CodPro = Convert.ToInt32(registro["CodProfis"]);
                    profissional.CRO = Convert.ToString(registro["CRO"]);
                    profissional.Nome = Convert.ToString(registro["Nome"]);
                    profissional.CPF = Convert.ToString(registro["CPF"]);
                    profissional.DtNasc = Convert.ToDateTime(registro["Nascimento"]);
                    profissional.Tel1 = Convert.ToString(registro["Tel1"]);
                    profissional.Tel2 = Convert.ToString(registro["Tel2"]);
                    profissional.Cep = Convert.ToString(registro["CEP"]);
                    profissional.Rua = Convert.ToString(registro["Rua"]);
                    profissional.Numero = Convert.ToInt32(registro["Numero"]);
                    profissional.Compl = Convert.ToString(registro["Complemento"]);
                    profissional.Bairro = Convert.ToString(registro["Bairro"]);
                    profissional.codCidade = Convert.ToInt32(registro["CodCidade"]);
                    profissional.Cidade = Convert.ToString(registro["Cidade"]);
                    profissional.codEstado = Convert.ToInt32(registro["CodEstado"]);
                    profissional.Uf = Convert.ToString(registro["Estado"]);
                    profissional.Email = Convert.ToString(registro["Email"]);
                    profissional.Obs = Convert.ToString(registro["Observacao"]);
                    profissional.Ativo = Convert.ToInt32(registro["Ativo"]);
                }
                return profissional;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public RetornoBanco Insert(Profissional obj)
        {

            try
            {
                string DtNasc = obj.DtNasc.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

                return dbHelper.ExecuteProcWhitMsg("ProcInserirProfissional",
                new SqlParameter("@Insert", 1),
                new SqlParameter("@CRO", obj.CRO),
                new SqlParameter("@Nome", obj.Nome),
                new SqlParameter("@CPF", obj.CPF),
                new SqlParameter("@Nascimento", DtNasc),
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
        public RetornoBanco Update(Profissional obj)
        {
            try
            {
                string DtNasc = obj.DtNasc.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

                return dbHelper.ExecuteProcWhitMsg("ProcInserirProfissional",
                new SqlParameter("@Update", 1),
                new SqlParameter("@CRO", obj.CRO),
                new SqlParameter("@CodProfis", obj.CodPro),
                new SqlParameter("@Nome", obj.Nome),
                new SqlParameter("@Nascimento", DtNasc),
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
        public DataTable SearchAllProfissional(int AtivoInativo)
        {
            Profissional profissional = new Profissional();
            try
            {
                return dbHelper.RetornarDataTable("Select CodProfis Código, Nome, CPF From Profissionais Where Ativo = " + AtivoInativo);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable SearchAProCPF(string CPF, int AtivoInativo)
        {
            Servico buscarCPF = new Servico();
            try
            {
                DataTable registro = dbHelper.RetornarDataTable("Select CodProfis Código, Nome, CPF From Profissionais Where CPF Like '%" + CPF + "%' and Ativo = " + AtivoInativo);
                return registro;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable SearchAProName(string Name, int AtivoInativo)
        {
            Servico buscarNome = new Servico();
            try
            {
                DataTable registro = dbHelper.RetornarDataTable("Select CodProfis Código, Nome, CPF From Profissionais Where Nome Like '%" + Name + "%' and Ativo = " + AtivoInativo);
                return registro;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
