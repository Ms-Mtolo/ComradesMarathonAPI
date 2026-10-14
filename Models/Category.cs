public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Distance { get; set; }
    public string AgeGroup { get; set; }
    public decimal Price { get; set; }
    public int EventId { get; set; }
    public Event Event { get; set; }
    public ICollection<Enrolment> Enrolments { get; set; }
}