using CrazyBooks_Web.Models;
using CrazyBooks_Web.Models.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks.Controllers
{
  public class BookController : Controller
  {
        private CrazyBooksDbContext _database { get; set; }

        public BookController(CrazyBooksDbContext database)
        {
            _database = database;
        }


        public IActionResult Index()
        {

            List<Book> objList = _database.Book.ToList();

            return View(objList);
        }


        //GET CREATE
        public IActionResult Create()
        {
          return View();
        }

        //POST CREATE
        [HttpPost]
        public IActionResult Create(Book book)
        {
          if (ModelState.IsValid)
          {
                // Ajouter à la BD
                _database.Book.Add(book);
                _database.SaveChanges();
                return this.RedirectToAction("Index");
            }

          return this.View(book);
        }
  }
}
