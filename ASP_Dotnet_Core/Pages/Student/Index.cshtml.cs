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
    public class IndexModel : PageModel
    {
        private readonly ASP_Dotnet_Core.Data.ASP_Dotnet_CoreContext _context;

        public IndexModel(ASP_Dotnet_Core.Data.ASP_Dotnet_CoreContext context)
        {
            _context = context;
        }

        public IList<Students> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
