using SparkPostCore.Utilities;

namespace SparkPostCore
{
    public class InboundDomainResponse : Response
    {
        public InboundDomain InboundDomain { get; set; }

        public static InboundDomainResponse CreateFromResponse(Response response)
        {
            var result = new InboundDomainResponse();
            LeftRight.SetValuesToMatch(result, response);

            var results = Jsonification.DeserializeObject<dynamic>(response.Content).results;

            result.InboundDomain = ListInboundDomainResponse.ConvertToAInboundDomain(results);

            return result;
        }
    }
}