using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pustok_Project.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        public List<Book> Books { get; set; }
    }
}
