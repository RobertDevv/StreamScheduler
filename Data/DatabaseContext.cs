using Microsoft.EntityFrameworkCore;
using ScheduleWeb.Data.Models;

namespace ScheduleWeb.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Logins> Logins { get; set; }
        public string DbPath { get; set; }

        public DatabaseContext()
        {
#if DEBUG
            DbPath = Directory.GetCurrentDirectory() + "\\db\\ScheduleWeb.db";
#else
            DbPath = Directory.GetCurrentDirectory() + "/db/ScheduleWeb.db";
#endif
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source={DbPath}");

    }
}
