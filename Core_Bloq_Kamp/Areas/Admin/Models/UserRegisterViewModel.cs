using System.ComponentModel.DataAnnotations;

namespace Core_Bloq_Kamp.Areas.Admin.Models
{
    public class UserRegisterViewModel
    {
        [Display(Name = "Ad və Soyad")]
        [Required(ErrorMessage = "Boş verilən daxil edilə bilməz !!!")]
        public string _NameSurname { get; set; }

        [Display(Name = "İstifadəçi adı")]
        [Required(ErrorMessage = "Boş verilən daxil edilə bilməz !!!")]
        public string _Username { get; set; }

        [Display(Name = "E-Poçt ünvanı")]
        [Required(ErrorMessage = "Boş verilən daxil edilə bilməz !!!")]
        public string _Email { get; set; }

        [Display(Name = "Şifrə")]
        [Required(ErrorMessage = "Boş verilən daxil edilə bilməz !!!")]
        public string _Password { get; set; }


        [Display(Name = "Təktar şifrə")]
        [Compare("Password", ErrorMessage = "Boş verilən daxil edilə bilməz !!!")]
        public string _ConfirmPassword { get; set; }
    }
}
