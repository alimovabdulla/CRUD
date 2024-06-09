using Microsoft.AspNetCore.Mvc;
using Tests.DataBase;
using Tests.Entities;

namespace Tests.Controllers
{
    public class PersonController : Controller
    {
        private readonly ClassContext _classContext;
        public PersonController(ClassContext classContext)
        {
            _classContext = classContext;
        }
        public IActionResult Index()
        {
            List<Name> name = _classContext.names.ToList();
            return View(name);
        }
        [HttpGet]
        public IActionResult Create()
        {



            return View();
        }

        [HttpPost]
        public IActionResult Create(Name name)
        {

            _classContext.names.Add(name);
            _classContext.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]

        public IActionResult Update(int id)
        {
            Name existname = _classContext.names.FirstOrDefault(name => name.Id == id);

            return View(existname);
        }

        public IActionResult Update(Name newname)
        {
            Name oldname = _classContext.names.FirstOrDefault(name => name.Id == newname.Id);
            oldname.Ad = newname.Ad;
            oldname.Soyad = newname.Soyad;
            _classContext.SaveChanges();
            return RedirectToAction("index");


        }
        public IActionResult Delete(int id)
        {
            Name name = _classContext.names.FirstOrDefault(n => n.Id == id);
            _classContext.names.Remove(name);
            _classContext.SaveChanges();
            return RedirectToAction("Index");


        }





    }
}
