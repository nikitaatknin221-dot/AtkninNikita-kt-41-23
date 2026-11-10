using System.ComponentModel.DataAnnotations;

namespace AtkninNikita_kt_41_23.Models
{
    public class Discipline
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public bool IsDeleted { get; set; }
    }
}