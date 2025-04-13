using Microsoft.Extensions.Options;
using Tax100Form.Options;

namespace Tax100Form.Services
{
	public class KPNCountService
	{
        public required IOptions<Tax100MainOptions> Options { get; set; }

        public KPNCountService()
        {           
        }

        public KPNCountService(IOptions<Tax100MainOptions> options)
        {
            Options = options ?? throw new ArgumentNullException(nameof(options));
        }
    }
}
