using System.Threading.Tasks;
using Refit;
using XFTest.Models;

namespace XFTest.Services
{
    public interface IApi
    {
        [Post("/TestApp/Service.svc/RetList")]
        Task<RetList> GetRetList();

        [Post("/TestApp/Service.svc/RetItem")]
        Task<RetItem> GetRetItem([AliasAs("No1")] long no1, [AliasAs("Date1")] string date1);
    }
}
