namespace AtkninNikita_kt_41_23.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public int DisciplineId { get; set; }
        public Discipline? Discipline { get; set; }
        public int Value { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}