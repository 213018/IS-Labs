using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Theatre.Web.Models;

namespace Theatre.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<TheatreShow> TheatreShows { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        
    }
}
