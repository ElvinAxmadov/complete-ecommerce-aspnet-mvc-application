using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships
        public virtual ICollection<Movie> Movies { get; set;}
        public Producer()
        {

        }

        public Producer(int producerId, string profilePictureURL, string fullName, string bio)
        {
            ProducerId = producerId;
            ProfilePictureURL = profilePictureURL;
            FullName = fullName;
            Bio = bio;
        }
    }
}
