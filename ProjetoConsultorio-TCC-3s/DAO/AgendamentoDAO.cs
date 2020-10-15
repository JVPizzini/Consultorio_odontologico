using ProjetoTCC2020.DAL;
using ProjetoTCC2020.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace ProjetoTCC2020.DAO
{

    class AgendamentoDAO : IDataAccessObject<AgendamentoModel>
    {

        private DBHelper dbHelper;

        public AgendamentoDAO()
        {
            dbHelper = new DBHelper();
        }
        public AgendamentoModel Get(int CodConsulta)
        {
            try
            {
                AgendamentoModel agendamentoModel = new AgendamentoModel();

                SqlDataReader registro = dbHelper.RetornarDataReader("Select  Clientes.CodCliente, Clientes.Nome NomeCli, Consultas.* From Consultas (Nolock)" +
                                                                     " Inner Join Clientes (Nolock) On Clientes.CodCLiente = Consultas.CodCliente" +
                                                                     " Where CodConsulta = " + CodConsulta);

                if (registro.HasRows)
                {
                    registro.Read();
                    agendamentoModel.CodAgendamento = Convert.ToInt32(registro["CodConsulta"]);
                    agendamentoModel.CodFunc = Convert.ToInt32(registro["CodFuncInc"]);
                    agendamentoModel.CodCli = Convert.ToInt32(registro["CodCliente"]);
                    agendamentoModel.NomeCli = Convert.ToString(registro["NomeCli"]);
                    agendamentoModel.CodDoc = Convert.ToInt32(registro["CodProfis"]);
                    agendamentoModel.CodServ = Convert.ToInt32(registro["CodServico"]);
                    agendamentoModel.CodHrIni = Convert.ToInt32(registro["CodHorarioIni"]);
                    agendamentoModel.CodHrFinal = Convert.ToInt32(registro["CodHorarioFim"]);
                    agendamentoModel.DtConsulta = Convert.ToDateTime(registro["Data"]);
                    agendamentoModel.DtInclusao = Convert.ToDateTime(registro["DtInclusao"]);
                    agendamentoModel.StatusConsulta = Convert.ToChar(registro["Status"]);

                }
                return agendamentoModel;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public RetornoBanco Insert(AgendamentoModel agendamento)
        {
            try
            {
                string dtConsulta = agendamento.DtConsulta.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

                return dbHelper.ExecuteProcWhitMsg("ProcInserirConsulta",
                                            new SqlParameter("@Insert", 1),
                                            new SqlParameter("@CodProfis", agendamento.CodDoc),
                                            new SqlParameter("@CodCliente", agendamento.CodCli),
                                            new SqlParameter("@CodServico", agendamento.CodServ),
                                            new SqlParameter("@Data", dtConsulta),
                                            new SqlParameter("@CodHorarioIni", agendamento.CodHrIni),
                                            new SqlParameter("@CodHorarioFim", agendamento.CodHrFinal),
                                            new SqlParameter("@CodFunc", agendamento.CodFunc),
                                            new SqlParameter("@Status", agendamento.StatusConsulta));
            }
            catch (Exception)
            {

                throw;
            }
        }
        public RetornoBanco Update(AgendamentoModel agendamentoUpdate)
        {
            try
            {
                string dtConsulta = agendamentoUpdate.DtConsulta.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

                if(agendamentoUpdate.StatusConsulta == 'C')
                {
                    return dbHelper.ExecuteProcWhitMsg("ProcInserirConsulta",
                                            new SqlParameter("@Update", 1),
                                            new SqlParameter("@CodConsulta", agendamentoUpdate.CodAgendamento),
                                            new SqlParameter("@CodProfis", agendamentoUpdate.CodDoc),
                                            new SqlParameter("@CodCliente", agendamentoUpdate.CodCli),
                                            new SqlParameter("@CodServico", agendamentoUpdate.CodServ),
                                            new SqlParameter("@Data", dtConsulta),
                                            new SqlParameter("@CodHorarioIni", agendamentoUpdate.CodHrIni),
                                            new SqlParameter("@CodHorarioFim", agendamentoUpdate.CodHrFinal),
                                            new SqlParameter("@CodFunc", agendamentoUpdate.CodFunc),
                                            new SqlParameter("@Status", agendamentoUpdate.StatusConsulta),
                                            new SqlParameter("@Cancelamento", 1),
                                            new SqlParameter("@MotivoCanc", agendamentoUpdate.MotivoCanc));
                }
                else
                {
                    return dbHelper.ExecuteProcWhitMsg("ProcInserirConsulta",
                                            new SqlParameter("@Update", 1),
                                            new SqlParameter("@CodConsulta", agendamentoUpdate.CodAgendamento),
                                            new SqlParameter("@CodProfis", agendamentoUpdate.CodDoc),
                                            new SqlParameter("@CodCliente", agendamentoUpdate.CodCli),
                                            new SqlParameter("@CodServico", agendamentoUpdate.CodServ),
                                            new SqlParameter("@Data", dtConsulta),
                                            new SqlParameter("@CodHorarioIni", agendamentoUpdate.CodHrIni),
                                            new SqlParameter("@CodHorarioFim", agendamentoUpdate.CodHrFinal),
                                            new SqlParameter("@CodFunc", agendamentoUpdate.CodFunc),
                                            new SqlParameter("@Status", agendamentoUpdate.StatusConsulta));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable SearchAllStartTimes(DateTime DtConsulta)
        {
            try
            {
                string dtConsulta = DtConsulta.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                return dbHelper.RetornarDataTableProc("ProcHorarioInicialDisponivel",
                                                       new SqlParameter("@Insert", 1),
                                                       new SqlParameter("@Data", dtConsulta));
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable SearchAllStartTimesUpdate(int codConsulta, DateTime DtConsulta)
        {
            try
            {
                return dbHelper.RetornarDataTableProc("ProcHorarioInicialDisponivel",
                                                    new SqlParameter("@Update", 1),
                                                    new SqlParameter("@CodConsulta", codConsulta),
                                                    new SqlParameter("@Data", DtConsulta.Date));
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable SearchAllEndTimes(DateTime DtConsulta, int HorarioIni)
        {
            try
            {
                return dbHelper.RetornarDataTableProc("ProcHorarioFinalDisponivel",
                                   new SqlParameter("@Data", DtConsulta.Date),
                                   new SqlParameter("@HoraIni", HorarioIni));
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable SearchAllConsultations(string DataSelecionada)
        {
            try
            {
                return dbHelper.RetornarDataTableProc("ProcGridData",
                    new SqlParameter("@Data", DataSelecionada));
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataTable SearchReport(int indexConsulta, string DataIni, string DataFim)
        {
            try
            {
                return dbHelper.RetornarDataTableProc("ProcRelatorio",
                                                   new SqlParameter("@indexConsulta", indexConsulta),
                                                   new SqlParameter("@dtIni", DataIni),
                                                   new SqlParameter("@dtFim", DataFim));
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable SearchQuery(string DataIni, string DataFim)
        {
            try
            {
                return dbHelper.RetornarDataTableProc("ProcBuscarAgendamento",
                                                   new SqlParameter("@dtIni", DataIni),
                                                   new SqlParameter("@dtFim", DataFim));
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
