using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/*
 * Agregar un nuevo elemento al proyecto que sea Servicio Web ASMX
 */


namespace ws_control_puce
{
    /// <summary>
    /// Descripción breve de control_puce
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class control_puce : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public int Sumar (int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }
    }
}
