using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CoreCrud.Pages
{
    public class CountryProfileModel : PageModel
    {
        private CoreCrudContext _context;

        public CountryProfileModel(CoreCrudContext context)
        {
            _context = context;
        }

        public Country country { get; set; }

        public IActionResult OnGet(int? id)
        {
            country = _context.Country.Include(x => x.Destinations).FirstOrDefault(x => x.Id == id);
            return Page();
        }
    }
}
