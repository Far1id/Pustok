﻿using System.ComponentModel.DataAnnotations;

namespace Pustok_Project.Models
{
    public class Tag
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
