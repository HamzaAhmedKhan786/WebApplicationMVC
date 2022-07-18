using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models
{
    public class Movies
    {
        [Key]
        public Guid M_ID { get; set; }
        [Required]
        public string Movie_Name { get; set; }
        public DateTime Movie_ReleaseDate { get; set; }
        public int Movie_Rating { get; set; }
        public string Genre { get; set; }
        public string Casts { get; set; }

    }
}
