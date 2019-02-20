using Microsoft.AspNetCore.Antiforgery;
using FirstUse.Controllers;

namespace FirstUse.Web.Host.Controllers
{
    public class AntiForgeryController : FirstUseControllerBase
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
