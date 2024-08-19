using Microsoft.EntityFrameworkCore;

namespace MulitiSqlDI.Data
{
    public class DevDB:  BloggingContext<DevDB>
    {
        public DevDB(DbContextOptions<DevDB> options) : base(options) { }
    }
}
