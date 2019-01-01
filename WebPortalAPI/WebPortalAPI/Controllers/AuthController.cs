using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebPortalAPI.Data;
using WebPortalAPI.Models;

namespace WebPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private UserManager<ApplicationUser> userManager;
        public AuthController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);

            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
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
                     issuer: "phoneapp",
                     audience: "phoneappusers",
                     expires: DateTime.Now.AddHours(1),
                     signingCredentials: signingCredentials,
                     claims: claims);
                #endregion

                return Ok(new
                {
                  token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo 
                });
            }

            return Unauthorized();
        }
        [HttpPost]
        [Route("registration")]
        public async Task<IActionResult> Register([FromBody] LoginModel model)
        {


            var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
            var result = await userManager.CreateAsync(user, model.Password);


            var getuser = await userManager.FindByEmailAsync(model.Email);

            if (getuser != null && await userManager.CheckPasswordAsync(getuser, model.Password))
            {
                return Ok("User got created.");
            }

            return Unauthorized();
        }


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
            claims.Add(new Claim(ClaimTypes.Role, "Admin"));
            claims.Add(new Claim("Custom_Claim", "Custom_Claim_Name"));
            claims.Add(new Claim(ClaimTypes.Role, "PhoneAppUser"));
            #endregion

            #region create token
            var token = new JwtSecurityToken(
                 issuer: "phoneapp",
                 audience: "phoneappusers",
                 expires: DateTime.Now.AddHours(1),
                 signingCredentials: signingCredentials,
                 claims: claims);
            #endregion


            return Ok(new JwtSecurityTokenHandler().WriteToken(token));

            
        }
    }
}