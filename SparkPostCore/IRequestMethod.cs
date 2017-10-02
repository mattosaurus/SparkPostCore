using System.Net.Http;
using System.Threading.Tasks;

namespace SparkPostCore
{
    public interface IRequestMethod
    {
        bool CanExecute(Request request);
        Task<HttpResponseMessage> Execute(Request request);
    }
}