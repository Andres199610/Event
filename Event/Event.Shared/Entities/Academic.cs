using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Shared.Entities
{
    public class Academic
    {

        public int Id { get; set; }


        [Display(Name = "Nombre")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo{1}caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; } = null!;

        public DateTime DateTime { get; set; }

        public DateTime DateTimeend { get; set; }

        [Display(Name = "Ubicacion")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo{1}caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Location { get; set; } = null!;

        [Display(Name = "Descripcion")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo{1}caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Description { get; set; } = null!;

        [Display(Name = "Tema")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo{1}caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Issue { get; set; } = null!;

    }
}
