using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMicroservices.Customers.Persistance.Context
{
    public class ShopContext : DbContext
    {

        #region Constructor
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
            
        }
        #endregion


        #region "Db sets"
        public DbSet<Domain.Entities.Customers> Customers { get; set; }
        #endregion


    }
}
