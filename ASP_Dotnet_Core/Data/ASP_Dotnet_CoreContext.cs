using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_Dotnet_Core.Models;

namespace ASP_Dotnet_Core.Data
{
    public class ASP_Dotnet_CoreContext : DbContext
    {
        public ASP_Dotnet_CoreContext (DbContextOptions<ASP_Dotnet_CoreContext> options)
            : base(options)
        {
        }

        public DbSet<ASP_Dotnet_Core.Models.Students> Student { get; set; } = default!;
    }
}
