using Severino.Models.Enum;
using System;
using System.Collections.Generic;

namespace Severino.Models
{
    public class Requisicao
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Detalhes { get; set; }
        public double ValorRemuneracao { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public Usuario Autor { get; set; }
        public List<Usuario> Candidatos { get; set; }
        public RequisicaoStatus Status { get; set; }
    }
}
