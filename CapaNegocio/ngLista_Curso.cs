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
    public class ngLista_Curso : Lista_Curso
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
            this.Conec1.NombreTabla = "Lista_Curso";
            this.Conec1.CadenaConexion = "Server=127.0.0.1;Database=IMC;Trusted_Connection=True;";
        }

        public DataSet retornaLista_CursoDataSet()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Lista_Curso";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            return this.Conec1.DbDataSet;
        }

        public void ingresaLista_Curso(Lista_Curso lista_Curso)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO Lista_Curso (IdListaCurso, Rut, Nombre, Apellido, Edad, Cod_Curso) " +
                                     " VALUES ('" +lista_Curso.IdListaCurso + "','" + lista_Curso.Rut + "','" + lista_Curso.Cod_Curso + "','" +lista_Curso.Ano + "','"+ lista_Curso.Semestre + "');";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void actualizarLista_Curso(Lista_Curso lista_Curso)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "UPDATE Lista_Curso set Rut = '" +
                                     lista_Curso.Rut + 
                                     "', Cod_Curso = '" + lista_Curso.Cod_Curso +
                                     "', Ano = '" + lista_Curso.Ano +
                                     "', Semestre = '" + lista_Curso.Semestre +
                                     "' WHERE IdListaCurso = '" + lista_Curso.IdListaCurso + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public void eliminarLista_Curso(String IdListaCurso)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM Lista_Curso " +
                                    " WHERE IdListaCurso = '" + IdListaCurso + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }

        public List<Lista_Curso> retornaLista_Curso()
        {
            List<Lista_Curso> auxListadoLista_Curso = new List<Lista_Curso>();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Lista_Curso";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();

            foreach (DataRow dr in this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla].Rows)
            {
                Lista_Curso auxLista_Curso = new Lista_Curso();
                auxLista_Curso.IdListaCurso = (int)dr["IdListaCurso"];
                auxLista_Curso.Rut = (String)dr["Rut"];
                
                auxLista_Curso.Cod_Curso = (String)dr["Cod_Curso"];
                auxLista_Curso.Ano = (int)dr["Ano"];
                auxLista_Curso.Semestre = (String)dr["Semestre"];
                auxListadoLista_Curso.Add(auxLista_Curso);
            } //Fin for


            return auxListadoLista_Curso;
        }

        public Lista_Curso buscaLista_Curso(int IdListaCurso)
        {
            Lista_Curso auxLista_Curso = new Lista_Curso();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Lista_Curso " +
                                    " WHERE IdListaCurso = '" + IdListaCurso + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxLista_Curso.IdListaCurso = (int)dt.Rows[0]["IdListaCurso"];
                auxLista_Curso.Rut = (String)dt.Rows[0]["Rut"];
                
                auxLista_Curso.Cod_Curso = (String)dt.Rows[0]["Cod_Curso"];
                auxLista_Curso.Ano = (int)dt.Rows[0]["Ano"];
                auxLista_Curso.Semestre = (String)dt.Rows[0]["Semestre"];
            }
            catch (Exception ex)
            {
                auxLista_Curso.IdListaCurso = 0;
                auxLista_Curso.Rut = String.Empty;
                
                auxLista_Curso.Cod_Curso = String.Empty;
                auxLista_Curso.Ano = 0;
                auxLista_Curso.Semestre = "";
            }

            return auxLista_Curso;
        }

        public Lista_Curso retornaPosicionLista_Curso(int posicion)
        {
            Lista_Curso auxLista_Curso = new Lista_Curso();
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM Lista_Curso ";

            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxLista_Curso.IdListaCurso = (int)dt.Rows[0]["IdListaCurso"];
                auxLista_Curso.Rut = (String)dt.Rows[0]["Rut"];

                auxLista_Curso.Cod_Curso = (String)dt.Rows[0]["Cod_Curso"];
                auxLista_Curso.Ano = (int)dt.Rows[0]["Ano"];
                auxLista_Curso.Semestre = (String)dt.Rows[0]["Semestre"];
            }
            catch (Exception ex)
            {
                auxLista_Curso.IdListaCurso = 0;
                auxLista_Curso.Rut = String.Empty;

                auxLista_Curso.Cod_Curso = String.Empty;
                auxLista_Curso.Ano = 0;
                auxLista_Curso.Semestre = "";
            }

            return auxLista_Curso;
        }
    }
}
