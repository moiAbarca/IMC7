using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de wsCalculaIMC
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class wsCalculaIMC : System.Web.Services.WebService
{

    public wsCalculaIMC()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }
    [WebMethod]
    public double calculaIMC(double peso, double altura)
    {
        double IMC;

        ngDetalle_Ficha_Alumno auxNegocio = new ngDetalle_Ficha_Alumno();
        return IMC = auxNegocio.calculaIMC(peso, altura);

    }


}
