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
    public class ngCargo : Cargo
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
            this.Conec1.NombreTabla = "Cargo";
            this.Conec1.CadenaConexion = "Data Source=MOI5BEC;Initial Catalog=IMC;Persist Security Info=True;User ID=sa";
        }

        public DataSet retornaCargoDataSet()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Cargo";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            return this.Conec1.DbDataSet;
        }

        public void ingresaCargo(Cargo cargo)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO Cargo (Cod_Tipo_RRHH,Nombre_Tipo) " +
                                     " VALUES ('" + cargo.Cod_Tipo_RRHH + "','" + cargo.Nombre_Tipo + "');";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void actualizarCargo(Cargo cargo)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "UPDATE Cargo set Nombre_Tipo = '" +
                                     cargo.Nombre_Tipo +
                                     "' WHERE Cod_Tipo_RRHH = '" + cargo.Cod_Tipo_RRHH + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void eliminarCargo(String Cod_Tipo_RRHH)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM Cargo " +
                                    " WHERE Cod_Tipo_RRHH = '" + Cod_Tipo_RRHH + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public List<Cargo> retornaCargo()
        {
            List<Cargo> auxListadoCargo = new List<Cargo>();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Cargo";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            foreach (DataRow dr in this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla].Rows)
            {
                Cargo auxCargo = new Cargo();
                auxCargo.Cod_Tipo_RRHH = (String)dr["Cod_Tipo_RRHH"];
                auxCargo.Nombre_Tipo = (String)dr["Nombre_Tipo"];
                auxListadoCargo.Add(auxCargo);
            } //Fin for


            return auxListadoCargo;
        }

        public Cargo buscaCargo(int Cod_Tipo_RRHH)
        {
            Cargo auxCargo = new Cargo();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Cargo " +
                                    " WHERE Cod_Tipo_RRHH = '" + Cod_Tipo_RRHH + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxCargo.Cod_Tipo_RRHH = (String)dt.Rows[0]["Cod_Tipo_RRHH"];
                auxCargo.Nombre_Tipo = (String)dt.Rows[0]["Nombre_Tipo"];
            }
            catch (Exception ex)
            {
                auxCargo.Cod_Tipo_RRHH = String.Empty;
                auxCargo.Nombre_Tipo = String.Empty;
            }

            return auxCargo;
        }

        public Cargo retornaPosicionCargo(int posicion)
        {
            Cargo auxCargo = new Cargo();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Cargo ";

            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxCargo.Cod_Tipo_RRHH = (String)dt.Rows[0]["Cod_Tipo_RRHH"];
                auxCargo.Nombre_Tipo = (String)dt.Rows[0]["Nombre_Tipo"];
            }
            catch (Exception ex)
            {
                auxCargo.Cod_Tipo_RRHH = String.Empty;
                auxCargo.Nombre_Tipo = String.Empty;
            }

            return auxCargo;
        }


    }
}
