using Blog.Infra;
using Blog.ViewModels;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Blog.DAO
{
    public class PostDAO
    {
        IDbConnection cnx;
        public PostDAO(IDbConnection connection)
        {
            cnx = connection;
        }

        public void Adiciona(PostViewModel p)
        {
            var cmd = cnx.CreateCommand();
            string query = "Insert into Posts (Titulo, Resumo, Categoria)" +
                          "Values (@1,@2,@3)";
            cmd.CommandText = query;
            cmd.Parameters.Add(new SqlParameter("1", p.Titulo));
            cmd.Parameters.Add(new SqlParameter("2", p.Resumo));
            cmd.Parameters.Add(new SqlParameter("3", p.Categoria));
            cmd.ExecuteNonQuery();
        }

        public List<PostViewModel> Listar()
        {
            var lista = new List<PostViewModel>();
            var cmd = cnx.CreateCommand();
            string query = "Select titulo,resumo,categoria from Posts";
            cmd.CommandText = query;
            IDataReader drd = cmd.ExecuteReader();

            while (drd.Read())
            {
                PostViewModel p = new PostViewModel();
                p.Titulo = drd.GetString(0);
                p.Resumo = drd.GetString(1);
                p.Categoria = drd.GetString(2);
                lista.Add(p);
            }
            return lista;

        }
    }
}
