using BikesSell.AppAdContect;
using BikesSell.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikesSell.Controllers
{
    public class MakeController : Controller
    {
        private readonly VroomDbContext _db;
        public MakeController(VroomDbContext dbContext)
        {
            _db = dbContext;
        }
        public IActionResult Index()
        {
            var list = _db.Makes.ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Make make)
        {
            if(ModelState.IsValid)
            {
                _db.Add(make);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            var make = _db.Makes.Find(id);
            if(make==null)
            {
                return NotFound();
            }
            return View(make);
        }

        [HttpPost]
        public IActionResult Edit(Make make)
        {
            if (ModelState.IsValid)
            {
                    _db.Makes.Update(make);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
               
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var make = _db.Makes.Find(id);
            if(make==null)
            {
                return NotFound();
            }
            else
            {
                _db.Remove(make);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
