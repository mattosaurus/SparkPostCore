using System.Threading.Tasks;

namespace SparkPostCore
{
    public interface IMessageEvents
    {
        Task<ListMessageEventsResponse> List();
        Task<ListMessageEventsResponse> List(object query);
        Task<MessageEventSampleResponse> SamplesOf(string events);
    }
}