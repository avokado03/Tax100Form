using System.ComponentModel;

namespace Tax100Form.Models.Requests
{
	public class App7Request
	{
		/// <summary>
		/// Денежные средства и их эквиваленты
		/// На конец отчетного периода
		/// </summary>
		[Description("field_100_07_001_A")]
		public int MoneyAssetsEnd { get; set; }

		/// <summary>
		/// Денежные средства и их эквиваленты
		/// На начало отчетного периода
		/// </summary>
		[Description("field_100_07_001_B")]
		public int MoneyAssetsStart { get; set; }

		/// <summary>
		/// Уставный капитал
		/// На конец отчетного периода
		/// </summary>
		[Description("field_100_07_031_A")]
		public int AuthorizedCapitalEnd { get; set; }

		/// <summary>
		/// Уставный капитал
		/// На начало отчетного периода
		/// </summary>
		[Description("field_100_07_031_B")]
		public int AuthorizedCapitalStart { get; set; }
	}
}
