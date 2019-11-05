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
            cnx.SaveChanges();
        }

        public void Alterar(Usuario u)
        {
            cnx.Usuarios.Update(u);
            cnx.SaveChanges();
        }

        public void Excluir(Usuario u)
        {
            cnx.Usuarios.Remove(u);
            cnx.SaveChanges();
        }
        public Usuario ListarUm(int u)
        {
            return cnx.Usuarios.Where(s => s.Id == u).FirstOrDefault();
        }

        public IEnumerable<Usuario> Listar()
        {
            return cnx.Usuarios.Where(s => s.Id > 0);
        }

    }
}
