using project_SW.Data;
using System.ComponentModel.DataAnnotations;

namespace project_SW.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }

        public string? Discription { get; set; }
        
        public double Price { get; set; }

        public string? ImageURL { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

    }
}
