using System.ComponentModel.DataAnnotations;

namespace CrazyBooks_Web.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

       
        //Propriété de navigation 1 à 1
        public AuthorDetail AuthorDetail { get; set; }
    }
}
