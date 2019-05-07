using Entities.Model; //Aqui se hace de la capa Entidades. ------Todas las capas (Datos, Logica y Presentacion, tienen acceso a la capa Entidades)
using System.Data.Entity;
using System.Data.SqlClient;

namespace Data.Context
{   
    public class DemoContext : DbContext
    {
        //Esta es una manera de conectar con la clase SqlConnectionStringBuilder
        //Se puede hacer  de la siguiente manera
        /*
         public DemoContext() : base("name=CadenaConexion")
         */
        //De esa forma especificamos que nuestra cadena de conexión está en nuestro archivo app.config pero deberá estar la cadena de conexion tanto -
        //en la capa Datos como en la capa Presentacion
        public DemoContext() : base(GetConnectionString())
        {

        }

        //Por cada Entidad habra un DbSet esto nos permitira crear las migraciones
        public DbSet<Demo> Demos { get; set; }

        //Y este es el metodo de nuestra conexion
        private static string GetConnectionString()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = "tcp:{direccion que copiaron de su servidor en azure}",
                InitialCatalog = "{Nombre de su base de datos}",
                UserID = "{su usuario que crearon para el servidor}",
                Password = "{la contraseña de ese usuario}"                
            };

            return builder.ConnectionString;
        }

        /*
         * Pasos para ejecutar migraciones.
         1. En la barra superior ir a Herramientas > Administrador de paquetes de NuGet > Consola del administrador de paquetes de NuGet
         2. Dentro de la consola parte inferior seleccionar en Proyecto predeterminado: <<Seleccione su capa Data o Datos>>
         3. Escribir...
            * enable-migrations
            * add-migration InitialMigration
            * update-database
        */
    }
}

/*
 Por ultimo no se olviden de las referencias 
 * Data > Entities
 * Logic > Entities y Data
 * Presentation > Entities y Logic
 * 
 * Ademas de en Presentation hacer referencia a EntityFramework.SqlServer
*/
