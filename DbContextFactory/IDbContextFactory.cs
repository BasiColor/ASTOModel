using System.Data.Entity;

namespace Asto.Models.DbContextFactory
{
    public interface IDbContextFactory
    {
        DbContext GetDbContext();
    }
}
