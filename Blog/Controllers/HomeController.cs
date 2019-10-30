using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blog.Models;
using Blog.DAO;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        PostDAONovo dao;
        public HomeController(PostDAONovo Dao)
        {
            dao = Dao;
        }
        public IActionResult Index()
        {
            return View(dao.Listar().Where(p => p.Publicado).OrderByDescending(p => p.Data_Publicacao).ToList());
        }
        public IActionResult Buscar(string termo)
        {
            var retorno = dao.Listar().Where(p => (p.Publicado) && (p.Titulo.Contains(termo) || p.Resumo.Contains(termo)))
                .Select(p => p)
                .ToList();
            return View("Index", retorno);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
