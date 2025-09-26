using AuthAPI.Models;
using AuthAPI.Services.SenhaService;

namespace AuthAPI.DTOs.MappingExtensions
{
    public static class UsuarioCriacaoDtoMapping
    {
        public static UsuarioCriacaoDto ToUsuarioCriacaoDTO(this Usuario user)
        {
            if (user == null) return null;

            return new UsuarioCriacaoDto
            {
               NomeUsuario = user.NomeUsuario,
               Email = user.Email,
               Cargo = user.Cargo,

            };

        }

        public static Usuario ToUsuario(this UsuarioCriacaoDto dto, ISenhaService senhaService)
        {
            if (dto == null) return null;

            senhaService.CriarSenhaHash(dto.Senha, out byte[] senhaHash, out byte[] senhaSalt);

            return new Usuario
            {
                NomeUsuario = dto.NomeUsuario,
                Email = dto.Email,
                Cargo = dto.Cargo,
                SenhaHash = senhaHash,
                SenhaSalt = senhaSalt
            };
        }

        public static IEnumerable<UsuarioCriacaoDto> ToUsuarioDTOList(this IEnumerable<Usuario> user)
        {
            if(user == null || !user.Any()) return new List<UsuarioCriacaoDto>();

            return user.Select(u => new UsuarioCriacaoDto
            {
                NomeUsuario = u.NomeUsuario,
                Email = u.Email,
                Cargo = u.Cargo,
            }).ToList();

        }
    }
}
