﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CarDealership.Models;

namespace CarDealership.Pages.MakeTypes
{
    public class CreateModel : PageModel
    {
        private readonly CarDealership.Models.CarDealershipContext _context;

        public CreateModel(CarDealership.Models.CarDealershipContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MakeType MakeType { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MakeType.Add(MakeType);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}