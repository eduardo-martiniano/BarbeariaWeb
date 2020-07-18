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
            
            ViewBag.Servicos = _db.Servicos.ToList();
            return View();

        }
        [HttpPost]
        public IActionResult NovaAgenda([FromForm] Agenda agenda)
        {
            
            if (ModelState.IsValid)
            {
                Agenda a = agenda;
                string nomeServico = a.Servico;
                double valorServico = 0;
                foreach (var item in _db.Servicos)
                {
                    if (nomeServico == item.Nome)
                    {
                        valorServico = item.Valor;
                    }
                }
                a.Valor = valorServico;                             
                    _db.Agendas.Add(a);
                    _db.SaveChanges();
                    return RedirectToAction("Index", "Agenda");
            }

            else
            {
                ViewBag.Servicos = _db.Servicos.ToList();
                return View();
                
            }
        }

    }
}
