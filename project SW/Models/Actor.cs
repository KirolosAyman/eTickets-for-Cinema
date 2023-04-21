using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace project_SW.Models
{
    public class Actor
    {
        [Key]
        public int ID { get; set; }
        public String profilePicture { get; set; }
        public String fullName { get; set; }
        public String Bio { get; set; }

        // Relationship

        public List<Actor_Movie> Actors_Movie { get; set; }
    }
}
