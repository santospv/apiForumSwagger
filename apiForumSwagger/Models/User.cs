using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apiForumSwagger.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "Este campo não pode ter mais do que 100 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo é obrigatório")]
        public string Name { get; set; }

        [MaxLength(500, ErrorMessage = "Este campo não pode ter mais do que 500 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo é obrigatório")]
        public string Avatar { get; set; }

        public DateTime InscritionDate { get; set; }

        [MaxLength(500, ErrorMessage = "Este campo não pode ter mais do que 500 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Password { get; set; }
    }
}
