namespace EventRegistration.Models
{
    public class Event
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan EventTime { get; set; }
        public required string Venue { get; set; }
    }
}