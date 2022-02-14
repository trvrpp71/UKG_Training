using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        //the bindproperty tells the model that the object can be used throughout
        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid) //if there is a book object
            {
                //add the book to the db
                await _db.Book.AddAsync(Book);
                await _db.SaveChangesAsync(); //this pushes the data to the db
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
