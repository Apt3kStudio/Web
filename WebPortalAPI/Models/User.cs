using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebPortalAPI.Models
{
    public class User
    {
        [Required(ErrorMessage ="Username is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password is Required.")]
        public string Password { get; set; }
        public string roleName { get; set; }
        public string FBToken { get; set; }

    }
}
