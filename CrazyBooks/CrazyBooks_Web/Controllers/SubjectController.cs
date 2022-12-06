using CrazyBooks_Web.Models;
using CrazyBooks_Web.Models.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks.Controllers
{
  public class SubjectController : Controller
  {
        // Injection du DbContext
    private CrazyBooksDbContext _database { get; set; }

        public SubjectController(CrazyBooksDbContext database)
        {
            _database = database;
        }
        
        
        public IActionResult Index()
    {
         List<Subject> objList = _database.Subject.ToList();

            return View(objList);
    }

    //GET CREATE
    public IActionResult Create()
    {
      return View();
    }

    //POST CREATE
    [HttpPost]
    public IActionResult Create(Subject subject)
    {
      if (ModelState.IsValid)
      {
                // Ajouter à la BD
                _database.Subject.Add(subject);
                _database.SaveChanges(); //sinon pas d'enregistrement physique sur la BD
                return this.RedirectToAction("Index");
      }

      return this.View(subject);
    }
  }
}
