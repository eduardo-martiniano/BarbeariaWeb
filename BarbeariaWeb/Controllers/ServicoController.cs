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
            ViewBag.servicos = _db.Servicos.ToList(); 
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
            if (ModelState.IsValid)
            {
                _db.Add(servico);
                _db.SaveChanges();
                return RedirectToAction("Index", "Servico");

            }
            else
            {
                return View();
            }


        }
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            _db.Servicos.Remove(_db.Servicos.Find(id));
            _db.SaveChanges();
            return RedirectToAction("Index", "Servico");

        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            Servico s = _db.Servicos.Find(id);
            ViewBag.Nome = s.Nome;
            ViewBag.Valor = s.Valor;
            ViewBag.Id = s.Id;
            return View("Atualizar", s);
        }
        [HttpPost]
        public IActionResult Atualizar([FromForm] Servico s)
        {
            _db.Servicos.Update(s);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
