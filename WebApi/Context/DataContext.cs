using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }

        public DbSet<ApiCepModel> ApiCepModels { get; set; }
    }
}
