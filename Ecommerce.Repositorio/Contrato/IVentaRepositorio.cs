using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Modelo;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Ecommerce.Repositorio.Contrato
{
    public interface IVentaRepositorio : IGenericoRepositorio<Venta>
    {
        //Este método específico para ventas se utiliza para registrar una nueva venta en el repositorio.
        //Recibe como parámetro el objeto de tipo Venta que se va a registrar.
        //Devuelve una tarea(Task) que representa la operación de registro y que eventualmente devolverá el objeto de venta registrado.
        Task<Venta> Registrar(Venta modelo);

    }
}
