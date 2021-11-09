﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace PalwindersBooks.Models
{
     public class Category
    {
        [Key]

        public int ID { get; set; }

        [Display(Name = "Category Name")]
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }
    }
}
