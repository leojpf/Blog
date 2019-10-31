using Blog.DAO;
using Blog.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Blog.Controllers
{
    public class AutenticacaoController : Controller
    {
        UsuarioDAO dao;
        public AutenticacaoController(UsuarioDAO Dao)
        {
            this.dao = Dao;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }
        [Route("Autentica")]
        public IActionResult Autentica(LoginViewModel lvm)
        {
            
            if (ModelState.IsValid)
            {
                var retorno = dao.Buscar(lvm.Login, lvm.Password);
                if (retorno != null) 
                {
                    HttpContext.Session.SetString("Usuario", JsonConvert.SerializeObject(retorno));
                    return RedirectToAction("Index", new { Area = "Admin", Controller = "Post" });
                }
                    
            }
            ModelState.AddModelError("LoginInvalido", "Usuário não encontrado");
            return View("Login", lvm);
        }

        public IActionResult Logout() 
        {
            HttpContext.Session.Remove("Usuario");
            return View("Login");
        }
    }
}