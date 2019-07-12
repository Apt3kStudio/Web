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
using Microsoft.Extensions.DependencyInjection;
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
        private ApplicationDbContext db;
        public AuthController(UserManager<ApplicationUser> userManager, IServiceProvider serviceProvider)
        {
            this.userManager = userManager;
            db = serviceProvider.GetRequiredService<ApplicationDbContext>();
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] User model, string device)
        {
            var user = await userManager.FindByEmailAsync(model.Email);

             if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                if (!string.IsNullOrEmpty(model?.FBToken ?? ""))
                {
                    UpdateUser(model, user);
                    await Task.Delay(2000);
                    if (DeviceExist(model.FBToken, user, model.DeviceName))
                    {
                        UpdateDevice(model.FBToken, user, model.DeviceName);
                    }
                    else
                    {
                        InsertDevice(model.FBToken, user, model.DeviceName);
                    }
                }

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

                SendToPhone stp = new SendToPhone();
                stp.jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
                stp.jwtExpiration = token.ValidTo;
                stp.FCMToken = user.FBToken;

                return Ok(stp);
            }

            return Unauthorized();
        }
        [HttpPost]
        [Route("ChangeFCMToken")]
        public async Task<IActionResult> ChangeFCMToken([FromBody] User model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);

            if (user != null )
            {
                if (!string.IsNullOrEmpty(model?.FBToken ?? ""))
                {
                    UpdateUser(model, user);
                    await Task.Delay(2000);
                    if (DeviceExist(model.FBToken, user, model.DeviceName))
                    {
                        UpdateDevice(model.FBToken, user, model.DeviceName);
                    }
                    else
                    {
                        InsertDevice(model.FBToken, user, model.DeviceName);
                    }                   
                }

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
        private void UpdateUser(User model, ApplicationUser user)
        {
            Task.Run(async () =>
            {
                user.FBToken = model.FBToken;
                await userManager.UpdateAsync(user);
            });
         
        }
        private void UpdateDevice(string token, ApplicationUser user, string deviceName)
        {
            foreach (DeviceModel device in db.Devices.Where(c => c.UserId == user.Id && c.Name == deviceName))
            {
                try
                {
                    Task.Run(async () => {
                        device.Name = deviceName;
                        device.FCMToken = token;
                        db.Devices.Update(device);
                       await db.SaveChangesAsync();
                    });          
                    
                }
                catch (Exception ex)
                {
                   
                }
            }
        }
        private bool InsertDevice(string token, ApplicationUser user, string deviceName)
        {            
            try
            {                    
                DeviceModel device = new DeviceModel
                {
                        Name = deviceName,
                        FCMToken = token,
                        UserId = user.Id,
                        EventID = 3 // temporaty
                };              
                    db.Devices.Add(device);
                    db.SaveChanges();
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }            
    }
        private bool DeviceExist(string token, ApplicationUser user, string deviceName)
        {
            try
            {
                return db.Devices.Any(c => c.UserId == user.Id && c.Name == deviceName);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        [HttpPost]
        [Route("registration")]
        public async Task<IActionResult> Register([FromBody] User model)
        {


            var user = new ApplicationUser { UserName = model.Email, Email = model.Email, FBToken = model.FBToken};
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