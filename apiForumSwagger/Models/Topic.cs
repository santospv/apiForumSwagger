﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apiForumSwagger.Models
{
    public class Topic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "Este campo não pode ter mais do que 100 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo deve ser preenchido")]
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        public Subcathegory subcathegory { get; set; }

        public User Author { get; set; }
    }
}
