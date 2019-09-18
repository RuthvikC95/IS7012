using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreCrud.Pages
{
    public class IndexModel : PageModel
    {

        private CoreCrudContext _context;
        public int Country_Count;
        public int Destination_Count;
        public int Closed_Bookings;
        public int Available_Bookings;
        
       
        public IndexModel(CoreCrudContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Country_Count = _context.Country.Count();
            Destination_Count = _context.Destination.Count();
            Closed_Bookings = _context.Destination.Where(x => x.isAvailable == false).Count();
            Available_Bookings = _context.Destination.Where(x => x.isAvailable == true).Count();
            
            return Page();
        }
    }
}
