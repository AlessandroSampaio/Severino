using Microsoft.AspNetCore.Identity;

namespace Severino.Models
{
	public class Usuario : IdentityUser
	{
		public bool PrestadorDeServico { get; set; }
		public double AvaliacaoPrestador { get; set; }
		public double AvaliacaoContratante { get; set; }
	}
}
