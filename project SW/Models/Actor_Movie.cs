namespace project_SW.Models
{
    public class Actor_Movie
    {
        public int ActorID { get; set; }
        public Movie Movie { get; set; }
        public int MovieID { get; set; }
        public Actor Actor { get; set; }
    }
}
