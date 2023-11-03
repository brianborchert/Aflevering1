using System.ComponentModel.DataAnnotations;
namespace Aflevering1.Models
{
	public class Product
	{
		[Required(ErrorMessage = "Enter product name")]
		public string? Name { get; set; }
		
		[Required(ErrorMessage = "Enter amount")]
		public int? Amount { get; set; }
		
		[Required(ErrorMessage = "Select section")]
		public string? Section { get; set; }
	}
}