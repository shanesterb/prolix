using Prolix.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace Prolix.Web.Host.Controllers
{
    public class AntiForgeryController : ProlixControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}