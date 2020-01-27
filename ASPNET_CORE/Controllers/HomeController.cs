using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPNET_CORE.Models;
using ASPNET_CORE.DataBase;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore.Query;

namespace ASPNET_CORE.Controllers {
    public class HomeController : Controller {


        //para chamar o banco de dados, e conseguir mexer com ele   
        private readonly ApplicationDBContext DataBase;

        public HomeController(ApplicationDBContext database) {
            this.DataBase = database;
        }


        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger) {
        //    _logger = logger;
        //}

        public IActionResult Index() {
            return RedirectToAction("Index", "Funcionarios");
        }

        public IActionResult Teste() {
            //Categoria c1 = new Categoria();
            //c1.Nome = "vitor";
            //Categoria c2 = new Categoria();
            //c2.Nome = "vitor";
            //Categoria c3 = new Categoria();
            //c3.Nome = "erik";
            //Categoria c4 = new Categoria();
            //c4.Nome = "geovana";

            //List<Categoria> catlist = new List<Categoria>();
            //catlist.Add(c1);
            //catlist.Add(c2);
            //catlist.Add(c3);
            //catlist.Add(c4);

            //DataBase.AddRange(catlist);
            //DataBase.SaveChanges();
            var ListaDeCategorias = DataBase.categorias.Where(cat => cat.Id > 2).ToList();

            ListaDeCategorias.ForEach(categoria => {
                Console.WriteLine(categoria.ToString());
            });

            return View(ListaDeCategorias);
        }

        public IActionResult Relacionamento() {
            //Produto p1 = new Produto();
            //p1.Nome = "doritos";
            //p1.categoria = DataBase.categorias.First(cat => cat.Id == 1);
            //Produto p2 = new Produto();
            //p2.Nome = "hamburguer";
            //p2.categoria = DataBase.categorias.First(cat => cat.Id == 3);
            //Produto p3 = new Produto();
            //p3.Nome = "sucrilhos";
            //p3.categoria = DataBase.categorias.First(cat => cat.Id == 2);
            //Produto p4 = new Produto();
            //p4.Nome = "cachorro";
            //p4.categoria = DataBase.categorias.First(cat => cat.Id == 2);

            //DataBase.Add(p1);
            //DataBase.Add(p2);
            //DataBase.Add(p3);
            //DataBase.Add(p4);
            //DataBase.SaveChanges();

            var ListaProdutosUmaCategoria = DataBase.Produtos.Where(pro => pro.categoria.Id == 2).ToList();

            return View("relacionamento");

        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
