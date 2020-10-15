using System;

namespace ProjetoTCC2020.Models
{
    public class Profissional
    {
        public string CRO { get; set; }
        public int Ativo { get; set; }
        public int CodPro { get; set; }
        public string CPF { get; set; }
        public DateTime DtNasc { get; set; }
        public string Nome { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public int codCidade { get; set; }
        public string Uf { get; set; }
        public int codEstado { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Compl { get; set; }
        public string Email { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Obs { get; set; }

    }
}
