using project_SW.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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


        // Relationship 

        public List<Actor_Movie> Actors_Movie { get; set; }

        public int CinemaID { get; set; }
        [ForeignKey("CinemaID")]
        public  Cinema Cinema { get; set; }


        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]
        public Producer Producer { get; set; }


    }
}
