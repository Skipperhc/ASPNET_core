using Microsoft.AspNetCore.Mvc;
using ASPNET_CORE.Models;
using ASPNET_CORE.DataBase;
using System.Linq;
using System;

namespace ASPNET_CORE.Controllers {
    public class FuncionariosController : Controller {


        private readonly ApplicationDBContext DataBase;

        public FuncionariosController(ApplicationDBContext database) {
            this.DataBase = database;
        }

        public IActionResult Index() {
            var funcionarios = DataBase.Funcionarios.ToList();
            return View(funcionarios);
        }

        public IActionResult Cadastrar() {
            return View();
        }
        public IActionResult Editar() {
            return View("Cadastrar");
        }
        
        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario) {
            DataBase.Funcionarios.Add(funcionario);
            DataBase.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
