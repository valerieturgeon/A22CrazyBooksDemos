
using System.ComponentModel.DataAnnotations;

namespace CrazyBooks_Web.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Speciality { get; set; }

        //Propriété de navigation 1 à plusieurs, côté plusieurs
        public List<Book> Books { get; set; }
    }
}
