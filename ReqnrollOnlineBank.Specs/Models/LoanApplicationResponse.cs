using Newtonsoft.Json;

namespace ReqnrollOnlineBank.Specs.Models
{
    public class LoanApplicationResponse
    {
        public string responseDate { get; set; }
        public string loanProviderName { get; set; }
        public bool approved { get; set; }
        public string message { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int accountId { get; set; }
    }
}
