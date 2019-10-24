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
        List<PostViewModel> lista = new List<PostViewModel>();
        PostDAO dao;
        public PostController(PostDAO Dao)
        {
            this.dao = Dao;
        }

        public IActionResult Index()
        {
            return View(dao.Listar());
            //return View(lista);
        }

        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Adiciona(PostViewModel p)
        {
            dao.Adiciona(p);
            return View("Index", dao.Listar());
            
        }
    }
}

////Idbcommand IdataReader