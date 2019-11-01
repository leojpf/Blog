using Blog.Infra;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DAO
{
    public class UsuarioDAO
    {
        BlogContext cnx;
        public UsuarioDAO(BlogContext contexto)
        {
            cnx = contexto;
        }

        public Usuario Buscar(string login, string senha) 
        {
            return cnx.Usuarios.Where(p => p.Login == login && p.Senha == senha).FirstOrDefault();
            /*
             * return cnx.Usuario.FirstOrDefault(p => p.Login == login && p.Senha == senha)
             */
        }

        public void inclui(Usuario u)
        {
            cnx.Usuarios.Add(u);            
        }

    }
}
