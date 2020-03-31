using System.ComponentModel.DataAnnotations.Schema;

namespace Severino.Models
{
    public class RequisicaoReposta
    {
        public Requisicao Requisicao { get; set; }
        [NotMapped]
        public int RequisicaoId { get; set; }
        public Usuario Usuario { get; set; }
        [NotMapped]
        public int UsuarioId { get; set; }

    }
}
