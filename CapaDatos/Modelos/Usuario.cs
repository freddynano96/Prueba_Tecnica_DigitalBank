using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelos
{
    /// <summary>
    /// Modelo de Datos para ejecutar las acciones de esta entidad en la base de datos
    /// </summary>
    public class Usuario
    {
        private readonly ConexionBaseDatos bd;

        /// <summary>
        /// Constructor que inicializa el parametro de solo lectura de la conexión a la base de datos
        /// </summary>
        public Usuario()
        {
            bd = new ConexionBaseDatos();
        }

        /// <summary>
        /// Propiedad que almacena el Id del Usuario
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Almacena el nombre del usuario para su manejo
        /// </summary>
        public string Nombre { get;set; }

        /// <summary>
        /// Almacena la fecha de nacimiento del usuario en una propiedad de tipo DateTime
        /// solo almacena Fecha la hora se mantiene por defecto del tipo del dato
        /// </summary>
        public DateTime Fecha_Nacimiento { get;set; }

        /// <summary>
        /// Almacena el caracter que es H para hombre M para Mujer
        /// </summary>
        public char Sexo { get;set; }

        /// <summary>
        /// Convierte las propiedades de la clase en Parametros de tipo diccionario
        /// para pasarlo despues en un metodo que necesite los parametros para la consulta SQL
        /// </summary>
        /// <param name="withId">
        /// Valida si tambien agrega al diccionario el Id de la entidad actualmente inicializada
        /// </param>
        /// <returns>Devuelte el tipo Dictionary</returns>
        private Dictionary<string,object> ConvertirEnDiccionarioPropiedades(bool withId = false)
        {
            var dicProp = new Dictionary<string, object>
            {
                { "@Nombre", Nombre },
                { "@Fecha_Nacimiento", Fecha_Nacimiento.Date },
                { "@Sexo", Sexo }
            };

            if (withId)
            {
                dicProp.Add("@id", Id);
            }

            return dicProp;
        }

        /// <summary>
        /// Ejecuta la consulta para la creación del Usuario en la base de datos
        /// </summary>
        /// <returns>Devuele el usuario creado</returns>
        public Usuario CrearUsuario()
        {
            ConexionBaseDatos bd = new ConexionBaseDatos();

            var result = bd.EjecutarSQLQuery("CrearUsuario", CommandType.StoredProcedure, ConvertirEnDiccionarioPropiedades(false));

            Id = Convert.ToInt32(result.Rows[0]["Id"]);

            return this;
        }

        /// <summary>
        /// Realiza las acciones de ejecutar la consulta en la base de datos para la modificación del usuario actual inicializado
        /// </summary>
        /// <returns>Devuelve la instancia del usuario ya editado</returns>
        public Usuario EditarUsuario()
        {
            ConexionBaseDatos bd = new ConexionBaseDatos();

            var result = bd.EjecutarSQLQuery("EditarUsuario", CommandType.StoredProcedure, ConvertirEnDiccionarioPropiedades(true));

            return this;
        }

        /// <summary>
        /// Ejecuta la eliminación del usuario del Id que se le pase, debe de estar inicializado la clase Usuario, no hay necesidad que se encuentre inicializado con el usuario en especifico
        /// </summary>
        /// <param name="id">Parametro necesario si el usuario a eliminar no es el usuario actualmente inicializado</param>
        /// <returns>Devuelve el tipo bool para determinar si se ejcuto o no la acción de eliminación</returns>
        public bool EliminarUsuario(int? id = null)
        {
            if (id.HasValue)
            {
                Id = id.Value;
            }

            var dict = new Dictionary<string, object>
            {
                { "@Id", Id }
            };

            var result = bd.EjecutarSQLQuery("EliminarUsuario",CommandType.StoredProcedure, dict);

            return true;
        }

        /// <summary>
        /// Ejecuta la consulta para traer de la base de datos el usuario con el Id indicado
        /// </summary>
        /// <param name="id">Parametro necesario para ejecutar la consulta del usuario con el ID en especifico</param>
        /// <returns>Devuelve el tipo Usuario al igual que inicializa con las propiedades de la intancia actual.</returns>
        public Usuario ConsultarUsuario(int id)
        {
            ConexionBaseDatos bd = new ConexionBaseDatos();

            Dictionary<string, object> parametro = new Dictionary<string, object>()
            {
                { "@id", id }
            };

            var result = bd.EjecutarSQLQuery("ConsultarUsuario", CommandType.StoredProcedure, parametro);

            if(result == null)
            {
                return null;
            }

            var userTemp = ConvertirDataTableToUsuario(result.Rows[0]);

            Fecha_Nacimiento = userTemp.Fecha_Nacimiento;
            Id = userTemp.Id;
            Nombre = userTemp.Nombre;
            Sexo = userTemp.Sexo;

            return this;
        }

        /// <summary>
        /// Convierte desde el tipo DataRow que es el tipo de datos despues de que se ejecuta una consulta y se llena un DataTable
        /// </summary>
        /// <param name="row">El parametro es obligatorio y debe de contener las columas de la tabla Usuario de la base de datos con sus respectivos nombres</param>
        /// <returns>Devule una nueva instancia de Usuario sin modificar la actual</returns>
        private Usuario ConvertirDataTableToUsuario(DataRow row)
        {
            return new Usuario
            {
                Id = Convert.ToInt32(row[nameof(Id)]),
                Nombre = Convert.ToString(row[nameof(Nombre)]),
                Fecha_Nacimiento = Convert.ToDateTime(row["Fecha_Nacimiento"]),
                Sexo = Convert.ToChar(row[nameof(Sexo)])
            };
        }

        /// <summary>
        /// Cuenta todos los usuarios que se encuentran en la base de datos sin ningun tipo de criterio de busqueda
        /// </summary>
        /// <returns>Devuelve un tipo de dato Entero</returns>
        public int ContarUsuarios()
        {
            var result = bd.EjecutarSQLQuery("ContarUsuarios", CommandType.StoredProcedure);

            if(result == null)
            {
                return -1;
            }

            return Convert.ToInt32(result.Rows[0][0]);
        }


        /// <summary>
        /// Devuele todos los usuarios con dos parametros para la paginación de los usuarios
        /// </summary>
        /// <param name="skip">Si se deja en blanco ejecuta la consulta sin saltar ninguna fila</param>
        /// <param name="cantidad">Se especifica para saber cuantos datos se traen de la base de datos para ser presentados</param>
        /// <returns>Devulve una Lista de tipo Usuario</returns>
        public List<Usuario> GetUsuarios(int skip = 0, int cantidad = 20)
        {
            var parametros = new Dictionary<string, object>()
            {
                { "@skip" , skip },
                { "@take" , cantidad }
            };

            var result = bd.EjecutarSQLQuery("GetUsuarios", CommandType.StoredProcedure, parametros);

            var usuariosResult = new List<Usuario>();

            if (result != null)
            {
                for(int i= 0;i< result.Rows.Count; i++)
                {
                    usuariosResult.Add(ConvertirDataTableToUsuario(result.Rows[i]));
                }
            }

            return usuariosResult;
        }


        /// <summary>
        /// Busca los usuarios con el criterio de busqueda en el parametros
        /// </summary>
        /// <param name="busqueda">El parametro debe ser obligatorio y no debe estar null.</param>
        /// <param name="skip">Salta el número de filas que se especifiquen, si se deja en blanco no se saltara ninguna fila</param>
        /// <param name="cantidad">Se especifica para pasar a la consulta el numero de datos que traera la base de datos cuando se ejecute la consulta</param>
        /// <returns>Devuelve una Lista de Usuarios</returns>
        public List<Usuario> BuscarUsuarios(string busqueda,int skip = 0, int cantidad = 20)
        {
            var parametros = new Dictionary<string, object>()
            {
                { "@skip" , skip },
                { "@take" , cantidad },
                { "@busqueda", busqueda }
            };

            var result = bd.EjecutarSQLQuery("BuscarUsuarios", CommandType.StoredProcedure, parametros);

            var usuariosResult = new List<Usuario>();

            if (result != null)
            {
                for (int i = 0; i < result.Rows.Count; i++)
                {
                    usuariosResult.Add(ConvertirDataTableToUsuario(result.Rows[i]));
                }
            }

            return usuariosResult;

        }

        /// <summary>
        /// Cuenta los usuarios segun el criterio de busqueda que se haya pasado como parametro
        /// </summary>
        /// <param name="busqueda">Parametro necesario para ejecutar la consulta y contar segun este criterio.</param>
        /// <returns>Devuelve un tipo de datos int</returns>
        public int ContarUsuarioPorBusqueda(string busqueda)
        {
            var parametros = new Dictionary<string, object>
            {
                { "@Busqueda", busqueda }
            };

            var result = bd.EjecutarSQLQuery("ContarUsuariosPorBusqueda", CommandType.StoredProcedure, parametros);

            if (result == null)
            {
                return -1;
            }

            return Convert.ToInt32(result.Rows[0][0]);
        }

    }
}
