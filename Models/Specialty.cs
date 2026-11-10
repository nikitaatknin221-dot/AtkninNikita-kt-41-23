using System.ComponentModel.DataAnnotations;

namespace AtkninNikita_kt_41_23.Models
{
    public class Specialty
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Code { get; set; } = string.Empty;
    }
}