using System.ComponentModel.DataAnnotations;

namespace FreeCourse.IdentityServer.Dtos
{
    public class SignUpDto
    {
        [Required(ErrorMessage ="İstifadəçi adı daxil edin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "E-poçt daxil edin")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifrə daxil edin")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şəhər daxil edin")]
        public string City { get; set; }
    }
}
