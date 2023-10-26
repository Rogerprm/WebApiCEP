using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.Model;

namespace WebApi.Repository
{
    public class Repository : IRepository
    {
        private readonly DbSet<ApiCepModel> _dataContext;

        public Repository( DataContext dataContext)
        {
            _dataContext = dataContext.Set<ApiCepModel>();
        }

        public async Task CreateAsync(ApiCepModel model)
        {
            try
            {
                await _dataContext.AddAsync(model);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
    }
}
