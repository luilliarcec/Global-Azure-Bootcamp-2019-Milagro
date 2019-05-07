using Data.Context;
using Entities.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Data.Dao
{
    public class DemoDAO
    {
        /// <summary>
        /// Referencia a nuestro contexto creado en Context para coneccion a base de datos
        /// </summary>
        private readonly DemoContext _context = new DemoContext();

        /// <summary>
        /// Guarda en la base de datos
        /// </summary>
        /// <param name="demo">Recibe un parametro de la entidad Demo</param>
        public void Save(Demo demo)
        {
            _context.Demos.Add(demo);
            _context.SaveChanges();
        }

        /// <summary>
        /// Modifica en la base de datos
        /// </summary>
        /// <param name="demo">Recibe un parametro de la entidad Demo</param>
        public void Update(Demo demo)
        {
            _context.Entry(demo).State = EntityState.Modified;
            _context.SaveChanges();
        }

        /// <summary>
        /// Elimina en la base de datos
        /// </summary>
        /// <param name="demo">Recibe un parametro de la entidad Demo</param>
        public void Delete(Demo demo)
        {
            _context.Demos.Remove(demo);
            _context.SaveChanges();
        }

        /// <summary>
        /// Obtiene un unico registro segun el id
        /// </summary>
        /// <param name="id">Id del registro</param>
        /// <returns>Retorna Demo</returns>
        public Demo GetDemo(int id)
        {
            return _context.Demos.Find(id);
        }

        /// <summary>
        /// Obtiene todo los registros de la tabla demo
        /// </summary>
        /// <returns>Una lista de solo lectura de demo</returns>
        public IReadOnlyList<Demo> GetDemos()
        {
            return _context.Demos.ToList().AsReadOnly();
        }
    }
}
