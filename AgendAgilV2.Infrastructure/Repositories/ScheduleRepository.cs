using AgendAgilV2.Application.Interfaces;
using AgendAgilV2.Domain.Entities;
using AgendAgilV2.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace AgendAgilV2.Infrastructure.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly ScheduleDBContext context;
        public ScheduleRepository(IDbContextFactory<ScheduleDBContext> factory) 
        {
            context = factory.CreateDbContext();
        }

        public async Task AddAsync(Schedule schedule)
        {
            context.Schedules.Add(schedule);
            await context.SaveChangesAsync();
        }
    }
}
