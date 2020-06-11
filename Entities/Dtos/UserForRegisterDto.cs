using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concreate
{
    public class UserForRegisterDto : IDto
    {
        [Required(ErrorMessage = "Lütfen E Posta Adresi Giriniz")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        [StringLength(20, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }

    }
}
