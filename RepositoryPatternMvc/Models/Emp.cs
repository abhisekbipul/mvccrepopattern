﻿using System.ComponentModel.DataAnnotations;

namespace RepositoryPatternMvc.Models
{
    public class Emp
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Department")]
        public string Dept { get; set; }

        [Required(ErrorMessage = "Enter Salary")]
        public double Salary { get; set; }
    }
}
