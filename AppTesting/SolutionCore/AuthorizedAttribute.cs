using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.VisualBasic;

namespace SolutionCore
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizedAttribute : Attribute, IAuthorizationFilter
	{
		public AuthorizedAttribute()
        {
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string user = (string)context.HttpContext.Items["User"];

            if (user == null)
            {
                context.Result = new JsonResult(new { Message = "Unathorized",  StatusCode = StatusCodes.Status401Unauthorized });
                return;
            }
        }
    }
}

