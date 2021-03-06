using System.ComponentModel.DataAnnotations;

namespace curso.API.Models.Usuarios
{
    /// <summary>
    /// Model de registro do usuário
    /// </summary>
    public class RegistroViewModelInput
    {
        [Required(ErrorMessage ="O Login é obrigatório")]
        public string Login { get; set; }
        [Required(ErrorMessage ="O E-mail é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage ="A Senha é obrigatória")]
        public string Senha { get; set; }
    }
}
