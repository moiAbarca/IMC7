﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaNegocio;
using CapaDTO;
using System.Data;


/// <summary>
/// Descripción breve de wsGeneraResultados
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class wsGeneraResultados : System.Web.Services.WebService
{

    public wsGeneraResultados()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public DataSet generaResultados(string rut)
    {
        ngReportes report = new ngReportes();
        return report.GeneraResultados(rut);
    }

}
