using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDTO;
using CapaConexion;
using System.Data;

namespace CapaNegocio
{
    public class ngReportes
    {
        private Conexion conec1;

        public Conexion Conec1
        {
            get { return conec1; }
            set { conec1 = value; }
        }

        public void configurarConexion()
        {
            this.Conec1 = new Conexion();
            this.Conec1.NombreBaseDeDatos = "IMC";
            this.Conec1.NombreTabla = "Detalle_Ficha_Alumno";
            this.Conec1.CadenaConexion = "Server=127.0.0.1;Database=IMC;Trusted_Connection=True;";
        }


        public DataSet GeneraResultados(String Rut)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "select TOP(2) d.Cod_Detalle_Ficha, d.Cod_Ficha, d.Valor_IMC, d.Clasificacion_IMC , ";
            this.Conec1.CadenaSQL += "Convert(CHAR(10), d.Fecha_Revision, 103) AS Fecha_Revision, ";
            this.Conec1.CadenaSQL += "CONVERT(CHAR(10), d.Fecha_Proxima_Revision, 103) AS Fecha_Proxima_Revision, c.Cod_Ficha, ";
            this.Conec1.CadenaSQL += "c.Rut, c.Rut_RRHH, c.Estatura, c.Peso, ";
            this.Conec1.CadenaSQL += "CONVERT(CHAR(10), c.Fecha_Actualizacion, 103) AS Fecha_Actualizacion, c.IdListaCurso ";
            this.Conec1.CadenaSQL += "from Detalle_Ficha_Alumno d ";
            this.Conec1.CadenaSQL += "INNER JOIN Cabecera_Ficha_Alumnos c ON d.Cod_Ficha = c.Cod_Ficha ";
            this.Conec1.CadenaSQL += "WHERE c.Rut = '"+Rut+"' ";
            this.Conec1.CadenaSQL += "ORDER BY Fecha_Revision DESC ";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            return this.Conec1.DbDataSet;
        }



        public DataSet ComparaIMC(String Rut)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT TOP(2) MAX(d.Valor_IMC) - MIN(d.Valor_IMC) AS Diferencia_IMC";
            this.Conec1.CadenaSQL += " from Detalle_Ficha_Alumno d";
            this.Conec1.CadenaSQL += " INNER JOIN Cabecera_Ficha_Alumnos c ON d.Cod_Ficha = c.Cod_Ficha";
            this.Conec1.CadenaSQL += " WHERE c.Rut = '"+ Rut +"' AND (Fecha_Revision between CONVERT(DATE, '01-' + CONVERT(VARCHAR, DATEPART(MONTH, DATEADD(MONTH, -1, GETDATE()))) + '-' + CONVERT(VARCHAR, YEAR(GETDATE())), 103) AND";
            this.Conec1.CadenaSQL += " CONVERT(DATE, '01-' + CONVERT(VARCHAR, MONTH(GETDATE())) +'-'+ CONVERT(VARCHAR, YEAR(GETDATE())), 103))";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            return this.Conec1.DbDataSet;
        }


        public DataSet ReporteResultadosHistoricos(String año)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = " SELECT a.Nombre +' '+ a.Apellido as Nombre_Alumno, d.Cod_Detalle_Ficha, d.Cod_Ficha, d.Valor_IMC, d.Clasificacion_IMC , ";
            this.Conec1.CadenaSQL += " Convert(CHAR(10), d.Fecha_Revision, 103) AS Fecha_Revision,";
            this.Conec1.CadenaSQL += " CONVERT(CHAR(10), d.Fecha_Proxima_Revision, 103) AS Fecha_Proxima_Revision, c.Cod_Ficha, ";
            this.Conec1.CadenaSQL += " c.Rut, c.Rut_RRHH, c.Estatura, c.Peso, ";
            this.Conec1.CadenaSQL += " CONVERT(CHAR(10), c.Fecha_Actualizacion, 103) AS Fecha_Actualizacion, c.IdListaCurso";
            this.Conec1.CadenaSQL += " from Detalle_Ficha_Alumno d";
            this.Conec1.CadenaSQL += " INNER JOIN Cabecera_Ficha_Alumnos c ON d.Cod_Ficha = c.Cod_Ficha";
            this.Conec1.CadenaSQL += " INNER JOIN Alumno a ON c.Rut = a.Rut";
            this.Conec1.CadenaSQL += " WHERE CONVERT(VARCHAR, YEAR(Fecha_Revision)) = '"+año+"'";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            return this.Conec1.DbDataSet;
        }




    }
}
