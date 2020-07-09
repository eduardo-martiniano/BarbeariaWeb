using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarbeariaWeb.Database;
using BarbeariaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BarbeariaWeb.Controllers
{
    public class ClienteController : Controller
    {
        private DatabaseContext _db;

        public ClienteController(DatabaseContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro([FromForm] Cliente cliente)
        {
            _db.Add(cliente);
            _db.SaveChanges();
            ViewBag.Mensagem = "Cadastrado com sucesso!";
            return View();
        }
        [HttpPost]
        public IActionResult Logar([FromForm] Cliente cliente)
        {
            var cpf = cliente.Cpf;
            var clientes = _db.Clientes.ToList();
            foreach (var pessoa in clientes)
            {
                if (pessoa.Cpf == cpf)
                {
                    return RedirectToAction("Index","Servico");
                }

            }
            ViewBag.Erro = "Verifique os dados!";
            return View("Index");

        }
    }
}
