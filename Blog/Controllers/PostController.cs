﻿using Blog.DAO;
using Blog.Models;
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
            return View(new PostModel());
        }
        [HttpPost]
        public IActionResult Adiciona(PostModel p)
        {
            if (ModelState.IsValid)
            {
                dao.Adiciona(p);
                return RedirectToAction("Index");
            }
            return View("Novo", p);

        }
        public IActionResult Excluir(PostModel p)
        {
            dao.Excluir(p);
            return RedirectToAction("Index");
        }
        public IActionResult Alterar(PostModel p)
        {
            if (!p.Publicado && !p.Data_Publicacao.HasValue)
            {
                ModelState.AddModelError("Publicacao", "Post ainda não publicado");
            }
            if (ModelState.IsValid)
                return View(dao.ListarUm(p));

            return RedirectToAction("Index", p);

        }
        public IActionResult Alterars(PostModel p)
        {
            dao.Alterar(p);
            return RedirectToAction("Index");

        }
        public IActionResult Publicar(PostModel p)
        {
            dao.Publica(p);
            return RedirectToAction("Index");
        }
    }
}

////Idbcommand IdataReader