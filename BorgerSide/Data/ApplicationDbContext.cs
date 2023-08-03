using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BorgerSide.Models;

namespace BorgerSide.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BorgerSide.Models.BorgerTip>? BorgerTip { get; set; }
        public DbSet<BorgerSide.Models.OlietankFormular>? OlietankFormular { get; set; }
       
    }
}