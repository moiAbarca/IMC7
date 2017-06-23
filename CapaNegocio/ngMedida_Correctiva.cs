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
    public class ngMedida_Correctiva : Medida_Correctiva
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
            this.Conec1.NombreTabla = "Medida_Correctiva";
            this.Conec1.CadenaConexion = "Data Source=MOI5BEC;Initial Catalog=IMC;Persist Security Info=True;User ID=sa";
        }

        public DataSet retornaMedida_CorrectivaDataSet()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Medida_Correctiva";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            return this.Conec1.DbDataSet;
        }

        public void ingresaMedida_Correctiva(Medida_Correctiva medida_Correctiva)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO Medida_Correctiva (Cod_MC, Cod_Detalle_Ficha, Cod_TMC, Descripcion, Fecha_Inicio, Fecha_Termino) " +
                                     " VALUES ('" + medida_Correctiva.Cod_MC + "','" + medida_Correctiva.Cod_Detalle_Ficha + "','" +
                                      medida_Correctiva.Cod_TMC + "','" + medida_Correctiva.Descripcion + "','" + medida_Correctiva.Fecha_Inicio + "','" + medida_Correctiva.Fecha_Termino + "');";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void actualizarMedida_Correctiva(Medida_Correctiva medida_Correctiva)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "UPDATE Medida_Correctiva set Cod_Detalle_Ficha = '" +
                                     medida_Correctiva.Cod_Detalle_Ficha + "', Cod_TMC = '" + medida_Correctiva.Cod_TMC +
                                     "', Descripcion = '" + medida_Correctiva.Descripcion +
                                     "', Fecha_Inicio = '" + medida_Correctiva.Fecha_Inicio +
                                     "', Fecha_Termino = '" + medida_Correctiva.Fecha_Termino +
                                     "' WHERE Cod_MC = '" + medida_Correctiva.Cod_MC + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void eliminarMedida_Correctiva(String Cod_MC)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM Medida_Correctiva " +
                                    " WHERE Cod_MC = '" + Cod_MC + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public List<Medida_Correctiva> retornaMedida_Correctiva()
        {
            List<Medida_Correctiva> auxListadoMedida_Correctiva = new List<Medida_Correctiva>();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Medida_Correctiva";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            foreach (DataRow dr in this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla].Rows)
            {
                Medida_Correctiva auxMedida_Correctiva = new Medida_Correctiva();
                auxMedida_Correctiva.Cod_MC = (String)dr["Cod_MC"];
                auxMedida_Correctiva.Cod_Detalle_Ficha = (String)dr["Cod_Detalle_Ficha"];
                auxMedida_Correctiva.Cod_TMC = (String)dr["Cod_TMC"];
                auxMedida_Correctiva.Descripcion = (String)dr["Descripcion"];
                auxMedida_Correctiva.Fecha_Inicio = (String)dr["Fecha_Inicio"];
                auxMedida_Correctiva.Fecha_Termino = (String)dr["Fecha_Termino"];
                auxListadoMedida_Correctiva.Add(auxMedida_Correctiva);
            } //Fin for


            return auxListadoMedida_Correctiva;
        }

        public Medida_Correctiva buscaMedida_Correctiva(string Cod_MC)
        {
            Medida_Correctiva auxMedida_Correctiva = new Medida_Correctiva();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Medida_Correctiva " +
                                    " WHERE Cod_MC = '" + Cod_MC + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxMedida_Correctiva.Cod_MC = (String)dt.Rows[0]["Cod_MC"];
                auxMedida_Correctiva.Cod_Detalle_Ficha = (String)dt.Rows[0]["Cod_Detalle_Ficha"];
                auxMedida_Correctiva.Cod_TMC = (String)dt.Rows[0]["Cod_TMC"];
                auxMedida_Correctiva.Descripcion = (String)dt.Rows[0]["Descripcion"];
                auxMedida_Correctiva.Fecha_Inicio = (String)dt.Rows[0]["Fecha_Inicio"];
                auxMedida_Correctiva.Fecha_Termino = (String)dt.Rows[0]["Fecha_Termino"];
            }
            catch (Exception ex)
            {
                auxMedida_Correctiva.Cod_MC = String.Empty;
                auxMedida_Correctiva.Cod_Detalle_Ficha = String.Empty;
                auxMedida_Correctiva.Cod_TMC = String.Empty;
                auxMedida_Correctiva.Descripcion = String.Empty;
                auxMedida_Correctiva.Fecha_Inicio = String.Empty;
                auxMedida_Correctiva.Fecha_Termino = String.Empty;
            }

            return auxMedida_Correctiva;
        }

        public Medida_Correctiva retornaPosicionMedida_Correctiva(int posicion)
        {
            Medida_Correctiva auxMedida_Correctiva = new Medida_Correctiva();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Medida_Correctiva ";

            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxMedida_Correctiva.Cod_MC = (String)dt.Rows[0]["Cod_MC"];
                auxMedida_Correctiva.Cod_Detalle_Ficha = (String)dt.Rows[0]["Cod_Detalle_Ficha"];
                auxMedida_Correctiva.Cod_TMC = (String)dt.Rows[0]["Cod_TMC"];
                auxMedida_Correctiva.Descripcion = (String)dt.Rows[0]["Descripcion"];
                auxMedida_Correctiva.Fecha_Inicio = (String)dt.Rows[0]["Fecha_Inicio"];
                auxMedida_Correctiva.Fecha_Termino = (String)dt.Rows[0]["Fecha_Termino"];
            }
            catch (Exception ex)
            {
                auxMedida_Correctiva.Cod_MC = String.Empty;
                auxMedida_Correctiva.Cod_Detalle_Ficha = String.Empty;
                auxMedida_Correctiva.Cod_TMC = String.Empty;
                auxMedida_Correctiva.Descripcion = String.Empty;
                auxMedida_Correctiva.Fecha_Inicio = String.Empty;
                auxMedida_Correctiva.Fecha_Termino = String.Empty;
            }

            return auxMedida_Correctiva;
        }

    }
}
