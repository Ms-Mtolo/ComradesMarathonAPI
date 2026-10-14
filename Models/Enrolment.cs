public class Enrolment
{
    public int EnrolmentId { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int EventId { get; set; }
    public Event Event { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public string Status { get; set; }         // Confirmed / Pending
    public string PaymentStatus { get; set; }  // Paid / Pending
    public decimal PaymentAmount { get; set; }
    public string BibNumber { get; set; }
    public Result Result { get; set; }         // 1 → 0..1
    public Payment Payment { get; set; }       // 1 → 0..1
}