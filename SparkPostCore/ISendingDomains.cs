using System.Threading.Tasks;

namespace SparkPostCore
{
    public interface ISendingDomains
    {
        Task<ListSendingDomainResponse> List();
        Task<CreateSendingDomainResponse> Create(SendingDomain sendingDomain);
        Task<UpdateSendingDomainResponse> Update(SendingDomain sendingDomain);
        Task<GetSendingDomainResponse> Retrieve(string domain);
        Task<Response> Delete(string domain);
        Task<VerifySendingDomainResponse> Verify(VerifySendingDomain verifySendingDomain);
    }
}