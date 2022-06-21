using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok_Project.ViewModels
{
    public class MemberRegisterViewModel
    {
        [Required]
        [MaxLength(25)]
        [MinLength(6)]
        public string RegisterUserName { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(4)]
        public string RegisterFullName { get; set; }
        [Required]
        [MaxLength(100)]
        public string RegisterEmail { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(8)]
        public string RegisterPassword { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Compare(nameof(RegisterPassword))]
        public string ConfirmPassword { get; set; }
    }
}
