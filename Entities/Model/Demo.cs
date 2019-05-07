//Si quieren hacer uso de los DataAnnotations como en el ejemplo deben agregar una referencia a EntityFramework 
//(No lo vuelvan a descargar, busquen en su proyecto si ya lo descargaron para la capa Datos)
using System.ComponentModel.DataAnnotations; //Usado para dar parametros a los campos
using System.ComponentModel.DataAnnotations.Schema; //Usado para crear indices en la base de datos

namespace Entities.Model
{
    public class Demo
    {
        /// <summary>
        /// Cada tabla o entidad debe llevar su Id tal cual el nombre (por convención) pero se puede cambiar
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Descripcion es Unico, su tamaño máximo es de 75 y no acepta null
        /// </summary>
        [Index(IsUnique = true), MaxLength(75), Required]
        public string Descripcion { get; set; }
    }
}
