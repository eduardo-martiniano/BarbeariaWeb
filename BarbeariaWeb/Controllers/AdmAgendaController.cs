using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarbeariaWeb.Database;
using Microsoft.AspNetCore.Mvc;

namespace BarbeariaWeb.Controllers
{
    public class AdmAgendaController : Controller
    {
        private DatabaseContext _db;

        public AdmAgendaController(DatabaseContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.agendas = _db.Agendas.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult Excluir(int id)
        {

            _db.Agendas.Remove(_db.Agendas.Find(id));
            _db.SaveChanges();
            return RedirectToAction("Index", "AdmAgenda");
        }
    }
}
