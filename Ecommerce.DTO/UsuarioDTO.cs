using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }


        [Required(ErrorMessage = "Ingesar nombre completo")]
        public string? NombreCompleto { get; set; }


        [Required(ErrorMessage = "Ingesar Correo")]
        public string? Correo { get; set; }


        [Required(ErrorMessage = "Ingesar Contraseña")]
        public string? Clave { get; set; }


        [Required(ErrorMessage = "Ingesar confirmar contraseña")]
        public string? ConfirmarClave { get; set; }


        public string? Rol { get; set; }


    }
}
