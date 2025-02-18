using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace PTApp.Server.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SubscriptionId { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime TransactionDate { get; set; }

        public User User { get; set; }
    }
}
