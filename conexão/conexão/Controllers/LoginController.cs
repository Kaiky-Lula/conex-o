using Microsoft.AspNetCore.Mvc;
using conexão.Data;
using conexão.Models;
namespace conexão.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public LoginController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UsuarioDTO usuarioDTO)
        {
            var usuario = new Usuario
            {
                Nome = usuarioDTO.Nome,
                Sobrenome = usuarioDTO.Sobrenome,
                Email = usuarioDTO.Email,
                Senha = usuarioDTO.Senha,
                Confirmacao = usuarioDTO.Confirmacao,
            };
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return View();
        }
    }
}
