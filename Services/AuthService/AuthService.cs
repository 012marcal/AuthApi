using AuthAPI.Data;
using AuthAPI.DTOs;
using AuthAPI.DTOs.MappingExtensions;
using AuthAPI.Models;
using AuthAPI.Services.SenhaService;
using Microsoft.EntityFrameworkCore;

namespace AuthAPI.Services.AuthService
{
    public class AuthService : IAuthService

    {
        private readonly AppDbContext _context;
        private readonly ISenhaService _senhaService;

        public AuthService(AppDbContext context, ISenhaService senhaService)
        {
            _context = context;
            _senhaService = senhaService;
            
        }


        public async Task<UsuarioCriacaoDto> Registrar(UsuarioCriacaoDto usuarioRegistro)
        {
            if (await EmailOuUsuarioJaExiste(usuarioRegistro))
                return null;

            Usuario user = usuarioRegistro.ToUsuario(_senhaService);
            _context.Add(user);
            await _context.SaveChangesAsync();

            return user.ToUsuarioCriacaoDTO();

        }

        public async Task< bool> EmailOuUsuarioJaExiste(UsuarioCriacaoDto usuarioRegistro)
        {
            return await _context.Usuarios
            .AnyAsync(u => u.Email == usuarioRegistro.Email || u.NomeUsuario == usuarioRegistro.NomeUsuario);

        }
    }
}
