using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using Newtonsoft.Json;

/// <summary>
/// Summary description for wsProyecto
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ScriptService]
public class wsProyecto : System.Web.Services.WebService
{
    public wsProyecto()
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string Iniciar_Sesion(string usuario,string contrasena)
    {       
        Dictionary<string, object> dichola = new Dictionary<string, object>();
        dichola.Add("User", usuario);
        dichola.Add("Pass", contrasena);

        return JsonConvert.SerializeObject(dichola);
    }

}
