using Microsoft.AspNetCore.Identity;

namespace Theatre.Web.Models
{
    public class User : IdentityUser
    {
        public String? Firstname { get; set; }
        public String? Lastname { get; set; }
        public String? Address { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }
    }
}
