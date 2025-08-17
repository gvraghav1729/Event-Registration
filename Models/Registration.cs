namespace EventRegistration.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string StudentName { get; set; }
        public string StudentId { get; set; }
        public string Email { get; set; }
        public Event? Event { get; set; } 
    }
}