namespace AtkninNikita_kt_41_23.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public int GroupId { get; set; }
        public Group? Group { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}