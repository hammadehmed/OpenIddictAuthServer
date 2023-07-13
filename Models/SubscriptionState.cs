using System.ComponentModel.DataAnnotations;

namespace MeridiaCoreWebAPI.Models
{
    public class SubscriptionState
    {
        [Key]
        public short SubscriptionStateId { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
