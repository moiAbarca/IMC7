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
    public class ngColegio : Colegio
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
            this.Conec1.NombreTabla = "Colegio";
            this.Conec1.CadenaConexion = "Data Source=MOI5BEC;Initial Catalog=IMC;Persist Security Info=True;User ID=sa";
        }

        public DataSet retornaColegioDataSet()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Colegio";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            return this.Conec1.DbDataSet;
        }

        public void ingresaCurso(Colegio colegio)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO Colegio (Cod_Colegio, Nombre, Direccion, Telefono) " +
                                     " VALUES ('" + colegio.Cod_Colegio + "','" + colegio.Nombre + "','" +
                                      colegio.Direccion + "','" + colegio.Telefono + "');";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void actualizarColegio(Colegio colegio)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "UPDATE Colegio set Nombre = '" + colegio.Nombre +
                                     "', Direccion = '" + colegio.Direccion +
                                     "', Telefono = '" + colegio.Telefono +

                                     "' WHERE Cod_Colegio = '" + colegio.Cod_Colegio + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void eliminarColegio(String Cod_Colegio)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM Colegio " +
                                    " WHERE Cod_Colegio = '" + Cod_Colegio + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public List<Colegio> retornaColegio()
        {
            List<Colegio> auxListadoColegio = new List<Colegio>();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Colegio";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            foreach (DataRow dr in this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla].Rows)
            {
                Colegio auxColegio = new Colegio();
                auxColegio.Cod_Colegio = (String)dr["Cod_Colegio"];
                auxColegio.Nombre = (String)dr["Nombre"];
                auxColegio.Direccion = (String)dr["Direccion"];
                auxColegio.Telefono = (String)dr["Telefono"];
                auxListadoColegio.Add(auxColegio);
            } //Fin for


            return auxListadoColegio;
        }

        public Colegio buscColegio(string Cod_Colegio)
        {
            Colegio auxColegio = new Colegio();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Colegio " +
                                    " WHERE Cod_Colegio = '" + Cod_Colegio + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxColegio.Cod_Colegio = (String)dt.Rows[0]["Cod_Colegio"];
                auxColegio.Nombre = (String)dt.Rows[0]["Nombre"];
                auxColegio.Direccion = (String)dt.Rows[0]["Direccion"];
                auxColegio.Telefono = (String)dt.Rows[0]["Telefono"];

            }
            catch (Exception ex)
            {
                auxColegio.Cod_Colegio = String.Empty;
                auxColegio.Nombre = String.Empty;
                auxColegio.Direccion = String.Empty;
                auxColegio.Telefono = String.Empty;
                

            }

            return auxColegio;
        }

        public Colegio retornaPosicionColegio(int posicion)
        {
            Colegio auxColegio = new Colegio();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Colegio ";

            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxColegio.Cod_Colegio = (String)dt.Rows[0]["Cod_Colegio"];
                auxColegio.Nombre = (String)dt.Rows[0]["Nombre"];
                auxColegio.Direccion = (String)dt.Rows[0]["Direccion"];
                auxColegio.Telefono = (String)dt.Rows[0]["Telefono"];

            }
            catch (Exception ex)
            {
                auxColegio.Cod_Colegio = String.Empty;
                auxColegio.Nombre = String.Empty;
                auxColegio.Direccion = String.Empty;
                auxColegio.Telefono = String.Empty;
            }

            return auxColegio;
        }

    }
}
