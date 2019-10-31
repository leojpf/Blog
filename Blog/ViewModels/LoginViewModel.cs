using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Usuário")]
        public string Login { get; set; }
        [Required]
        [Display(Name ="Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
