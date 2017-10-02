using System.Net.Http;
using System.Threading.Tasks;

namespace SparkPostCore.RequestMethods
{
    public class Delete : RequestMethod
    {
        private readonly HttpClient client;

        public Delete(HttpClient client)
        {
            this.client = client;
        }

        public override Task<HttpResponseMessage> Execute(Request request)
        {
            return client.DeleteAsync(request.Url);
        }
    }
}