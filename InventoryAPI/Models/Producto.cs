
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InventoryAPI.Models;

public class Producto {
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public required string Codigo { get; set; }

    [Required]
    [MaxLength(100)]
    public required string Nombre { get; set; }

    public required string Descripcion { get; set; }

    [Range(0.01, double.MaxValue)]
    public decimal Precio { get; set; }

    [Range(0, int.MaxValue)]
    public int Stock { get; set; }

    [ForeignKey("Categoria")]
    public int CategoriaId { get; set; }
    public required Categoria Categoria { get; set; }
}