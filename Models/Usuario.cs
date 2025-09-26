using AuthAPI.Models.Enum;

namespace AuthAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string NomeUsuario { get; set; }
        public CargoEnum Cargo { get; set; }
        public byte[] SenhaHash { get; set; }
        public byte[] SenhaSalt { get; set; }
        public DateTime TokeDataCriacao { get; set; } = DateTime.UtcNow;


    }
}
