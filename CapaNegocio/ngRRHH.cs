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
     public class ngRRHH : RRHH
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
            this.Conec1.NombreTabla = "RRHH";
            this.Conec1.CadenaConexion = "Server=127.0.0.1;Database=IMC;Trusted_Connection=True;";
        }

        public DataSet retornaRRHHDataSet()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM RRHH";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            return this.Conec1.DbDataSet;
        }

        public void ingresaRRHH(RRHH nRRHH)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO RRHH (Rut_RRHH, Cod_Tipo_RRHH, Nombre, Apellido, FechaNacimiento) " +
                                     " VALUES ('" + nRRHH.Rut_RRHH + "','" + nRRHH.Cod_Tipo_RRHH + "','" +
                                      nRRHH.Nombre + "','" + nRRHH.Apellido + "','" + nRRHH.FechaNacimiento.ToString("yyyyMMdd") + "');";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void actualizarRRHH(RRHH nRRHH)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "UPDATE RRHH set Cod_Tipo_RRHH = '" +
                                     nRRHH.Cod_Tipo_RRHH + "', Nombre = '" + nRRHH.Nombre +
                                     "', Apellido = '" + nRRHH.Apellido +
                                     "', FechaNacimiento = '" + nRRHH.FechaNacimiento.ToString("yyyyMMdd") +
                                     "' WHERE Rut_RRHH = '" + nRRHH.Rut_RRHH + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void eliminarRRHH(string Rut_RRHH)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM RRHH " +
                                    " WHERE Rut_RRHH = '" + Rut_RRHH + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public List<RRHH> retornaRRHH()
        {
            List<RRHH> auxListadoRRHH = new List<RRHH>();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM RRHH";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            foreach (DataRow dr in this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla].Rows)
            {
                RRHH auxRRHH = new RRHH();
                auxRRHH.Rut_RRHH = (String)dr["Rut_RRHH"];
                auxRRHH.Cod_Tipo_RRHH = (String)dr["Cod_Tipo_RRHH"];
                auxRRHH.Nombre = (String)dr["Nombre"];
                auxRRHH.Apellido = (String)dr["Apellido"];
                auxRRHH.FechaNacimiento = (DateTime)dr["FechaNacimiento"];
                
                auxListadoRRHH.Add(auxRRHH);
            } //Fin for


            return auxListadoRRHH;
        }

        public RRHH buscaRRHH(string Rut_RRHH)
        {
            RRHH auxRRHH = new RRHH();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM RRHH " +
                                    " WHERE Rut_RRHH = '" + Rut_RRHH + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxRRHH.Rut_RRHH = (String)dt.Rows[0]["Rut_RRHH"];
                auxRRHH.Cod_Tipo_RRHH = (String)dt.Rows[0]["Cod_Tipo_RRHH"];
                auxRRHH.Nombre = (String)dt.Rows[0]["Nombre"];
                auxRRHH.Apellido = (String)dt.Rows[0]["Apellido"];
                auxRRHH.FechaNacimiento = (DateTime)dt.Rows[0]["FechaNacimiento"];
                
            }
            catch (Exception ex)
            {
                auxRRHH.Rut_RRHH = String.Empty;
                auxRRHH.Cod_Tipo_RRHH = String.Empty;
                auxRRHH.Nombre = String.Empty;
                auxRRHH.Apellido = String.Empty;
                auxRRHH.FechaNacimiento = Convert.ToDateTime("1990 / 01 / 01");

            }

            return auxRRHH;
        }

        public RRHH retornaPosicionRRHH(int posicion)
        {
            RRHH auxRRHH = new RRHH();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM RRHH ";

            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxRRHH.Rut_RRHH = (String)dt.Rows[0]["Rut_RRHH"];
                auxRRHH.Cod_Tipo_RRHH = (String)dt.Rows[0]["Cod_Tipo_RRHH"];
                auxRRHH.Nombre = (String)dt.Rows[0]["Nombre"];
                auxRRHH.Apellido = (String)dt.Rows[0]["Apellido"];
                auxRRHH.FechaNacimiento = (DateTime)dt.Rows[0]["FechaNacimiento"];

            }
            catch (Exception ex)
            {
                auxRRHH.Rut_RRHH = String.Empty;
                auxRRHH.Cod_Tipo_RRHH = String.Empty;
                auxRRHH.Nombre = String.Empty;
                auxRRHH.Apellido = String.Empty;
                auxRRHH.FechaNacimiento = Convert.ToDateTime("19000101");
            }

            return auxRRHH;
        }

    }
}
