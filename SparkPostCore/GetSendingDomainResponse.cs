using Newtonsoft.Json;
namespace SparkPostCore
{
    public class GetSendingDomainResponse : Response
    {
        public SendingDomain SendingDomain { get; set; }
    }
}