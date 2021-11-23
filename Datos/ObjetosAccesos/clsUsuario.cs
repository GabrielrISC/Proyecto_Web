using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios;
using Newtonsoft.Json;
namespace Datos.ObjetosAccesos
{
    public class clsUsuario
    {
        public string strNombre;
        public string strUsuarioId;
        public string strPassword;
        public int intRolId;
        public bool bolEsAdministrador;

        public class Usuario
        {
            public string strNombre;
            public string strUsuarioId;
            public string strPassword;
            public int intRolId;
            public bool bolEsAdministrador;
        }

        public static string Insertar(Usuario objUsuario, string strCon)
        {
            DB objDb = new DB();
            string strSql = $"INSERT INTO tUsuarios (UsuarioId, Nombre, Password, RolId, EsAdministrador)" +
                            $" VALUES('{objUsuario.strNombre}', '{objUsuario.strPassword}', {objUsuario.intRolId}, '{objUsuario.bolEsAdministrador.ToString()}')";
            Estatus objResultado = objDb.ExecutarQuery(strSql);
            return JsonConvert.SerializeObject(objResultado);
        }
        public static string Actualizar(Usuario objUsuario, string strCon)
        {
            return "";
        }

        public static string Eliminar(string strUsuarioId, string strCon)
        {
            return "";
        }

        public static string Get(string strUsuarioId, string strCon)
        {
            return "";
        }
    }
}
