using System.ComponentModel.DataAnnotations;

namespace Tax100Form.Models.Requests
{
	public class TotalTax100Request
	{
		[Required]
		public required Tax100Request Tax100Request { get; set; }

        [Required]
        public required App7Request App7Request { get; set; }
    }
}
