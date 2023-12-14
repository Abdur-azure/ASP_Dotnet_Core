using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASP_Dotnet_Core.Data;
using ASP_Dotnet_Core.Models;

namespace ASP_Dotnet_Core.Pages.Student
{
    public class CreateModel : PageModel
    {
        private readonly ASP_Dotnet_Core.Data.ASP_Dotnet_CoreContext _context;

        public CreateModel(ASP_Dotnet_Core.Data.ASP_Dotnet_CoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Students Student { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
