using System.ComponentModel;

namespace Tax100Form.Models.Requests
{
    public class Tax100Request
    {
        /// <summary>
        /// Период отчетности
        /// </summary>
        [Description("period_year")]
        public required string PeriodYear { get; set; }

        /// <summary>
        /// Доход от реализации
        /// </summary>
        [Description("field_100_00_015")]
        public int SalesRevenue { get; set; }

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

        /// <summary>
        /// Ставка КПН (%)
        /// </summary>
        [Description("field_100_00_056")]
        public float Percent { get; set; }
    }
}
