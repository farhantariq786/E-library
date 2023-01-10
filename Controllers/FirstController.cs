using Microsoft.AspNetCore.Mvc;
using ELibrary.Models;

namespace ELibrary.Controllers
{
    public class FirstController : Controller
    {
        private readonly AppDbContext _Db;

        public FirstController(AppDbContext Db)
        {
            _Db=Db;
        }

        public IActionResult Index()
        {
            var datalist= _Db.DataModels.ToList();
            return View(datalist);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DataModel model)
        {
            _Db.DataModels.Add(model);
            _Db.SaveChanges();
            return View();
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = _Db.DataModels.Where(x => x.StdId == id).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(DataModel model)
        {
            var data = _Db.DataModels.Where(x => x.StdId == model.StdId).FirstOrDefault();
            if (data != null)
            {
                data.Name=model.Name;
                data.Email=model.Email;
                data.Password=model.Password;
                data.Age=model.Age;
                _Db.SaveChanges();
            }
                return View(data);
        }
        
        public IActionResult Details(int id)
        {
            var data= _Db.DataModels.Where(x => x.StdId == id).FirstOrDefault();
            return View(data);
        }


        public IActionResult Delete(int id)
        {
            var daata = _Db.DataModels.Where(x => x.StdId == id).FirstOrDefault();
            _Db.DataModels.Remove(daata);
            _Db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
