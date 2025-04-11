using System.Diagnostics.CodeAnalysis;

namespace Tax100Form.Options
{
	public class Tax100MainOptions
	{
        [NotNull]
        public string BIN { get; set; }
		[NotNull]
		public string Name1 { get; set; }
		[NotNull]
		public string Name2 { get; set; }
		[NotNull]
		public string Name3 { get; set; }
		[NotNull]
		public string RNN { get; set; }
		[NotNull]
		public string XMLPath { get; set; }
    }
}
