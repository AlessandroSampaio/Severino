using Severino.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Severino.Models
{
    public class Mensagem
    {
        public int Id { get; set; }
        public Usuario Remetente { get; set; }
        public Conversa conversa { get; set; }
        public string Texto { get; set; }
        public DateTime Data { get; set; }
        public MensagemStatus Status { get; set; }


    }
}
