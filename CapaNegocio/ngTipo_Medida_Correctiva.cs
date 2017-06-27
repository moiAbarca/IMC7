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
    public class ngTipo_Medida_Correctiva : Tipo_Medida_Correctiva
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
            this.Conec1.NombreTabla = "Tipo_Medida_Correctiva";
            this.Conec1.CadenaConexion = "Server=127.0.0.1;Database=IMC;Trusted_Connection=True;";
        }

        public DataSet retornaTipo_Medida_CorrectivaDataSet()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Tipo_Medida_Correctiva";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            return this.Conec1.DbDataSet;
        }

        public void ingresaTipo_Medida_Correctiva(Tipo_Medida_Correctiva tipo_Medida_Correctiva)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO Tipo_Medida_Correctiva (Cod_TMC, Tipo_Medida, Descripcion) " +
                                     " VALUES ('" + tipo_Medida_Correctiva.Cod_TMC + "','" + tipo_Medida_Correctiva.Tipo_Medida + "','" +
                                      tipo_Medida_Correctiva.Descripcion + "');";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void actualizarTipo_Medida_Correctiva(Tipo_Medida_Correctiva tipo_Medida_Correctiva)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "UPDATE Tipo_Medida_Correctiva set Tipo_Medida = '" +
                                     tipo_Medida_Correctiva.Tipo_Medida +
                                     "', Descripcion = '" + tipo_Medida_Correctiva.Descripcion +
                                     "' WHERE Cod_TMC = '" + tipo_Medida_Correctiva.Cod_TMC + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void eliminarTipo_Medida_Correctiva(String Cod_TMC)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM Tipo_Medida_Correctiva " +
                                    " WHERE Cod_TMC = '" + Cod_TMC + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public List<Tipo_Medida_Correctiva> retornaTipo_Medida_Correctiva()
        {
            List<Tipo_Medida_Correctiva> auxListadoTipo_Medida_Correctiva = new List<Tipo_Medida_Correctiva>();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Tipo_Medida_Correctiva";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            foreach (DataRow dr in this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla].Rows)
            {
                Tipo_Medida_Correctiva auxTipo_Medida_Correctiva = new Tipo_Medida_Correctiva();
                auxTipo_Medida_Correctiva.Cod_TMC = (String)dr["Cod_TMC"];
                auxTipo_Medida_Correctiva.Tipo_Medida = (String)dr["Tipo_Medida"];
                auxTipo_Medida_Correctiva.Descripcion = (String)dr["Descripcion"];
                auxListadoTipo_Medida_Correctiva.Add(auxTipo_Medida_Correctiva);
            } //Fin for


            return auxListadoTipo_Medida_Correctiva;
        }

        public Tipo_Medida_Correctiva buscaTipo_Medida_Correctiva(string Cod_TMC)
        {
            Tipo_Medida_Correctiva auxTipo_Medida_Correctiva = new Tipo_Medida_Correctiva();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Tipo_Medida_Correctiva " +
                                    " WHERE Cod_TMC = '" + Cod_TMC + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxTipo_Medida_Correctiva.Cod_TMC = (String)dt.Rows[0]["Cod_TMC"];
                auxTipo_Medida_Correctiva.Tipo_Medida = (String)dt.Rows[0]["Tipo_Medida"];
                auxTipo_Medida_Correctiva.Descripcion = (String)dt.Rows[0]["Descripcion"];
            }
            catch (Exception ex)
            {
                auxTipo_Medida_Correctiva.Cod_TMC = String.Empty;
                auxTipo_Medida_Correctiva.Tipo_Medida = String.Empty;
                auxTipo_Medida_Correctiva.Descripcion = String.Empty;
                
            }

            return auxTipo_Medida_Correctiva;
        }

        public Tipo_Medida_Correctiva retornaPosicionTipo_Medida_Correctiva(int posicion)
        {
            Tipo_Medida_Correctiva auxTipo_Medida_Correctiva = new Tipo_Medida_Correctiva();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Tipo_Medida_Correctiva ";

            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxTipo_Medida_Correctiva.Cod_TMC = (String)dt.Rows[0]["Cod_TMC"];
                auxTipo_Medida_Correctiva.Tipo_Medida = (String)dt.Rows[0]["Tipo_Medida"];
                auxTipo_Medida_Correctiva.Descripcion = (String)dt.Rows[0]["Descripcion"];
            }
            catch (Exception ex)
            {
                auxTipo_Medida_Correctiva.Cod_TMC = String.Empty;
                auxTipo_Medida_Correctiva.Tipo_Medida = String.Empty;
                auxTipo_Medida_Correctiva.Descripcion = String.Empty;
            }

            return auxTipo_Medida_Correctiva;
        }

    }
}
