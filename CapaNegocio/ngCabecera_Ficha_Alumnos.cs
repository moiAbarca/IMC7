using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;
using CapaDTO;
using System.Data;

namespace CapaNegocio
{
    public class ngCabecera_Ficha_Alumnos : Cabecera_Ficha_Alumnos
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
            this.Conec1.NombreTabla = "Cabecera_Ficha_Alumnos";
            this.Conec1.CadenaConexion = "Server=127.0.0.1;Database=IMC;Trusted_Connection=True;";
        }

        public DataSet retornaCabecera_Ficha_AlumnosDataSet()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Cabecera_Ficha_Alumnos";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            return this.Conec1.DbDataSet;
        }

        public void ingresaCabecera_Ficha_Alumnos(Cabecera_Ficha_Alumnos cabecera_Ficha_Alumnos)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO Cabecera_Ficha_Alumnos (Cod_Ficha, Rut, Rut_RRHH, Estatura, Peso, Fecha_Actualizacion, IdListaCurso) " +
                                     " VALUES ('" + cabecera_Ficha_Alumnos.Cod_Ficha + "','" + 
                                     cabecera_Ficha_Alumnos.Rut + "','" +
                                      cabecera_Ficha_Alumnos.Rut_RRHH + "','" + 
                                      cabecera_Ficha_Alumnos.Estatura + "','" +
                                      cabecera_Ficha_Alumnos.Peso + "','" + 
                                      cabecera_Ficha_Alumnos.Fecha_Actualizacion.ToString("yyyyMMdd") + "','" + 
                                      cabecera_Ficha_Alumnos.IdListaCurso + "');";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void actualizarCabecera_Ficha_Alumnos(Cabecera_Ficha_Alumnos cabecera_Ficha_Alumnos)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "UPDATE Cabecera_Ficha_Alumnos set Rut = '" +
                                     cabecera_Ficha_Alumnos.Rut + "', Rut_RRHH = '" + cabecera_Ficha_Alumnos.Rut_RRHH +
                                     "', Estatura = '" + cabecera_Ficha_Alumnos.Estatura +
                                     "', Peso = '" + cabecera_Ficha_Alumnos.Peso +
                                     "', Fecha_Actualizacion = '" + cabecera_Ficha_Alumnos.Fecha_Actualizacion.ToString("yyyyMMdd") +
                                      "', IdListaCurso = '" + cabecera_Ficha_Alumnos.IdListaCurso +
                                     "' WHERE Cod_Ficha = '" + cabecera_Ficha_Alumnos.Cod_Ficha + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void eliminarCabecera_Ficha_Alumnos(String Cod_Ficha)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM Cabecera_Ficha_Alumnos " +
                                    " WHERE Cod_Ficha = '" + Cod_Ficha + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public List<Cabecera_Ficha_Alumnos> retornaCabecera_Ficha_Alumnos()
        {
            List<Cabecera_Ficha_Alumnos> auxListadoCabecera_Ficha_Alumnos = new List<Cabecera_Ficha_Alumnos>();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Cabecera_Ficha_Alumnos";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            foreach (DataRow dr in this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla].Rows)
            {
                Cabecera_Ficha_Alumnos auxCabecera_Ficha_Alumnos = new Cabecera_Ficha_Alumnos();
                auxCabecera_Ficha_Alumnos.Cod_Ficha = (String)dr["Cod_Ficha"];
                auxCabecera_Ficha_Alumnos.Rut = (String)dr["Rut"];
                auxCabecera_Ficha_Alumnos.Rut_RRHH = (String)dr["Rut_RRHH"];
                auxCabecera_Ficha_Alumnos.Estatura = (double)dr["Estatura"];
                auxCabecera_Ficha_Alumnos.Peso = (double)dr["Peso"];
                auxCabecera_Ficha_Alumnos.Fecha_Actualizacion = (DateTime)dr["Fecha_Actualizacion"];
                auxCabecera_Ficha_Alumnos.IdListaCurso = (String)dr["IdListaCurso"];
                auxListadoCabecera_Ficha_Alumnos.Add(auxCabecera_Ficha_Alumnos);
            } //Fin for


            return auxListadoCabecera_Ficha_Alumnos;
        }

        public Cabecera_Ficha_Alumnos buscaCabecera_Ficha_Alumnos(string Cod_Ficha)
        {
            Cabecera_Ficha_Alumnos auxCabecera_Ficha_Alumnos = new Cabecera_Ficha_Alumnos();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Cabecera_Ficha_Alumnos " +
                                    " WHERE Cod_Ficha = '" + Cod_Ficha + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxCabecera_Ficha_Alumnos.Cod_Ficha = (String)dt.Rows[0]["Cod_Ficha"];
                auxCabecera_Ficha_Alumnos.Rut = (String)dt.Rows[0]["Rut"];
                auxCabecera_Ficha_Alumnos.Rut_RRHH = (String)dt.Rows[0]["Rut_RRHH"];
                auxCabecera_Ficha_Alumnos.Estatura = (double)dt.Rows[0]["Estatura"];
                auxCabecera_Ficha_Alumnos.Peso = (double)dt.Rows[0]["Peso"];
                auxCabecera_Ficha_Alumnos.Fecha_Actualizacion = (DateTime)dt.Rows[0]["Fecha_Actualizacion"];
                auxCabecera_Ficha_Alumnos.IdListaCurso = (String)dt.Rows[0]["IdListaCurso"];
            }
            catch (Exception ex)
            {
                auxCabecera_Ficha_Alumnos.Cod_Ficha = String.Empty;
                auxCabecera_Ficha_Alumnos.Rut = String.Empty;
                auxCabecera_Ficha_Alumnos.Rut_RRHH = String.Empty;
                auxCabecera_Ficha_Alumnos.Estatura = 0;
                auxCabecera_Ficha_Alumnos.Peso = 0;
                auxCabecera_Ficha_Alumnos.Fecha_Actualizacion = Convert.ToDateTime("1990 / 01 / 01");
                auxCabecera_Ficha_Alumnos.IdListaCurso = String.Empty;
            }

            return auxCabecera_Ficha_Alumnos;
        }

        public Cabecera_Ficha_Alumnos retornaPosicionCabecera_Ficha_Alumnos(int posicion)
        {
            Cabecera_Ficha_Alumnos auxCabecera_Ficha_Alumnos = new Cabecera_Ficha_Alumnos();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Cabecera_Ficha_Alumnos ";

            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxCabecera_Ficha_Alumnos.Cod_Ficha = (String)dt.Rows[0]["Cod_Ficha"];
                auxCabecera_Ficha_Alumnos.Rut = (String)dt.Rows[0]["Rut"];
                auxCabecera_Ficha_Alumnos.Rut_RRHH = (String)dt.Rows[0]["Rut_RRHH"];
                auxCabecera_Ficha_Alumnos.Estatura = (double)dt.Rows[0]["Estatura"];
                auxCabecera_Ficha_Alumnos.Peso = (double)dt.Rows[0]["Peso"];
                auxCabecera_Ficha_Alumnos.Fecha_Actualizacion = (DateTime)dt.Rows[0]["Fecha_Actualizacion"];
                auxCabecera_Ficha_Alumnos.IdListaCurso = (String)dt.Rows[0]["IdListaCurso"];
            }
            catch (Exception ex)
            {
                auxCabecera_Ficha_Alumnos.Cod_Ficha = String.Empty;
                auxCabecera_Ficha_Alumnos.Rut = String.Empty;
                auxCabecera_Ficha_Alumnos.Rut_RRHH = String.Empty;
                auxCabecera_Ficha_Alumnos.Estatura = 0;
                auxCabecera_Ficha_Alumnos.Peso = 0;
                auxCabecera_Ficha_Alumnos.Fecha_Actualizacion = Convert.ToDateTime("1990 / 01 / 01");
                auxCabecera_Ficha_Alumnos.IdListaCurso = String.Empty;
            }

            return auxCabecera_Ficha_Alumnos;
        }


    }
}
