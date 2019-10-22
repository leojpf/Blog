﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        public ViewResult Index()
        {
            var lista = new List<PostViewModel>();

            lista.Add(new PostViewModel("HP 1", "Resumo_HP1", "Categoria_HP1"));
            lista.Add(new PostViewModel("HP 2", "Resumo_HP2", "Categoria_HP2"));
            lista.Add(new PostViewModel("HP 3", "Resumo_HP3", "Categoria_HP3"));

            return View(lista);
        }
    }
}