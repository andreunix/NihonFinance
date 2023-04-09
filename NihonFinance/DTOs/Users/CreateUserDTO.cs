using System.ComponentModel.DataAnnotations;

namespace NihonFinance.DTOs.Users
{
    public class CreateUserDTO
    {
        [Required(ErrorMessage = "Nome do Usuario é obrigatório")]
        [MaxLength(50, ErrorMessage = "Tamanho do nome do usuario muito grande")]
        [MinLength(2, ErrorMessage = "Tamanho do nome do usuario muito pequeno")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email do Usuario é obrigatório")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public string UserEmail { get; set; } = string.Empty;

        [Required(ErrorMessage = "Senha do Usuario é obrigatório")]
        public string UserPassword { get; set; } = string.Empty;
    }
}
