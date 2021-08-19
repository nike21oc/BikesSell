using BikesSell.AppAdContect;
using BikesSell.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikesSell.Controllers
{
    public class ModelController : Controller
    {
        private readonly VroomDbContext _db;

        public MakeModelViewModel MakeModel;
        public ModelController(VroomDbContext dbContext)
        {
            _db = dbContext;
            MakeModel = new MakeModelViewModel()
            {
                Makes = _db.Makes.ToList(),
                Model = new Models.Model()
            };
        }
        public IActionResult Index()
        {
            var data = _db.Models.Include(x => x.Make);
            return View();
        }

        public IActionResult Create()
        {
           // var data = _db.Models.Include(x => x.Make);
            return View();
        }
        public IActionResult Edit()
        {
            // var data = _db.Models.Include(x => x.Make);
            return View();
        }
    }
}
