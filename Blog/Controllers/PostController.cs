using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Blog.DAO;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        //PostDAO dao;
        PostDAONovo dao;
        public PostController(PostDAONovo Dao)
        {
            this.dao = Dao;
        }

        public IActionResult Index()
        {
            return View(dao.Listar());            
        }

        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Adiciona(PostModel p)
        {
            dao.Adiciona(p);
            return View("Index", dao.Listar());            
        }
        public IActionResult Excluir(PostModel p)
        {
            dao.Excluir(p);
            return View("Index", dao.Listar());
        }
        public IActionResult Alterar(PostModel p)
        {
            return View(dao.ListarUm(p));

        }
        public IActionResult Alterars(PostModel p)
        {
            dao.Alterar(p);
            return View("Index", dao.Listar());

        }

    }
}

////Idbcommand IdataReader