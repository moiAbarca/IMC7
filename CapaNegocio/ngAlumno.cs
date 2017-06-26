using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;
using CapaDTO;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
     public class ngAlumno: Alumno
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
            this.Conec1.NombreTabla = "Alumno";
            this.Conec1.CadenaConexion = "Server=127.0.0.1;Database=IMC;Trusted_Connection=True;";
        }

        public DataSet retornaAlumnoDataSet()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Alumno";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            return this.Conec1.DbDataSet;
        }

        public void ingresaAlumno(Alumno alumno)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO Alumno (Rut,Nombre, Apellido, FechaNacimiento) " +
                                     " VALUES ('" + alumno.Rut + "','" +
                                      alumno.Nombre + "','" +alumno.Apellido + "','" +alumno.FechaNacimiento.ToString("yyyyMMdd") + "');";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void actualizarAlumno(Alumno alumno)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "UPDATE Alumno set Nombre = '" +
                                     alumno.Nombre +
                                     "', Apellido = '" + alumno.Apellido +
                                     "', FechaNacimiento = '" + alumno.FechaNacimiento.ToString("yyyyMMdd") +
                                     "' WHERE Rut = '" + alumno.Rut + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void eliminarAlumno(String Rut)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM Alumno " +
                                    " WHERE Rut = '" + Rut + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public List<Alumno> retornaAlumno()
        {
            List<Alumno> auxListadoAlumno = new List<Alumno>();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Alumno";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            foreach (DataRow dr in this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla].Rows)
            {
                Alumno auxAlumno = new Alumno();
                auxAlumno.Rut = (String)dr["Rut"];
                auxAlumno.Nombre = (String)dr["Nombre"];
                auxAlumno.Apellido = (String)dr["Apellido"];
                auxAlumno.FechaNacimiento = (DateTime)dr["FechaNacimiento"];
                auxListadoAlumno.Add(auxAlumno);
            } //Fin for


            return auxListadoAlumno;
        }

        public Alumno buscaAlumno(String Rut)
        {
            
            Alumno auxAlumno = new Alumno();
           
            this.configurarConexion();

            this.Conec1.CadenaSQL = "SELECT * FROM Alumno WHERE RUT = '" + Rut + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxAlumno.Rut = (String)dt.Rows[0]["Rut"];
                auxAlumno.Nombre = (String)dt.Rows[0]["Nombre"];
                auxAlumno.Apellido = (String)dt.Rows[0]["Apellido"];
                auxAlumno.FechaNacimiento = (DateTime)dt.Rows[0]["FechaNacimiento"];

            }
            catch (Exception ex)
            {
                auxAlumno.Rut = String.Empty;
                auxAlumno.Nombre = String.Empty;
                auxAlumno.Apellido = String.Empty;
                auxAlumno.FechaNacimiento = Convert.ToDateTime("1990 / 01 / 01");
            }

            return auxAlumno;
        }

        public Alumno retornaPosicionAlumno(int posicion)
        {
            Alumno auxAlumno = new Alumno();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Alumno ";

            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxAlumno.Rut = (String)dt.Rows[0]["Rut"];
                auxAlumno.Nombre = (String)dt.Rows[0]["Nombre"];
                auxAlumno.Apellido = (String)dt.Rows[0]["Apellido"];
                auxAlumno.FechaNacimiento = (DateTime)dt.Rows[0]["FechaNacimiento"];
            }
            catch (Exception ex)
            {
                auxAlumno.Rut = String.Empty;
                auxAlumno.Nombre = String.Empty;
                auxAlumno.Apellido = String.Empty;
                auxAlumno.FechaNacimiento = Convert.ToDateTime("01/01/1900");
            }

            return auxAlumno;
        }
    }
}
