using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks_Web.Models
{
    public class Database
    {
        public List<Book> Books { get; set; }
        public List<Subject> Subjects { get; set; }

        public Database()
        {

            Subjects = new List<Subject>();
                Subjects.Add(new Subject() { Name = "Thriller", Id = 1 });
                Subjects.Add(new Subject(){Name= "Biographie", Id=2});
                Subjects.Add(new Subject(){Name= "Drame", Id=3});
                Subjects.Add(new Subject(){Name= "Ressources humaines", Id=4});
        

            Books = new List<Book>();
                Books.Add(new Book() { Id = 1, Title = "Cobayes", ISBN = "9782896623921" });
                Books.Add(new Book() { Id = 2, Title = "Enlèvement", ISBN = "9782896626151" });
                Books.Add(new Book() { Id = 3, Title = "Le chiffreur", ISBN = "9782890747364" });
                Books.Add(new Book() { Id = 4, Title = "Les Maudits", ISBN = "9782896628773" });
            

           
        }
    }
}
