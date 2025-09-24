using AuthAPI.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace AuthAPI.DTOs
{
    public class UsuarioCriacaoDto
    {
        [Required(ErrorMessage ="Nome obrigatorio")]
        public string NomeUsuario { get; set; }
        [Required(ErrorMessage = "Email obrigatorio"), EmailAddress(ErrorMessage ="Email Invalido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "senha obrigatorio")]
        public string Senha { get; set; }
        [Compare("Senha", ErrorMessage ="Senhas nao coincidem ")]
        public string ConfirmaSenha { get; set; }
        [Required(ErrorMessage ="campo cargo obrigatorio")]
        public CargoEnum Cargo { get; set; }



    }
}
