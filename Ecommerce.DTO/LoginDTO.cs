﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DTO
{
    public class LoginDTO
    {

        [Required(ErrorMessage = "Ingesar Correo")]
        public string? Correo { get; set; }


        [Required(ErrorMessage = "Ingesar Contraseña")]
        public string? Clave { get; set; }

    }
}