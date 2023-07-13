using Microsoft.AspNetCore.Identity;

namespace MeridiaCoreWebAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsDeleted { get; set; }
        public bool TwoFactorConfigured { get; set; }
        public bool PasswordExpirationEnabled { get; set; }
        public int PasswordExpiryDays { get; set; }
        public bool FirstLoginPasswordChange { get; set; }
        public bool IsPasswordReset { get; set; }
        public bool DisableAccountEnabled { get; set; }
        public int DisbleAfterDays { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public bool IsAccountDisabled { get; set; }
        public bool LockAccountEnabled { get; set; }
        public bool IsAccountLocked { get; set; }
        public int CurrentFailedloginAttempts { get; set; }
        public int MaxFailedloginAttempts { get; set; }
        public virtual Subscription Subscription { get; set; }
    }
}
