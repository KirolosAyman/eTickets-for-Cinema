using System.ComponentModel.DataAnnotations;

namespace project_SW.Models
{
    public class Cinema
    {
        [Key]
        public int ID { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
    }
}
