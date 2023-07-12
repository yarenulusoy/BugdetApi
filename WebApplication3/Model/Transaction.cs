using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Model
{
    public class Transactions
    {
        [Key]
        public int Id { get; set; }

        public decimal Amount { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string MoneyType { get; set; }
        public DateTime Date { get; set; }
        public String UserId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
