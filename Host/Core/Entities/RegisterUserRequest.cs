using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public record RegisterUserRequest(
        [Required] string UserName,
        [Required] string Password,
        [Required] string Email);
}
