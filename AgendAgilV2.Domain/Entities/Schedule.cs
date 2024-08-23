
using AgendAgilV2.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace AgendAgilV2.Domain.Entities
{
    public class Schedule
    {
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string? Title { get; set; }

        [Required]
        [StringLength(128)]
        public string? Description { get; set; }

        [Required]
        public DateOnly? DeadLine { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
