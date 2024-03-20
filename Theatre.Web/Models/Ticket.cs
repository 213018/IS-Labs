namespace Theatre.Web.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public int? Price { get; set; }

        public string? UserId { get; set; }
        public User? User { get; set; }

        public Guid? TheatreShowId { get; set; }
        public TheatreShow? TheatreShow {  get; set; }
    }
}
