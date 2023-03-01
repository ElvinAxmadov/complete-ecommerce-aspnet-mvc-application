using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        //Relationships
        public virtual ICollection<Actor_Movie> Actor_Movies { get; set; }
        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey(nameof(CinemaId))]
        public virtual Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey(nameof(ProducerId))]
        public virtual Producer Producer { get; set; }
        public Movie()
        {

            Actor_Movies = new HashSet<Actor_Movie>();
        }

        public Movie(int movieId, string name, string description, double price, string imageUrl, DateTime startDate, DateTime endDate, int cinemaId, int producerId)
        {
            MovieId = movieId;
            Name = name;
            Description = description;
            Price = price;
            ImageUrl = imageUrl;
            StartDate = startDate;
            EndDate = endDate;
            CinemaId = cinemaId;
            ProducerId = producerId;
        }
    }
}
