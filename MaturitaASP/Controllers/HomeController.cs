using MaturitaASP.Models.Bikes;
using Microsoft.AspNetCore.Mvc;

namespace MaturitaASP.Controllers
{
    public class HomeController : Controller
    {
        private BikeRepository _table = new BikeRepository();

        public IActionResult Index()
        {
            this.ViewBag.Bikes = this._table.SelectAll();
            return View();
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Bike bike)
        {
            /*ptáme se formuláře, zda je validní -> 1/0 Ano/Ne True/False*/
            if (this.ModelState.IsValid)
            {
                /*pokud ano*/
                this._table.Insert(bike);
                return RedirectToAction("Index");
            }

            /*pokud ne, tak zůstanu, tam kde jsem, abych si ty data mohl opravit*/
            return View();
        }
    }
}
