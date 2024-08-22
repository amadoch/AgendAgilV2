
using AgendAgilV2.Domain.Enums;

namespace AgendAgilV2.Domain.Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Place {  get; set; }
        public string? PublicationTime { get; set; }
        public string? ExpirationTime { get; set; }
        public Category Category { get; set; }
    }
}
