using System.ComponentModel.DataAnnotations;

namespace project_SW.Models
{
    public class Producer
    {
        [Key]
        public int ID { get; set; }
        public String profilePicture { get; set; }
        public String fullName { get; set; }
        public String Bio { get; set; }

        // Relationships 

        public List<Movie> Movies { get; set; }


    }
}
