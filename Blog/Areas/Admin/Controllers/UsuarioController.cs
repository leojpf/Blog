using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.DAO;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Areas.Admin.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioDAO dao;
        public UsuarioController(UsuarioDAO Dao)
        {
            this.dao = Dao;
        }
        public IActionResult Adiciona()
        {
            return View();
        }

        public IActionResult Altera()
        {
            return View();
        }

        public IActionResult Deleta()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}