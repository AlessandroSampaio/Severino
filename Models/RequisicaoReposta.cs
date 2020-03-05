using System.ComponentModel.DataAnnotations.Schema;

namespace Severino.Models
{
    public class RequisicaoReposta
    {
        [NotMapped]
        public Requisicao Requisicao { get; set; }
        public int RequisicaoId { get; set; }
        [NotMapped]
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }

    }
}
