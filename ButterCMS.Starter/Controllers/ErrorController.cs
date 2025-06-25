using System;
using Microsoft.AspNetCore.Mvc;

namespace ButterCMS.Starter.Controllers
{
    public class ErrorController : Controller
    {
        [Route("{**catchAllUnknown}")]
        [Route("{controller}/404")]
        public IActionResult NotFoundError()
        {
            return View("NotFound");
        }
    }
}
