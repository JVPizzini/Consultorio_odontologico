using ProjetoTCC2020.DAL;
using ProjetoTCC2020.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoTCC2020.DAO
{
    class ServicosDAO
    {
        private DBHelper dBHelper;

        public ServicosDAO()
        {
            dBHelper = new DBHelper();
        }

        public RetornoBanco DeleteServico(Servico servico)
        {
            try
            {
                return dBHelper.ExecuteProcWhitMsg("ProcRemoverServico",
                    new SqlParameter("@CodServico", servico.CodServ));
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Insert(Servico servicos)
        {
            try
            {
                dBHelper.ExecuteNonQuery("Insert into Servicos (Descricao) values(@Descricao)",
                    new SqlParameter("@Descricao", servicos.Descricao));
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable SearchAllService()
        {
            Servico buscarTodosServico = new Servico();
            try
            {
                DataTable registro = dBHelper.RetornarDataTable("Select CodServico Código, Descricao From Servicos (Nolock)");

                return registro;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable SearchAService(string servico)
        {
            Servico buscarBervico = new Servico();
            try
            {
                DataTable registro = dBHelper.RetornarDataTable("Select CodServico Código, Descricao From Servicos Where Descricao Like '%" + servico + "%'");

                return registro;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public Servico SearchServico(int CodServ)
        {

            try
            {
                Servico servico = new Servico();

                SqlDataReader registro = dBHelper.RetornarDataReader("Select * From Servicos Where CodServico = " + CodServ);

                if (registro.HasRows)
                {
                    registro.Read();
                    servico.CodServ = Convert.ToInt32(registro["CodServico"]);
                    servico.Descricao = Convert.ToString(registro["Descricao"]);
                }
                dBHelper.Close();

                return servico;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Update(int id, Servico obj)
        {
            dBHelper.ExecuteNonQuery("Update Servicos Set Descricao = @Descricao Where CodServico = @CodServico",
            new SqlParameter("@CodServico", id),
            new SqlParameter("@Descricao", obj.Descricao));

        }
    }
}