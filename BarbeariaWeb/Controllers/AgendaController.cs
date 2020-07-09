using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarbeariaWeb.Database;
using BarbeariaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BarbeariaWeb.Controllers
{
    public class AgendaController : Controller
    {
        private DatabaseContext _db;

        public AgendaController(DatabaseContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.agendas = _db.Agendas.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult NovaAgenda()
        {
            return View();

        }

    }
}
