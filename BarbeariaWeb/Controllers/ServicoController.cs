using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarbeariaWeb.Database;
using BarbeariaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BarbeariaWeb.Controllers
{
    public class ServicoController : Controller
    {
        private DatabaseContext _db;
        public ServicoController(DatabaseContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
          //  var servicos = _db.Servicos.ToList();
            ViewBag.servicos = _db.Servicos.ToList(); ;
            return View();
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar([FromForm] Servico servico)
        {

            _db.Add(servico);
            _db.SaveChanges();
            return RedirectToAction("Index", "Servico");
        }
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            _db.Servicos.Remove(_db.Servicos.Find(id));
            _db.SaveChanges();
            return RedirectToAction("Index", "Servico");

        }


    }
}
