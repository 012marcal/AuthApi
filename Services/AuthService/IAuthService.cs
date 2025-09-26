using AuthAPI.DTOs;

namespace AuthAPI.Services.AuthService
{
    public interface IAuthService
    {
        Task<UsuarioCriacaoDto> Registrar(UsuarioCriacaoDto usuarioRegistro);
        Task<bool> EmailOuUsuarioJaExiste(UsuarioCriacaoDto usuarioRegistro);


    }
}
