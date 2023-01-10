using ELibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace ELibrary.Controllers
{
    public class Signincontroller : Controller
    {
        private readonly AppDbContext _Db;

        public Signincontroller(AppDbContext Db)
        {
            _Db = Db;
        }

        public IActionResult Index()
        {
            //var daata = _Db.SigninModels.Where(x => x.username == username && x.password == password).FirstOrDefault();
            //_Db.DataModels.Remove(daata);
            //_Db.SaveChanges();
            //if (daata != null)
            //{
            //    return RedirectToAction("Index");
            //}
            //else
            //{
            //    return RedirectToAction("Index");
            var signinmodel = new SigninModel();
            return View(signinmodel);
            //}
        }


        public IActionResult Login(SigninModel model)
        {
            var daata = _Db.SigninModels.Where(x => x.username == model.username && x.password == model.password).FirstOrDefault();
            //_Db.DataModels.Remove(daata);
            //_Db.SaveChanges();
            if (daata != null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
                var signinmodel = new SigninModel();
            return View(signinmodel);
            }
        }
    }
}
