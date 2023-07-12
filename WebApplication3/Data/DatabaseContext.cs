using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication3.Model;

namespace WebApplication3.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opt) : base(opt)
        {
        }

        public DbSet<Transactions> Transactions { get; set; }
    }
}
