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
    public class ngCurso : Curso
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
            this.Conec1.NombreTabla = "Curso";
            this.Conec1.CadenaConexion = "Data Source=MOI5BEC;Initial Catalog=IMC;Persist Security Info=True;User ID=sa";
        }

        public DataSet retornaCursoDataSet()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Curso";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            return this.Conec1.DbDataSet;
        }

        public void ingresaCurso(Curso curso)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO Curso (Cod_Curso, Curso, Jornada, Cod_Periodo, Cod_Colegio) " +
                                     " VALUES ('" + curso.Cod_Curso + "','" + curso.NombreCurso + "','" +
                                      curso.Jornada + "','" + curso.Cod_Periodo + "','" + curso.Cod_Colegio + "');";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void actualizarCurso(Curso curso)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "UPDATE Curso set Curso = '" + curso.NombreCurso +
                                     "', Jornada = '" + curso.Jornada +
                                     "', Cod_Periodo = '" + curso.Cod_Periodo +
                                     "', Cod_Colegio = '" + curso.Cod_Colegio +
                                     "' WHERE Cod_Curso = '" + curso.Cod_Curso + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void eliminarCurso(String Cod_Curso)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM Curso " +
                                    " WHERE Cod_Curso = '" + Cod_Curso + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public List<Curso> retornaCurso()
        {
            List<Curso> auxListadoCurso = new List<Curso>();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Curso";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            foreach (DataRow dr in this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla].Rows)
            {
                Curso auxCurso = new Curso();
                auxCurso.Cod_Curso = (String)dr["Cod_Curso"];
                auxCurso.NombreCurso = (String)dr["Curso"];
                auxCurso.Jornada = (String)dr["Jornada"];
                auxCurso.Cod_Periodo = (String)dr["Cod_Periodo"];
                auxCurso.Cod_Colegio = (String)dr["Cod_Colegio"];
                auxListadoCurso.Add(auxCurso);
            } //Fin for


            return auxListadoCurso;
        }

        public Curso buscaCurso(string Cod_Curso)
        {
            Curso auxCurso = new Curso();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Curso " +
                                    " WHERE Cod_Curso = '" + Cod_Curso + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxCurso.Cod_Curso = (String)dt.Rows[0]["Cod_Curso"];
                auxCurso.NombreCurso = (String)dt.Rows[0]["Curso"];
                auxCurso.Jornada = (String)dt.Rows[0]["Jornada"];
                auxCurso.Cod_Periodo = (String)dt.Rows[0]["Cod_Periodo"];
                auxCurso.Cod_Colegio = (String)dt.Rows[0]["Cod_Colegio"];
               
            }
            catch (Exception ex)
            {
                auxCurso.Cod_Curso = String.Empty;
                auxCurso.NombreCurso = String.Empty;
                auxCurso.Jornada = String.Empty;
                auxCurso.Cod_Periodo = String.Empty;
                auxCurso.Cod_Colegio = String.Empty;

            }

            return auxCurso;
        }

        public Curso retornaPosicionCurso(int posicion)
        {
            Curso auxCurso = new Curso();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Curso ";

            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxCurso.Cod_Curso = (String)dt.Rows[0]["Cod_Curso"];
                auxCurso.NombreCurso = (String)dt.Rows[0]["Curso"];
                auxCurso.Jornada = (String)dt.Rows[0]["Jornada"];
                auxCurso.Cod_Periodo = (String)dt.Rows[0]["Cod_Periodo"];
                auxCurso.Cod_Colegio = (String)dt.Rows[0]["Cod_Colegio"];

            }
            catch (Exception ex)
            {
                auxCurso.Cod_Curso = String.Empty;
                auxCurso.NombreCurso = String.Empty;
                auxCurso.Jornada = String.Empty;
                auxCurso.Cod_Periodo = String.Empty;
                auxCurso.Cod_Colegio = String.Empty;
            }

            return auxCurso;
        }

    }
}
