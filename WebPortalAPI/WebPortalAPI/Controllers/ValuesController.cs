using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebPortalAPI.Data;
using WebPortalAPI.Models;

namespace WebPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Roles ="Admin")]
    //[Authorize]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       
        
        private ApplicationDbContext db;
        public ValuesController(ApplicationDbContext db)
        {
            this.db = db;
        }

        // GET: api/Values
        [HttpGet]
        public async Task<IEnumerable<string>> GetAsync()
        {
            try
            {
                PushNotification pn = new PushNotification();
                pn.SendPushNotification(new PushNotification() { NotificationTitle = "", NotificationContent = "" });
            }
            catch (Exception ex)
            {

                throw;
            }


            return db.Users.Select(user => user.UserName).ToArray();
            //return new string[] { "value1", "value2" };
        }

        

        // GET: api/Values/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

     
}
  
}
