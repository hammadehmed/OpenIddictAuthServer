using System.ComponentModel.DataAnnotations;

namespace MeridiaCoreWebAPI.Models
{
    public class SubscriptionType
    {
        [Key]
        public int SubscriptionTypeId { get; set; }
        public string Name { get; set; }
    }
}
