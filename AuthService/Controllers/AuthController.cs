using AuthService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous()]
    public class AuthController : ControllerBase
    {

      [HttpPost("getToken")]
      public IActionResult Get([FromBody] UserInfo user)
        {
            if(user.Username == "abc" && user.Password == "123")
            {
                var now = DateTime.UtcNow;

                var claims = new Claim[] 
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.Username),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, now.ToUniversalTime().ToString(), ClaimValueTypes.Integer64)
                };

                var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("YOCizeiswASbUh1VGFudoZtQ3E9gUxSW"));

                var jwt = new JwtSecurityToken(
                    issuer:"localhost",
                    audience:"Catcher Wong",
                    claims: claims,
                    notBefore: now,
                    expires: now.Add(TimeSpan.FromMinutes(5)),
                    signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
                    );

                var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
                var responseJson = new
                {
                    access_token = encodedJwt,
                    expires_in = (int)TimeSpan.FromMinutes(5).TotalSeconds
                };

                return new ObjectResult(responseJson);
            }
            else
            {
                return Unauthorized();
            }         
        }
    }
}
