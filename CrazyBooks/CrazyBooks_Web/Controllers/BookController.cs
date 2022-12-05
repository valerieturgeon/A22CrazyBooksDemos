using CrazyBooks_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks.Controllers
{
  public class BookController : Controller
  {
        private Database _database { get; set; }

        public BookController(Database database)
        {
            _database = database;
        }


        public IActionResult Index()
        {

            List<Book> objList = _database.Books.ToList();

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
                _database.Books.Add(book);
                return this.RedirectToAction("Index");
            }

          return this.View(book);
        }
  }
}
