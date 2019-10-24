using Blog.ViewModels;
using System.Collections.Generic;
using System.Data;

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

            var prmTitulo = cmd.CreateParameter();
            prmTitulo.ParameterName = "Titulo";
            prmTitulo.Value = p.Titulo;
            cmd.Parameters.Add(prmTitulo);

            var prmResumo = cmd.CreateParameter();
            prmTitulo.ParameterName = "Resumo";
            prmTitulo.Value = p.Resumo;
            cmd.Parameters.Add(prmResumo);

            var prmRCategoria = cmd.CreateParameter();
            prmTitulo.ParameterName = "Categoria";
            prmTitulo.Value = p.Categoria;
            cmd.Parameters.Add(prmRCategoria);

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
