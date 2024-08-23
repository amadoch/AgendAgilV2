using AgendAgilV2.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgendAgilV2.Infrastructure.Context
{
    public class ScheduleDBContext : DbContext
    {
        public ScheduleDBContext(DbContextOptions<ScheduleDBContext> options) 
            : base(options)
        {
        }

        public DbSet<Schedule> Schedules { get; set; }
    }
}
