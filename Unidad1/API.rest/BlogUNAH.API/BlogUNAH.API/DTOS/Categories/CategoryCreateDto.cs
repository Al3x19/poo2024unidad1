using System.ComponentModel.DataAnnotations;
namespace BlogUNAH.API.DTOS.Categories
{
    public class CategoryCreateDto
    {

        public Guid Id { get; set; }

        // Data Annotations
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El {0} de la categoria es Requerido.")]

        public string Name { get; set; }
        [Display(Name = "Descripcion")]
        [MinLength(10, ErrorMessage = "La {0} Debe tener al menos {1} Caracteres.")]

        public string Description { get; set; }
        }
    }
