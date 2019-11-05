using Blog.DAO;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsuarioController : Controller
    {
        UsuarioDAO dao;
        public UsuarioController(UsuarioDAO Dao)
        {
            this.dao = Dao;
        }
        public IActionResult Adiciona(Usuario u)
        {
            if (ModelState.IsValid)
            {
                dao.inclui(u);
                return RedirectToAction("IndexU");
            }
            return View("NovoU", u);
        }
        public IActionResult AlterarU(int id)
        {
            return View(dao.ListarUm(id));
        }

        public IActionResult AlterarUs(Usuario u)
        {
            if (ModelState.IsValid)
                dao.Alterar(u);
            return RedirectToAction("IndexU");
        }

        public IActionResult DeletarU(Usuario u)
        {
            dao.Excluir(u);
            return RedirectToAction("IndexU");
        }

        public IActionResult NovoU()
        {
            return View(new Usuario());
        }

        public IActionResult IndexU()
        {
            return View(dao.Listar());
        }
    }
}