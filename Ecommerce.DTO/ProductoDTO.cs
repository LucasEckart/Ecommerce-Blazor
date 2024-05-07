using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DTO
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "Ingesar nombre completo")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Ingesar Descripcion")]
        public string? Descripcion { get; set; }

        public int? IdCategoria { get; set; }

        [Required(ErrorMessage = "Ingesar Precio")]
        public decimal? Precio { get; set; }

        [Required(ErrorMessage = "Ingesar Precio oferta")]
        public decimal? PrecioOferta { get; set; }

        [Required(ErrorMessage = "Ingesar Cantidad")]
        public int? Cantidad { get; set; }

        [Required(ErrorMessage = "Ingesar Imagen")]
        public string? Imagen { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public virtual CategoriaDTO? IdCategoriaNavigation { get; set; }

    }
}
