public class Payment
{
    public int PaymentId { get; set; }
    public int EnrolmentId { get; set; }
    public Enrolment Enrolment { get; set; }
    public decimal Amount { get; set; }
    public string Status { get; set; }
    public DateTime PaymentDate { get; set; }
}