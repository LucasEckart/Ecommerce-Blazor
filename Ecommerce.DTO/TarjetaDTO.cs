using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DTO
{
    public class TarjetaDTO
    {
        [Required(ErrorMessage = "Ingesar Titular")]
        public String? Titular { get; set; }

        [Required(ErrorMessage = "Ingrese Numero Tarjeta")]
        public string? Numero { get; set; }

        [Required(ErrorMessage = "Ingesar Vigencia")]
        public string? Vigencia { get; set; }

        [Required(ErrorMessage = "Ingesar CVV")]
        public string? CVV { get; set; }

    }
}
