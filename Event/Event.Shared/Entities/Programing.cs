using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Shared.Entities
{
    public class Programing
    {
        public int Id { get; set; }

        public DateTime date { get; set; }

        [Display(Name = "Sesiones")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo{1}caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; } = null!;

        [Display(Name = "Ponentes")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo{1}caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Description { get; set; } = null!;

        [Display(Name = "Tema")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo{1}caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Issue { get; set; } = null!;
    }
}
