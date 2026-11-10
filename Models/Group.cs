using System.ComponentModel.DataAnnotations;

namespace AtkninNikita_kt_41_23.Models
{
    public class Group
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Course { get; set; } // Год набора заменен на Курс

        public int SpecialtyId { get; set; }
        public Specialty? Specialty { get; set; }
        public bool IsDeleted { get; set; } // Вместо DeletedAt
    }
}