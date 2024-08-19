using Microsoft.EntityFrameworkCore;

namespace MulitiSqlDI.Data
{
    public class ProDB:BloggingContext<ProDB>
    {
            public ProDB(DbContextOptions<ProDB> options) : base(options) { }
       
    }
}