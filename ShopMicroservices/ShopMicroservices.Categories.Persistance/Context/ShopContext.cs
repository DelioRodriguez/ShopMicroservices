using Microsoft.EntityFrameworkCore;

namespace ShopMicroservices.Categories.Persistance.Context;


public class ShopContext : DbContext
{
    #region Constructor
    public ShopContext(DbContextOptions <ShopContext> options) : base(options)
    {}
    #endregion

    #region "Db sets"
    public DbSet<Domain.Entities.Categories> categories { get; set; }
    #endregion
}