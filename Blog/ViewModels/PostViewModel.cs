using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewModels
{
    public class PostViewModel
    {
        public PostViewModel(string titulo, string resumo, string categoria)
        {
            Titulo = titulo;
            Categoria = categoria;
            Resumo = resumo;
        }

        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Resumo { get; set; }
    }
}
