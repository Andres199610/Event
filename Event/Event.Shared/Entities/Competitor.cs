using System.ComponentModel.DataAnnotations;

namespace Event.Shared.Entities
{
    public class Competitor
    {

        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo{1}caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; } = null!;

        [Display(Name = "Afiliacion")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo{1}caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Membership { get; set; } = null!;

        [Display(Name = "Area")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo{1}caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Description { get; set; } = null!;

        [Display(Name = "Tipo")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo{1}caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public string Type { get; set; } = null!;
    }
}

