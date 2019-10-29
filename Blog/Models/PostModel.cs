using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Digite no máximo 50 caracteres")][Display(Name ="Título", Prompt ="Título")]
        public string Titulo { get; set; }
        [Required]
        [Display(Name = "Categoria", Prompt = "Categoria")]
        public string Categoria { get; set; }
        [Required]
        [Display(Name = "Resumo", Prompt = "Resumo")]
        public string Resumo { get; set; }
        public DateTime? Data_Publicacao { get; set; }
        public bool Publicado { get; set; }
        //public string Autor { get; set; }
    }
}
