using ProjetoTCC2020.DAO;
using ProjetoTCC2020.Models;
using System;
using System.Data;

namespace ProjetoTCC2020.BUS
{
    public class AgendamentoBUS
    {
        //private FuncionarioDAO FuncionarioDAO;
        private AgendamentoDAO agendamentoDAO;

        public AgendamentoBUS()
        {
            agendamentoDAO = new AgendamentoDAO();
        }

        public DataTable SearchAllStartTimes(DateTime DtConsulta)
        {
            try
            {
                DataTable HorarioInico = new DataTable();
                HorarioInico = agendamentoDAO.SearchAllStartTimes(DtConsulta);

                return HorarioInico;
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
                DataTable HorarioInico = new DataTable();
                HorarioInico = agendamentoDAO.SearchAllStartTimesUpdate(codConsulta, DtConsulta);

                return HorarioInico;
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
                DataTable horariosFinais = new DataTable();
                horariosFinais = agendamentoDAO.SearchAllEndTimes(DtConsulta, HorarioIni);

                return horariosFinais;
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
                DataTable agendamento = new DataTable();
                agendamento = agendamentoDAO.SearchAllConsultations(DataSelecionada);
                return agendamento;
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
                return agendamentoDAO.Insert(agendamento);
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
                return agendamentoDAO.Update(agendamentoUpdate);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public AgendamentoModel SearchAgendamento(int CodConsulta)
        {
            try
            {
                return agendamentoDAO.Get(CodConsulta);
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
                DataTable relatorio = new DataTable();
                relatorio = agendamentoDAO.SearchReport(indexConsulta, DataIni, DataFim);

                return relatorio;
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
                DataTable Consultas = new DataTable();
                Consultas = agendamentoDAO.SearchQuery(DataIni, DataFim);

                return Consultas;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
