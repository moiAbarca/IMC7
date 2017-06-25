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
    public class ngDetalle_Ficha_Alumno : Detalle_Ficha_Alumno
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

        public DataSet retornaDetalle_Ficha_AlumnoDataSet()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Detalle_Ficha_Alumno";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            return this.Conec1.DbDataSet;
        }

        public void ingresaDetalle_Ficha_Alumno(Detalle_Ficha_Alumno detalle_Ficha_Alumno)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO Detalle_Ficha_Alumno (Cod_Detalle_Ficha, Cod_Ficha, Valor_IMC, Clasificacion_IMC, Fecha_Revision, Fecha_Proxima_Revision) " +
                                     " VALUES ('" + detalle_Ficha_Alumno.Cod_Detalle_Ficha + "','" + detalle_Ficha_Alumno.Cod_Ficha + 
                                     ",''CAST(" + detalle_Ficha_Alumno.Valor_IMC + " AS FLOAT)'','" 
                                      + detalle_Ficha_Alumno.Clasificacion_IMC + "','" + detalle_Ficha_Alumno.Fecha_Revision + "','" + detalle_Ficha_Alumno.Fecha_Proxima_Revision + "');";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void actualizarDetalle_Ficha_Alumno(Detalle_Ficha_Alumno detalle_Ficha_Alumno)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "UPDATE Detalle_Ficha_Alumno set Cod_Ficha = '" +
                                     detalle_Ficha_Alumno.Cod_Ficha + "', Valor_IMC = '" + detalle_Ficha_Alumno.Valor_IMC +
                                     "', Clasificacion_IMC = '" + detalle_Ficha_Alumno.Clasificacion_IMC +
                                     "', Fecha_Revision = '" + detalle_Ficha_Alumno.Fecha_Revision +
                                     "', Fecha_Proxima_Revision = '" + detalle_Ficha_Alumno.Fecha_Proxima_Revision +
                                     "' WHERE Cod_Detalle_Ficha = '" + detalle_Ficha_Alumno.Cod_Detalle_Ficha + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void eliminarDetalle_Ficha_Alumno(String Cod_Detalle_Ficha)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM Detalle_Ficha_Alumno " +
                                    " WHERE Cod_Detalle_Ficha = '" + Cod_Detalle_Ficha + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public List<Detalle_Ficha_Alumno> retornaDetalle_Ficha_Alumno()
        {
            List<Detalle_Ficha_Alumno> auxListadoDetalle_Ficha_Alumno = new List<Detalle_Ficha_Alumno>();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Detalle_Ficha_Alumno";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            foreach (DataRow dr in this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla].Rows)
            {
                Detalle_Ficha_Alumno auxDetalle_Ficha_Alumno = new Detalle_Ficha_Alumno();
                auxDetalle_Ficha_Alumno.Cod_Detalle_Ficha = (String)dr["Cod_Detalle_Ficha"];
                auxDetalle_Ficha_Alumno.Cod_Ficha = (String)dr["Cod_Ficha"];
                auxDetalle_Ficha_Alumno.Valor_IMC = (double)dr["Valor_IMC"];
                auxDetalle_Ficha_Alumno.Clasificacion_IMC = (String)dr["Clasificacion_IMC"];
                auxDetalle_Ficha_Alumno.Fecha_Revision = (DateTime)dr["Fecha_Revision"];
                auxDetalle_Ficha_Alumno.Fecha_Proxima_Revision = (DateTime)dr["Fecha_Proxima_Revision"];
                auxListadoDetalle_Ficha_Alumno.Add(auxDetalle_Ficha_Alumno);
            } //Fin for


            return auxListadoDetalle_Ficha_Alumno;
        }

        public Detalle_Ficha_Alumno buscaDetalle_Ficha_Alumno(string Cod_Detalle_Ficha)
        {
            Detalle_Ficha_Alumno auxDetalle_Ficha_Alumno = new Detalle_Ficha_Alumno();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Detalle_Ficha_Alumno " +
                                    " WHERE Cod_Detalle_Ficha = '" + Cod_Detalle_Ficha + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxDetalle_Ficha_Alumno.Cod_Detalle_Ficha = (String)dt.Rows[0]["Cod_Detalle_Ficha"];
                auxDetalle_Ficha_Alumno.Cod_Ficha = (String)dt.Rows[0]["Cod_Ficha"];
                auxDetalle_Ficha_Alumno.Valor_IMC = (double)dt.Rows[0]["Valor_IMC"];
                auxDetalle_Ficha_Alumno.Clasificacion_IMC = (String)dt.Rows[0]["Clasificacion_IMC"];
                auxDetalle_Ficha_Alumno.Fecha_Revision = (DateTime)dt.Rows[0]["Fecha_Revision"];
                auxDetalle_Ficha_Alumno.Fecha_Proxima_Revision = (DateTime)dt.Rows[0]["Fecha_Proxima_Revision"];
            }
            catch (Exception ex)
            {
                auxDetalle_Ficha_Alumno.Cod_Detalle_Ficha = String.Empty;
                auxDetalle_Ficha_Alumno.Cod_Ficha = String.Empty;
                auxDetalle_Ficha_Alumno.Valor_IMC = 0;
                auxDetalle_Ficha_Alumno.Clasificacion_IMC = String.Empty;
                auxDetalle_Ficha_Alumno.Fecha_Revision = Convert.ToDateTime("19900101");
                auxDetalle_Ficha_Alumno.Fecha_Proxima_Revision = Convert.ToDateTime("19900101");
            }

            return auxDetalle_Ficha_Alumno;
        }

        public Detalle_Ficha_Alumno retornaPosicionDetalle_Ficha_Alumno(int posicion)
        {
            Detalle_Ficha_Alumno auxDetalle_Ficha_Alumno = new Detalle_Ficha_Alumno();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Detalle_Ficha_Alumno ";

            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxDetalle_Ficha_Alumno.Cod_Detalle_Ficha = (String)dt.Rows[0]["Cod_Detalle_Ficha"];
                auxDetalle_Ficha_Alumno.Cod_Ficha = (String)dt.Rows[0]["Cod_Ficha"];
                auxDetalle_Ficha_Alumno.Valor_IMC = (double)dt.Rows[0]["Valor_IMC"];
                auxDetalle_Ficha_Alumno.Clasificacion_IMC = (String)dt.Rows[0]["Clasificacion_IMC"];
                auxDetalle_Ficha_Alumno.Fecha_Revision = (DateTime)dt.Rows[0]["Fecha_Revision"];
                auxDetalle_Ficha_Alumno.Fecha_Proxima_Revision = (DateTime)dt.Rows[0]["Fecha_Proxima_Revision"];
            }
            catch (Exception ex)
            {
                auxDetalle_Ficha_Alumno.Cod_Detalle_Ficha = String.Empty;
                auxDetalle_Ficha_Alumno.Cod_Ficha = String.Empty;
                auxDetalle_Ficha_Alumno.Valor_IMC = 0;
                auxDetalle_Ficha_Alumno.Clasificacion_IMC = String.Empty;
                auxDetalle_Ficha_Alumno.Fecha_Revision = Convert.ToDateTime("19900101");
                auxDetalle_Ficha_Alumno.Fecha_Proxima_Revision = Convert.ToDateTime("19900101");
            }

            return auxDetalle_Ficha_Alumno;
        }

        public double calculaIMC(double peso, double altura)
        {
            double IMCcalculado;
            double tallaMEtro = altura / 100;
            return IMCcalculado = (peso / (Math.Pow(tallaMEtro, 2)));
        }



    }
}
