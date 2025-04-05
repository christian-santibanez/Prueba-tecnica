
using System.ComponentModel.DataAnnotations; 
public class ProductoCreateDto {
    [Required, MaxLength(50)]
    public required string Codigo { get; set; }
    
    [Required, MaxLength(100)]
    public required string Nombre { get; set; }

    public required string Descripcion { get; set; }
    
    [Range(0.01, double.MaxValue)]
    public decimal Precio { get; set; }
    
    [Range(0, int.MaxValue)]
    public int Stock { get; set; }
    
    [Required]
    public int CategoriaId { get; set; }
}