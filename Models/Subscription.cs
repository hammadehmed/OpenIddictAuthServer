using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeridiaCoreWebAPI.Models
{
    public class Subscription
    {
        [Key]
        public int SubscriptionId { get; set; }
        [ForeignKey("ApplicationUser")]
        [Required]
        public string UserId { get; set; }
        [Required]
        public string SubscriptionKey { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }
        public int? MaximumParticipants { get; set; }
        public bool? PushContentToParticipants { get; set; }
        public int? MaxAnswersPerSlide { get; set; }
        [ForeignKey("SubscriptionState")]
        [Required]
        public short Status { get; set; }
        public string BrandLogo { get; set; }
        public string BrandColor { get; set; }
        [Required]
        public int WebAppIdentifier { get; set; }
        [Required]
        public string Timezone { get; set; }
        public string AccessKey { get; set; }
        [ForeignKey("SubscriptionType")]
        public int SubscriptionTypeId { get; set; }
        public int? ParentId { get; set; }
        public bool IsVerified { get; set; }
        public string SpecialName { get; set; }
        public bool EnableTimeline { get; set; }
        public int ChildLimit { get; set; }
        public string StripeCustomerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime SubscriptionRenewalDate { get; set; }
        [Required]
        public string Name { get; set; }
        public bool EnableSearchDataFilter { get; set; }
        public bool EnableParticipantsFeature { get; set; }
        public bool EnableCsvNightliesView { get; set; }
        public string Location { get; set; }
        public virtual SubscriptionState SubscriptionState { get; set; }
        public int SubscriptionPlanId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual SubscriptionType SubscriptionType { get; set; }
        public virtual SubscriptionPlan SubscriptionPlan { get; set; }
        public virtual SubscriptionStorageMetric SubscriptionStorageMetric { get; set; }
        public int UniversalScore { get; set; }
        public string OldAccessKey { get; set; }
    }
}
