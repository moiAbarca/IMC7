using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaDTO;
using CapaNegocio;
using System.Data;

/// <summary>
/// Descripción breve de wsGuardaDatosCorrectivos
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class wsGuardaDatosCorrectivos : System.Web.Services.WebService
{

    public wsGuardaDatosCorrectivos()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public void agregaDatosCorrectivos(Medida_Correctiva medida_Correctiva)
    {
        ngMedida_Correctiva auxMedida_Correctiva = new ngMedida_Correctiva();
        auxMedida_Correctiva.ingresaMedida_Correctiva(medida_Correctiva);
    }

    [WebMethod]
    public DataSet entregaMedida_CorrectivaDataSet()
    {
        ngMedida_Correctiva auxMedida_Correctiva = new ngMedida_Correctiva();
        return auxMedida_Correctiva.retornaMedida_CorrectivaDataSet();
    }

    [WebMethod]
    public List<Medida_Correctiva> entregaLargoMedida_Correctiva()
    {
        ngMedida_Correctiva auxMedida_Correctiva = new ngMedida_Correctiva();
        return auxMedida_Correctiva.retornaMedida_Correctiva();
    }

    [WebMethod]
    public Medida_Correctiva entregaPosicionMedida_Correctiva(int pos)
    {
        ngMedida_Correctiva auxMedida_Correctiva = new ngMedida_Correctiva();
        return auxMedida_Correctiva.retornaPosicionMedida_Correctiva(pos);
    }

    [WebMethod]
    public Medida_Correctiva buscarMedida_Correctiva(String Cod_MC)
    {
        ngMedida_Correctiva auxMedida_Correctiva = new ngMedida_Correctiva();
        return auxMedida_Correctiva.buscaMedida_Correctiva(Cod_MC);
    }

    public void actualizaMedida_Correctiva(Medida_Correctiva medida_Correctiva)
    {
        ngMedida_Correctiva auxMedida_Correctiva = new ngMedida_Correctiva();
        auxMedida_Correctiva.actualizarMedida_Correctiva(medida_Correctiva);
    }

}
