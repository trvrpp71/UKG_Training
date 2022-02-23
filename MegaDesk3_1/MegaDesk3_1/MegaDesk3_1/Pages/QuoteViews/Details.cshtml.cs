using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk3_1.Data;
using MegaDesk3_1.Models;

namespace MegaDesk3_1.Pages.QuoteViews
{
    public class DetailsModel : PageModel
    {
        private readonly MegaDesk3_1.Data.MegaDesk3_1Context _context;

        public DetailsModel(MegaDesk3_1.Data.MegaDesk3_1Context context)
        {
            _context = context;
        }

        public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeskQuote = await _context.DeskQuote.FirstOrDefaultAsync(m => m.Id == id);

            if (DeskQuote == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
