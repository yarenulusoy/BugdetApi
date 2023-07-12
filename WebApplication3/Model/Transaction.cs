namespace WebApplication3.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string MoneyType { get; set; }
        public DateTime Date { get; set; }
    }
}
