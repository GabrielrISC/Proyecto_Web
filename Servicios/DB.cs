using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos;
using System.Data;

namespace Servicios
{
    public class DB
    {
        public SqlConnection conexion= new SqlConnection("Server=A2NWPLSK14SQL-v01.shr.prod.iad2.secureserver.net;Database=db_ProyectoWeb;User Id=sistemas_8vo;Password=3I4r7?mh;");
        public SqlCommand comando = new SqlCommand();
        public SqlDataReader lector = null;
        public SqlDataAdapter adaptador = new SqlDataAdapter();

         void AbrirCon()
        {
            this.conexion.Open();
        }
         void CerrarCon()
        {
            this.conexion.Close();
        }
        void verificar_cierre()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public Estatus ExecutarQuery(string query)
        {           
            try
            {
                AbrirCon();// Abro la conexion
                comando = new SqlCommand(query, conexion);// preparo el objeto command con el query
                comando.ExecuteNonQuery();// executo el query
                comando.Dispose();// libero el objeto
                CerrarCon();// cierro la conexion
                return new Estatus {Mensaje="Query ejecutado",Codigo=100,Estado="Exito"};// regreso un estatus de la ejecucion
            }
            catch (Exception e)
            {
                verificar_cierre();// verifico si la conexion se quedo abierta si es asi la cierro
                string _mensaje = e.Message;
                return new Estatus { Mensaje = _mensaje, Codigo = 500, Estado="Error" };// regreso un estatus de la ejecucion
            }
        }
        public DataTable QuerySelect(string query)
        {
            DataTable _resultado = new DataTable();
            try
            {
                AbrirCon();// Abro la conexion
                comando = new SqlCommand(query, conexion);// preparo el objeto command para el query
                adaptador = new SqlDataAdapter(comando);// le asigno el adaptador para obtener el resultado del query
                adaptador.Fill(_resultado);// dibujo en el datatable el resultado del query
                comando.Dispose();// libero el objeto comando
                conexion.Close();// cierro la conexion
                return _resultado;// regreso el datatable
            }
            catch (Exception e)
            {
                //-- Tipo de columnas para la tabla si hay un error
                _resultado.Columns.Add("Mensaje",typeof(string));
                _resultado.Columns.Add("Codigo_Error", typeof(int));
                _resultado.Columns.Add("Estatus", typeof(string));
                //-------
                verificar_cierre();// verifico si la conexion se quedo abierta si es asi la cierro
                List<object> errores = new List<object>() {e.Message,500,"Error" };//creo una listita temporal con informacion general del error
                DataRow row = _resultado.NewRow();// creo una fila para agregarla al datatable
                row.ItemArray = errores.ToArray();// convierto la lista a arreglo para insertarla en el datatable
                _resultado.Rows.Add(row);
                return _resultado;// regreso el datatable
            }
        }
    }
}
