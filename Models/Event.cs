public class Event
{
    public int EventId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public string Status { get; set; }
    public string EventType { get; set; } // run, walk, cycle
    public int OrganizerId { get; set; }
    public User Organizer { get; set; }
    public ICollection<Category> Categories { get; set; }
}
