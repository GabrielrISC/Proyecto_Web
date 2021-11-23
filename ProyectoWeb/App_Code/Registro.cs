using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for Registro
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class Registro : System.Web.Services.WebService
{

    public Registro()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }



    #region Usuarios

    [WebMethod]
    public string GetUsuario(string strUsuarioId)
    {
        return "";
    }

    [WebMethod]
    public string PostUsuario(Datos.ObjetosAccesos.clsUsuario.Usuario objUsuarioId)
    {
        return "";
    }

    #endregion


}
