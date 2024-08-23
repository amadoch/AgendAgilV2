using AgendAgilV2.Domain.Entities;

namespace AgendAgilV2.Application.Interfaces
{
    public interface IScheduleRepository
    {
        Task AddAsync(Schedule schedule);
    }
}
