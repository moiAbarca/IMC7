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
    public class ngPeriodo : Periodo
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
            this.Conec1.NombreTabla = "Periodo";
            this.Conec1.CadenaConexion = "Data Source=MOI5BEC;Initial Catalog=IMC;Persist Security Info=True;User ID=sa";
        }

        public DataSet retornaPeriodoDataSet()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Periodo";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            return this.Conec1.DbDataSet;
        }

        public void ingresaPeriodo(Periodo periodo)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO Periodo (Cod_Periodo, Año, Semestre) " +
                                     " VALUES ('" + periodo.Cod_Periodo + "','" + periodo.Ano + "','" +
                                      periodo.Semestre + "');";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void actualizarPeriodo(Periodo periodo)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "UPDATE Periodo set Cod_Periodo = '" + periodo.Cod_Periodo +
                                     "', Año = '" + periodo.Ano +
                                     "', Semestre = '" + periodo.Semestre +

                                     "' WHERE Cod_Periodo = '" + periodo.Cod_Periodo + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void eliminarPeriodo(String Cod_Periodo)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM Periodo " +
                                    " WHERE Cod_Periodo = '" + Cod_Periodo + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public List<Periodo> retornaPeriodo()
        {
            List<Periodo> auxListadoPeriodo = new List<Periodo>();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Periodo";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            foreach (DataRow dr in this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla].Rows)
            {
                Periodo auxPeriodo = new Periodo();
                auxPeriodo.Cod_Periodo = (String)dr["Cod_Periodo"];
                auxPeriodo.Ano = (int)dr["Año"];
                auxPeriodo.Semestre = (String)dr["Semestre"];
                auxListadoPeriodo.Add(auxPeriodo);
            } //Fin for


            return auxListadoPeriodo;
        }

        public Periodo buscaPeriodo(string Cod_Periodo)
        {
            Periodo auxPeriodo = new Periodo();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Periodo " +
                                    " WHERE Cod_Periodo = '" + Cod_Periodo + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxPeriodo.Cod_Periodo = (String)dt.Rows[0]["Cod_Periodo"];
                auxPeriodo.Ano = (int)dt.Rows[0]["Año"];
                auxPeriodo.Semestre = (String)dt.Rows[0]["Semestre"];

            }
            catch (Exception ex)
            {
                auxPeriodo.Cod_Periodo = String.Empty;
                auxPeriodo.Ano = 0;
                auxPeriodo.Semestre = String.Empty;


            }

            return auxPeriodo;
        }

        public Periodo retornaPosicionPeriodo(int posicion)
        {
            Periodo auxPeriodo = new Periodo();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Periodo ";

            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxPeriodo.Cod_Periodo = (String)dt.Rows[0]["Cod_Periodo"];
                auxPeriodo.Ano = (int)dt.Rows[0]["Año"];
                auxPeriodo.Semestre = (String)dt.Rows[0]["Semestre"];

            }
            catch (Exception ex)
            {
                auxPeriodo.Cod_Periodo = String.Empty;
                auxPeriodo.Ano =0;
                auxPeriodo.Semestre = String.Empty;
            }

            return auxPeriodo;
        }

    }
}
