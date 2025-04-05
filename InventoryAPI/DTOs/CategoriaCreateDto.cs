using System.ComponentModel.DataAnnotations;

namespace InventoryAPI.DTOs
{
    public class CategoriaCreateDto
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres")]
        public required string Nombre { get; set; }

        [MaxLength(500, ErrorMessage = "La descripción no puede superar los 500 caracteres")]
        public required string Descripcion { get; set; }
    }
}