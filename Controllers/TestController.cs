using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpenIddict.Abstractions;
using OpenIddict.Validation.AspNetCore;

namespace OpenIddictPasswordFlow.Controllers
{
    [Authorize(AuthenticationSchemes = OpenIddictValidationAspNetCoreDefaults.AuthenticationScheme)]
    public class TestController : Controller
    {
        [HttpGet("~/test")]
        public IActionResult Index()
        {
            return Json(new
            {
                UserId = User.GetClaim(OpenIddictConstants.Claims.Subject)
            });
        }
    }
}
