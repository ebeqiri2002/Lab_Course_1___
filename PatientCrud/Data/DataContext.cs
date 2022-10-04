using Microsoft.EntityFrameworkCore;

namespace PatientCrud.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Pacienti>pacientet { get; set; }

    }
}
