using System;

namespace ProjetoTCC2020.Models
{
    public class AgendamentoModel
    {
        public int CodAgendamento { get; set; }
        public int CodFunc { get; set; }
        public char StatusConsulta { get; set; }
        public string CPF { get; set; }
        public string NomeCli { get; set; }
        public int CodCli { get; set; }
        public string NomeDoc { get; set; }
        public int CodDoc { get; set; }
        public string NomeServ { get; set; }
        public int CodServ { get; set; }
        public DateTime DtConsulta { get; set; }
        public DateTime HrIni { get; set; }
        public int CodHrIni { get; set; }
        public DateTime HrFinal { get; set; }
        public int CodHrFinal { get; set; }
        public DateTime DtInclusao { get; set; }
        public string MotivoCanc { get; set; }


    }
}
