using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios;
namespace Datos.ObjetosAccesos
{
    public class clsUsuario
    {
        public string strNombre;
        public string strUsuarioId;
        public string strPassword;
        public int intRolId;
        public bool bolEsAdministrador;

        public class Usuario {
            public string strNombre;
            public string strUsuarioId;
            public string strPassword;
            public int intRolId;
            public bool bolEsAdministrador;
        }

        public static string Insertar(Usuario objUsuario, string strCon) {

            DB objDb = new DB();


            string strSql = "INSERT INTO tUsuarios (UsuarioId, Nombre, Password, RolId, EsAdministrador)" + 
                            " VALUES('"+ objUsuario.strNombre +"', '"+ objUsuario.strPassword +"', "+ objUsuario.intRolId +", '"+ objUsuario.bolEsAdministrador.ToString() +"')";
            objDb.ExecutarQuery(strSql);



            return "";
        }


    }
}
