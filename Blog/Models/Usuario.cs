using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Usuario
    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Login { get; set; }
        [Required]
        [StringLength(100)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required]
        [StringLength(200)]
        public string Email { get; set; }
        public IList<PostModel> Posts { get; set; }
    }
}
