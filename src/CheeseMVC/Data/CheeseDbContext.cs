using CheeseMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CheeseMVC.Data
{
    public class CheeseDbContext : DbContext
    {
        //property
        public DbSet<Cheese> Cheeses { get; set; }

        public DbSet<CheeseCategory> Categories { get; set; }

      // public object Categories { get; internal set; }

        //db constructor
        public CheeseDbContext(DbContextOptions<CheeseDbContext> options) 
            // extends base constructor
            : base(options)
        {
 }

    }
}
