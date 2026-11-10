namespace AtkninNikita_kt_41_23.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Specialty { get; set; } = string.Empty;
        public int EnrollmentYear { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}