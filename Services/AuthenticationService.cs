using System.Security.Claims;
using System.Text;
using Contracts;
using System;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Services;

public class AuthenticationService : IAuthenticationService
{
    public UserLoginResponse Authenticate(UserLoginRequest loginRequest)
    {

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes("AD4k4c*h0@-1q6_8Z%tLQ?n61#CF819O6CR89hrPIzvy7g|qHP9jJ_@J^7w@");

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[] { new Claim("sub", loginRequest.UserName) }),
            Expires = DateTime.UtcNow.AddMinutes(20),
            Issuer = "user",
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return new UserLoginResponse { Token = tokenHandler.WriteToken(token) };
    }
}

