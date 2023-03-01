using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Display(Name = "Cinema Description")]
        public string Description { get; set; }

        //Relationships
        public virtual ICollection<Movie> Movies { get; set; }
        public Cinema()
        {

        }

        public Cinema(int cinemaId, string logo, string name, string description)
        {
            CinemaId = cinemaId;
            Logo = logo;
            Name = name;
            Description = description;
        }
    }
}
