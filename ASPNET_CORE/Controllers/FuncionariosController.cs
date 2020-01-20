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
        public IActionResult Editar(int id) {
            Funcionario funcionario = DataBase.Funcionarios.First(Registro => Registro.Id == id);
            return View("Cadastrar", funcionario);
        }

        public IActionResult Deletar(int id) {
            Funcionario funcionario = DataBase.Funcionarios.First(Registro => Registro.Id == id);
            DataBase.Funcionarios.Remove(funcionario);
            DataBase.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario) {
            if (funcionario.Id == 0) {
                DataBase.Funcionarios.Add(funcionario);
                DataBase.SaveChanges();
            } else {
                Funcionario FuncionarioDoBanco = DataBase.Funcionarios.First(registro => registro.Id == funcionario.Id);
                FuncionarioDoBanco.Nome = funcionario.Nome;
                FuncionarioDoBanco.Cpf= funcionario.Cpf;
                FuncionarioDoBanco.Salario = funcionario.Salario;
            }
            DataBase.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
