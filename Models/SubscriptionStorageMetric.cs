using System.ComponentModel.DataAnnotations.Schema;

namespace MeridiaCoreWebAPI.Models
{
    public class SubscriptionStorageMetric
    {
        public int Id { get; set; }
        [ForeignKey("Subscription")]
        public int SubscriptionId { get; set; }
        public Int64 BlobStorageConsumed { get; set; }
        public virtual Subscription Subscription { get; set; }
    }
}
