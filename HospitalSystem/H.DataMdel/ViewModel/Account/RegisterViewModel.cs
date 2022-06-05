using H.Common.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.DataMdel.ViewModel.Account
{
    public class RegisterViewModel
    {   
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = AttributesErrorMessages.RequiredMessage)]
        [MaxLength(30, ErrorMessage = AttributesErrorMessages.MaxLengthMessage)]
        public string? UserName { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = AttributesErrorMessages.RequiredMessage)]
        [MinLength(6, ErrorMessage = AttributesErrorMessages.MinLengthMessage)]
        [MaxLength(30, ErrorMessage = AttributesErrorMessages.MaxLengthMessage)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = AttributesErrorMessages.RequiredMessage)]
        [EmailAddress(ErrorMessage = AttributesErrorMessages.RegularExpressionMessage)]
        public string? Email { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = AttributesErrorMessages.RequiredMessage)]
        [MinLength(6, ErrorMessage = AttributesErrorMessages.MinLengthMessage)]
        [MaxLength(30, ErrorMessage = AttributesErrorMessages.MaxLengthMessage)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage = AttributesErrorMessages.CompareMessage)]
        public string? ConfirmPassword { get; set; }
    }
}
