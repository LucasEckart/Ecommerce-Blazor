using Azure;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ecommerce.Repositorio.Contrato
{
    public interface IGenericoRepositorio<TModelo> where TModelo : class
    {

        //CONSULTAR: Este método permite consultar los datos en el repositorio.
        //Recibe un filtro opcional que permite especificar condiciones para la consulta.
        //Devuelve un IQueryable<TModelo>, que es una secuencia de elementos que cumple con el filtro especificado.

        //CREAR Este método se utiliza para crear un nuevo objeto en el repositorio.
        //Recibe como parámetro el objeto que se va a crear.
        //Devuelve una tarea (Task) que representa la operación de creación y que eventualmente devolverá el objeto creado.

        //EDITAR Este método se utiliza para editar un objeto existente en el repositorio.
        //Recibe como parámetro el objeto que se va a editar.
        //evuelve una tarea (Task) que representa la operación de edición y que eventualmente devolverá un valor booleano 
        //indicando si la operación se realizó correctamente.

        //ELIMINAR Este método se utiliza para eliminar un objeto existente en el repositorio.
        //Recibe como parámetro el objeto que se va a eliminar.
        //Devuelve una tarea (Task) que representa la operación de eliminación y que eventualmente devolverá un valor booleano
        //indicando si la operación se realizó correctamente.

        IQueryable<TModelo> Consultar(Expression<Func<TModelo, bool>> ? filtro = null);
        Task <TModelo> Crear(TModelo modelo);
        Task<bool> Editar(TModelo modelo);
        Task<bool> Eliminar(TModelo modelo);


    }
}
