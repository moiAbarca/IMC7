﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaDTO;
using CapaNegocio;
using System.Data;

/// <summary>
/// Descripción breve de wsComparaIMC
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class wsComparaIMC : System.Web.Services.WebService
{

    public wsComparaIMC()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }


    [WebMethod]
    public DataSet comparaIMC(string rut)
    {
        ngReportes report = new ngReportes();
        return report.ComparaIMC(rut);  
               
    }



}
