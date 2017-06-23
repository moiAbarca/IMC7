using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaDTO;
using CapaNegocio;
using System.Data;

/// <summary>
/// Descripción breve de wsGuardaDatosAlumnos
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class wsGuardaDatosAlumnos : System.Web.Services.WebService
{

    public wsGuardaDatosAlumnos()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public void agregaAlumno(Alumno alumno)
    {
        ngAlumno auxAlumno = new ngAlumno();
        auxAlumno.ingresaAlumno(alumno);
    }

    [WebMethod]
    public void eliminarAlumno(string Rut)
    {
        ngAlumno auxAlumno = new ngAlumno();
        auxAlumno.eliminarAlumno(Rut);
    }

    [WebMethod]
    public DataSet entregaAlumnoDataSet()
    {
        ngAlumno auxAlumno = new ngAlumno();
        return auxAlumno.retornaAlumnoDataSet();
    }

    [WebMethod]
    public List<Alumno> entregaLargoAlumno()
    {
        ngAlumno auxAlumno = new ngAlumno();
        return auxAlumno.retornaAlumno();
    }

    [WebMethod]
    public Alumno entregaPosicionAlumno(int pos)
    {
        ngAlumno auxAlumno = new ngAlumno();
        return auxAlumno.retornaPosicionAlumno(pos);
    }

    [WebMethod]
    public Alumno buscarAlumno(String Rut)
    {
        ngAlumno auxAlumno = new ngAlumno();
        return auxAlumno.buscaAlumno(Rut);
    }
    [WebMethod]
    public void actualizaAlumno(Alumno alumno)
    {
        ngAlumno auxAlumno = new ngAlumno();
        auxAlumno.actualizarAlumno(alumno);
    }



}
