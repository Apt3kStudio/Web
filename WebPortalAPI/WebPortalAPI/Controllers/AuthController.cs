using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace WebPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("token")]
        public ActionResult GetToken()
        {
            #region  security key 
            string securityKey = "super_long_security_key";
            #endregion

            #region Symetric security key
            var symetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
            #endregion

            #region signing credential 
            var signingCredentials = new SigningCredentials(symetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);
            #endregion

            #region Claims 
            var claims = new List<Claim>();
            //claims.Add(new Claim(ClaimTypes.Role, "Admin"));
            claims.Add(new Claim("Custom_Claim", "Custom_Claim_Name"));
            claims.Add(new Claim(ClaimTypes.Role, "PhoneAppUser"));
            #endregion

            #region create token
            var token = new JwtSecurityToken(
                 issuer: "smesk.in",
                 audience: "readers",
                 expires: DateTime.Now.AddHours(1),
                 signingCredentials: signingCredentials,
                 claims: claims);
            #endregion


            return Ok(new JwtSecurityTokenHandler().WriteToken(token));

            
        }
    }
}