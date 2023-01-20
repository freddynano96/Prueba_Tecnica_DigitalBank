using CapaDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    /// <summary>
    /// Clase que contiene la logica nativa para la ejecución de consultas
    /// la conexión a la base de  datos se realizo con SqlConnection que se encuentra en el namespace
    /// System.Data.SqlClient y se ejecuta bajo Transaction
    /// </summary>
    public class ConexionBaseDatos
    {
        private readonly string _conexionBaseDatos;

        /// <summary>
        /// Constructor basico que contiene el valor quemado de la conexión a la base de datos
        /// </summary>
        public ConexionBaseDatos()
        {
            _conexionBaseDatos = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BaseDatosPruebaTecnica;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        /// <summary>
        /// Constructor para modificar dinamicamente el valor de la conexión a la base de datos
        /// </summary>
        /// <param name="conexionString">Recibe el parametro para modificación de la variabel de solo lectura que se inicializa unicamente durante la creaciónde la instancia ConexionBaseDatos</param>
        public ConexionBaseDatos(string conexionString)
        {
            _conexionBaseDatos = conexionString;
        }

        /// <summary>
        /// Se compila y ejecuta la base datos, el modificador de acceso se dejo de tipo internal para que
        /// no sea modificado por otro ensamblador por fuera de la capa de datos.
        /// </summary>
        /// <param name="sql">Parametro que contiene la consulta a la base de datos</param>
        /// <param name="tipoComando">El tipo de comando que se quiere ejecutar si es StoredProcedure, Table, Text</param>
        /// <param name="parametros">No es obligatorio para el procedimiento pero debe de especificarse si el parametro es necesario
        /// para la consulta que se pasa en el parametro sql</param>
        /// <returns>Devuelve el tipo de dato DataTable para su procesamiento</returns>
        internal DataTable EjecutarSQLQuery(string sql, CommandType tipoComando, Dictionary<string,object> parametros = null)
        {
            using (SqlConnection con = new SqlConnection(_conexionBaseDatos))
            {
                try
                {
                    SqlCommand command = con.CreateCommand();

                    con.Open();

                    using(var trans = con.BeginTransaction())
                    {
                        command.Transaction = trans;

                        command.CommandText = sql;

                        command.CommandType = tipoComando;

                        if (parametros != null)
                        {
                            foreach (var p in parametros)
                            {
                                command.Parameters.AddWithValue(p.Key, p.Value);
                            }
                        }

                        DataTable dt = new DataTable();
                        dt.Load(command.ExecuteReader());

                        trans.Commit();

                        con.Close();
                        
                        return dt;
                    }
                }
                catch
                {
                    throw;
                }
                
            }
        }        

    }
}
