

using WebApi.Model;

namespace WebApi.Interface
{
    public interface IApiCepService
    {
        Task<ApiCepModel> GetByCep(string cep);
    }
}
