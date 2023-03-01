using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor: IEntityBase
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationships
        public virtual ICollection<Actor_Movie> Actor_Movies { get; set; }
        public Actor()
        {
            Actor_Movies = new HashSet<Actor_Movie>();
        }

        public Actor(int actorId, string profilePictureURL, string fullName, string bio)
        {
            ActorId = actorId;
            ProfilePictureURL = profilePictureURL;
            FullName = fullName;
            Bio = bio;
        }
    }
}
