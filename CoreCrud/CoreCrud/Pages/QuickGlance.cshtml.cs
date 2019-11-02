using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoreCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreCrud.Pages
{
    public class QuickGlance : PageModel
    {
        private CoreCrudContext _context;

        public ICollection<Destination> Destinations { get; set; }  
        public QuickGlance(CoreCrudContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Destinations = _context.Destination.Include(y => y.Location).ToArray();

        }
    }
}
