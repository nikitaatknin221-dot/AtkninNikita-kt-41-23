namespace AtkninNikita_kt_41_23.Models
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Direction { get; set; } = string.Empty; // "Гуманитарное" или "Техническое"
        public DateTime? DeletedAt { get; set; }
    }
}