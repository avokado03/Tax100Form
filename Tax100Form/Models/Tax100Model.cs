using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Tax100Form.Models
{
	public class Tax100Model
	{
		#region page_100_00_01
		[Description("iin")]
		public string BIN { get; set; }

		[Description("rnn")]
		public string RNN { get; set; }

		#region Name
		[Description("payer_name1")]
		public string Name1 { get; set; }

		[Description("payer_name2")]
		public string Name2 { get; set; }

		[Description("payer_name3")]
		public string Name3 { get; set; }
		#endregion
		#endregion

		#region page_100_00_02
		/// <summary>
		/// Период отчетности
		/// </summary>
		[Description("period_year")]
		public string PeriodYear { get; set; }

		/// <summary>
		/// Доход от реализации
		/// </summary>
		[Description("field_100_00_015")]
        public int SalesRevenue { get; set; }

		/// <summary>
		/// СОВОКУПНЫЙ ГОДОВОЙ ДОХОД
		/// </summary>
		[Description("field_100_00_015")]
		public int TotalRevenue { get; set; }

		/// <summary>
		/// СОВОКУПНЫЙ ГОДОВОЙ ДОХОД С УЧЕТОМ КОРРЕКТИРОВОК
		/// </summary>
		[Description("field_100_00_018")]
        public int TotalRevenueAsAdjusted { get; set; }

		/// <summary>
		/// Расходы по реализованным товарам (работам, услугам)
		/// </summary>
		[Description("field_100_00_019")]
        public int Expenditure { get; set; }
		#endregion

		#region page_100_00_03
		/// <summary>
		/// Расходы по начисленным доходам работников
		/// </summary>
		[Description("field_100_00_019_04")]
		public int TotalSalary { get; set; }

		/// <summary>
		/// Штрафы, пени, неустойки
		/// </summary>
		[Description("field_100_00_020")]
        public int Fine { get; set; }

		/// <summary>
		/// Отчисления в ГФСС, ФСМС, ОПВР
		/// </summary>
		[Description("field_100_00_022")]
        public int OPVR { get; set; }
		#endregion

		#region page_100_00_04
		/// <summary>
		/// Всего вычетов
		/// </summary>
		[Description("field_100_00_040")]
        public int TotalDeductions { get; set; }

		/// <summary>
		/// Вычеты (сумма с 100.00.019 по 100.00.039)
		/// </summary>
		[Description("field_100_00_040_01")]
        public int Deductions { get; set; }

		/// <summary>
		/// НАЛОГООБЛАГАЕМЫЙ ДОХОД (УБЫТОК)
		/// </summary>
		[Description("field_100_00_044")]
		public int Loss { get; set; }

		/// <summary>
		/// ВСЕГО НАЛОГООБЛАГАЕМОГО ДОХОДА (УБЫТКА)
		/// </summary>
		[Description("field_100_00_047")]
		public int TotalLoss { get; set; }

		/// <summary>
		/// Убыток, подлежащий переносу
		/// </summary>
		[Description("field_100_00_051")]
        public int ForwardLoss { get; set; }
		#endregion

		#region page_100_00_05
		/// <summary>
		/// Налогооблагаемый доход с учетом уменьшения (100.00.047 - 100.00.052)
		/// </summary>
		[Description("field_100_00_053")]
		public int LossWithReduction { get; set; }

		/// <summary>
		/// НАЛОГООБЛАГАЕМЫЙ ДОХОД С УЧЕТОМ  ПЕРЕНЕСЕННЫХ УБЫТКОВ (100.00.053 - 100.00.054)
		/// </summary>
		[Description("field_100_00_055")]
        public int RevenueWithLoss { get; set; }

		/// <summary>
		/// Ставка КПН (%)
		/// </summary>
		[Description("field_100_00_056")]
        public float Percent { get; set; }

		/// <summary>
		/// КПН с налогооблагаемого дохода (100.00.055 x 100.00.056)
		/// </summary>
		[Description("field_100_00_057")]
		public int KPNTaxableIncome { get; set; }

		/// <summary>
		/// Исчисленная сумма КПН  (100.00.057 - 100.00.058 I - 100.00.058 IIІ - 100.00.058 IV - 100.00.058 V - 100.00.058 VI)
		/// </summary>
		[Description("field_100_00_058")]
		public int KPNSum { get; set; }

		/// <summary>
		/// Исчисленная сумма КПН с учетом уменьшения (100.00.058 - 100.00.059 А)
		/// </summary>
		[Description("field_100_00_059")]
		public int KPNSumWithReduction { get; set; }
		#endregion

		#region page_100_00_06
		/// <summary>
		/// Дата подачи декларации
		/// </summary>
		[Description("accept_date")]
        public int AcceptDate { get; set; }

		/// <summary>
		/// Чистый доход (100.00.055 - 100.00.057)
		/// </summary>
		[Description("field_100_00_060")]
        public int NetRevenue { get; set; }

		/// <summary>
		/// ВСЕГО КПН, за исключением  КПН с облагаемого дохода КИК и ПУ КИК
		/// в соответствии с подпунктом 4) статьи 223 Налогового кодекса
		/// (100.00.059 + 100.00.061 I или 100.00.061 II + 100.00.064)
		/// </summary>
		[Description("field_100_00_062")]
        public int TotalKPN { get; set; }

		/// <summary>
		/// КПН с облагаемого дохода КИК и ПУ КИК в соответствии с подпунктом 4)
		/// статьи 223 Налогового кодекса
		/// (100.00.049 x 100.00.056)
		/// </summary>
		[Description("field_100_00_063")]
        public int KPNKIKpp4 { get; set; }

		/// <summary>
		/// КПН с облагаемого дохода КИК и ПУ КИК в соответствии с подпунктом 5)
		/// статьи 223 Налогового кодекса
		/// (100.00.048 II x 100.00.056)
		/// </summary>
		[Description("field_100_00_064")]
        public int KPNKIKpp5 { get; set; }

		/// <summary>
		/// Исчисленная сумма КПН с учетом уменьшения с облагаемого дохода
		/// КИК и ПУ КИК в соответствии с подпунктом 4) статьи 223 Налогового
		/// кодекса (100.00.063 - 100.00.058 II)
		/// </summary>
		[Description("field_100_00_065")]
        public int KPNKIKpp4WithReduction { get; set; }

		/// <summary>
		/// Фамилия, имя, отчество (при его наличии) налогоплательщика
		/// </summary>
		[Description("head_name")]
        public string HeadName { get; set; }

		/// <summary>
		/// Код органа государственных доходов
		/// </summary>
		[Description("rating_auth_code")]
		public string RatingAuthCode { get; set; }

		[Description("submit_date")]
        public string SubmitDate { get; set; }
		#endregion
	}
}
