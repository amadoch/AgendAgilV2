using AgendAgilV2.Domain.Entities;

namespace AgendAgilV2.Application.Interfaces
{
    public interface IScheduleRepository
    {
        /*Create*/
        Task AddAsync(Schedule schedule);
        /*Read*/
        Task<List<Schedule>> GetAllAsync();
        Task<Schedule?> GetByIdAsync(int id);
        /*Update*/
        Task UpdateAsync(Schedule schedule);
        /*Delete*/
        Task DeleteByIdAsync(int id);
    }
}
