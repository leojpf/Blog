﻿using Blog.Infra;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog.DAO
{
    public class PostDAONovo
    {
        BlogContext cnx;
        public PostDAONovo(BlogContext contexto)
        {
            cnx = contexto;
        }

        public void Adiciona(PostModel p)
        {
            cnx.Usuarios.Attach(p.Autor);
            cnx.Posts.Add(p);
            cnx.SaveChanges();
        }

        public IEnumerable<PostModel> Listar()
        {
            return cnx.Posts.Include(p=> p.Autor);
        }
        public void Alterar(PostModel p)
        {
            cnx.Posts.Update(p);
            cnx.SaveChanges();
        }

        public void Excluir(PostModel p)
        {
            cnx.Posts.Remove(p);
            cnx.SaveChanges();
        }

        public PostModel ListarUm(int p)
        {
            return cnx.Posts.Where(s => s.Id == p).FirstOrDefault();
        }

        public void Publica(PostModel p)
        {
            PostModel post = cnx.Posts.Find(p.Id);
            post.Publicado = true;
            post.Data_Publicacao = DateTime.Now;
            cnx.SaveChanges();
        }
    }
}
