using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SolutionCore;

public class JwtMiddleware
{
    private readonly RequestDelegate _next;
    public JwtMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

        if (token != null)
            AttachUserToContext(context, token);

        await _next(context);
    }

    private void AttachUserToContext(HttpContext context, string token)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("AD4k4c*h0@-1q6_8Z%tLQ?n61#CF819O6CR89hrPIzvy7g|qHP9jJ_@J^7w@");
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);

            JwtSecurityToken jwtToken = (JwtSecurityToken)validatedToken;
            string userId = jwtToken.Claims.First(x => x.Type == "sub").Value;

            if (string.IsNullOrWhiteSpace(userId))
            {
               //   _logger.LogWarning("Jwt without userId");
                return;
            }

            // attach user to context on successful jwt validation
            if (userId != null)
            {
                context.Items["User"] = userId;
            }
        }
        catch (Exception ex)
        {
            //no faig res
        }
    }
}

