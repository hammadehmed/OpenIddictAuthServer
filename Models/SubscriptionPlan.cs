using System.ComponentModel.DataAnnotations;

namespace MeridiaCoreWebAPI.Models
{
    public class SubscriptionPlan
    {
        [Key]
        public int SubscriptionPlanId { get; set; }
        public string Title { get; set; }
        public bool ForInternalUse { get; set; }
        public double Price { get; set; }
        public bool AutoRenew { get; set; }
        public bool IsPaidPlan { get; set; }
        public string Description { get; set; }
        public int ExpiryInDays { get; set; }
        public bool IsCustom { get; set; }
        public int BillingDuration { get; set; }
        public double PerParticipantPrice { get; set; }
        public double Discount { get; set; }
    }
}
