using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models
{
    public class Movies
    {
        [Key]
        public Guid M_ID { get; set; }
        [Required]
        [DisplayName("Movie Name")]
        public string Movie_Name { get; set; }
        [Required]
        [DisplayName("Release Date")]
        public DateTime Movie_ReleaseDate { get; set; }
        [Required]
        [DisplayName("Rating")]
        [Range(1,5)]
        public int Movie_Rating { get; set; }
        [Required]
        [DisplayName("Genre")]
        public string Genre { get; set; }
        [Required]
        [DisplayName("Casts")]
        public string Casts { get; set; }

    }
}
