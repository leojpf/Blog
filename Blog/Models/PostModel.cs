using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        //public string Texto { get; set; }
        public string Categoria { get; set; }
        public string Resumo { get; set; }
        //public DateTime Data_Publicacao { get; set; }
        //public string Autor { get; set; }
    }
}
