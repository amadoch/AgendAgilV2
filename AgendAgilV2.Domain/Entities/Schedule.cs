using AgendAgilV2.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace AgendAgilV2.Domain.Entities
{
    public class Schedule
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Define el Asunto del Evento")]
        [StringLength(128)]
        public string? Title { get; set; }

        [StringLength(128)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Indica una fecha valida")]
        public DateOnly? DeadLine { get; set; }

        [Required]
        [EnumDataType(typeof(Category), ErrorMessage = "Selecciona una Categoria")]
        public Category Category { get; set; }
    }
}
