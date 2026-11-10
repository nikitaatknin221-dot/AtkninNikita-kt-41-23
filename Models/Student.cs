using System.ComponentModel.DataAnnotations;

namespace AtkninNikita_kt_41_23.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty; // Имя

        [Required]
        public string LastName { get; set; } = string.Empty;  // Фамилия

        public int GroupId { get; set; }
        public Group? Group { get; set; }
        public bool IsDeleted { get; set; }
    }
}