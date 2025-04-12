using System.Diagnostics.CodeAnalysis;

namespace Tax100Form.Options
{
	public class Tax100MainOptions
	{
        [NotNull]
        public required string BIN { get; set; }
		[NotNull]
		public required string Name1 { get; set; }
		[NotNull]
		public required string Name2 { get; set; }
		[NotNull]
		public required string Name3 { get; set; }
		[NotNull]
		public required string RNN { get; set; }
		[NotNull]
        public float KPNRate { get; set; }
		[NotNull]
		public required string HeadName { get; set; }
		[NotNull]
		public required string XMLPath { get; set; }
		[NotNull]
		public required string RatingAuthCode { get; set; }
	}
}
