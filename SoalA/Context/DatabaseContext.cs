using Microsoft.EntityFrameworkCore;
using SoalA.Models;

namespace SoalA.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Barang> MS_Barang { get; set; }
    }
}
