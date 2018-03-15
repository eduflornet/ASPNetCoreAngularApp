using Microsoft.AspNetCore.Antiforgery;
using ASPNetCoreAngularApp.Controllers;

namespace ASPNetCoreAngularApp.Web.Host.Controllers
{
    public class AntiForgeryController : ASPNetCoreAngularAppControllerBase
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
