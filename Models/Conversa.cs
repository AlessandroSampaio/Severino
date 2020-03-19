using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Severino.Models
{
    public class Conversa
    {
        public int Id { get; set; }
        public Usuario Remetente { get; set; }
        public Usuario Destinatario { get; set; }
        public DateTime UltimaMensagem { get; set; }

    }
}
