using WebApi.Model;

namespace WebApi.Repository
{
    public interface IRepository
    {
       Task CreateAsync(ApiCepModel model);
    }
}
