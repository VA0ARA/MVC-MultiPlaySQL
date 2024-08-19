using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using MulitiSqlDI.Models;
using System.Reflection.Metadata;

namespace MulitiSqlDI.Data
{
    public abstract partial class BloggingContext<T> : DbContext where T : DbContext

    {
        public BloggingContext(DbContextOptions<T> options) : base(options) { 
        
        
        }
        public virtual DbSet<Developer> Des { get; set; }
        public virtual DbSet<Production> pros { get; set; }

    }
}
