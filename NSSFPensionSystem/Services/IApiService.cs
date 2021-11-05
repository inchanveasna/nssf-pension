using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSSFPensionSystem.Services
{
    public interface IApiService
    {
        Task<T> Get<T>(string Url);
        Task<Tuple<T, string>> GetWithMessage<T>(string Url);

        Task Post(string url, object data);

        Task<Tuple<T, string>> PostWithReturn<T>(string url, object data);
        Task Put(string url, object data);
    }
}
