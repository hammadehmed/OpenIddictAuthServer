using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OpenIddictPasswordFlow.Controllers
{
    [Authorize(Policy = "OperatorRole")]
    public class TestController : Controller
    {
        [HttpGet("~/test")]
        public string Index() => "test";
    }
}
