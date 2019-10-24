using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewModels
{
    public class PostViewModel
    {
        public PostViewModel()
        {
        }

        public PostViewModel(PostViewModel p)
        {
            Titulo = p.Titulo;
            Resumo = p.Resumo;
            Categoria = p.Categoria;
        }
        
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Resumo { get; set; }
    }
}
