using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using ButterCMS;

namespace ButterCMS.Starter.Attributes
{
    public class WithApiKeyAttribute : Attribute, IActionFilter
    {
        private readonly IConfiguration configuration;

        public WithApiKeyAttribute(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (String.IsNullOrEmpty(this.configuration["ButterCMSAPIKey"]))
            {
                context.Result = new RedirectToActionResult("UnauthorizedError", "Error", null);
                return;
            }

            try
            {
                var client = new ButterCMSClient(this.configuration["ButterCMSAPIKey"]);
                // Make a simple API call to validate the key
                client.ListPostsAsync(1, 1).GetAwaiter().GetResult();
            }
            catch (InvalidKeyException)
            {
                context.Result = new RedirectToActionResult("UnauthorizedError", "Error", null);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
