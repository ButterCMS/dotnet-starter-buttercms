using System;
using Microsoft.AspNetCore.Mvc;

namespace ButterCMS.Starter.Controllers
{
    public class MissingAuthTokenController : Controller
    {

        [Route("/missing-auth-token")]
        public IActionResult MissingAuthToken()
        {
            return View("MissingAuthToken");
        }
    }
}
