using System.ComponentModel.DataAnnotations;
namespace Aflevering1.Models
{
	public class Product
	{
		[Required(ErrorMessage = "Indtast produktnavn")]
		public string? Name { get; set; }
		
		[Required(ErrorMessage = "Indtast antal")]
		public int? Amount { get; set; }
		
		[Required(ErrorMessage = "Vælg område")]
		public string? Section { get; set; }
	}
}