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

        public async Task<List<Schedule>> GetAllAsync()
        {
            var schedules = await context.Schedules.ToListAsync();
            return schedules;
        }

        public async Task<Schedule?> GetByIdAsync(int id)
        {
            var schedules = await context.Schedules.FirstOrDefaultAsync(e => e.Id == id);
            return schedules;
        }

        public async Task UpdateAsync(Schedule schedule)
        {
            context.Entry(schedule).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var schedules = await GetByIdAsync(id);
            if(schedules is not null)
            {
                context.Schedules.Remove(schedules);
                await context.SaveChangesAsync();
            }
        }

    }
}
