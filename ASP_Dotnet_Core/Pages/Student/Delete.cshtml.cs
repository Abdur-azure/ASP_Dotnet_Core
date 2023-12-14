using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_Dotnet_Core.Data;
using ASP_Dotnet_Core.Models;

namespace ASP_Dotnet_Core.Pages.Student
{
    public class DeleteModel : PageModel
    {
        private readonly ASP_Dotnet_Core.Data.ASP_Dotnet_CoreContext _context;

        public DeleteModel(ASP_Dotnet_Core.Data.ASP_Dotnet_CoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Students Student { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FirstOrDefaultAsync(m => m.StudentId == id);

            if (student == null)
            {
                return NotFound();
            }
            else
            {
                Student = student;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            if (student != null)
            {
                Student = student;
                _context.Student.Remove(Student);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
