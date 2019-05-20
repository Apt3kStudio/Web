﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WebPortalAPI.Data.ApplicationDbContext _context;

        public IndexModel(WebPortalAPI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<FirebaseSetting> FirebaseSetting { get;set; }

        public async Task OnGetAsync()
        {
            FirebaseSetting = await _context.FirebaseSettings.ToListAsync();
        }
    }
}
