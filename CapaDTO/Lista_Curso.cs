using CapaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Lista_Curso
    {
        public Lista_Curso() { }

        #region Propiedades
        private int _idListaCurso;
        private string _rut;
        private string _cod_Curso;
        private int _ano;
        private string _semestre;
        

        public int IdListaCurso
        {
            get
            {
                return _idListaCurso;
            }

            set
            {
                _idListaCurso = value;
            }
        }

        public string Rut
        {
            get
            {
                return _rut;
            }

            set
            {
                _rut = value;
            }
        }

        

        public string Cod_Curso
        {
            get
            {
                return _cod_Curso;
            }

            set
            {
                _cod_Curso = value;
            }
        }

        public int Ano
        {
            get
            {
                return _ano;
            }

            set
            {
                _ano = value;
            }
        }

        public string Semestre
        {
            get
            {
                return _semestre;
            }

            set
            {
                _semestre = value;
            }
        }
        #endregion
    }
}
        //#endregion

        //#region Public Methods
        ////obtener datos de un Lista_Curso o una lista de Lista_Curso
        ////si nLista_Curso es igual a cero, trae a todos los Lista_Curso
        //public List<Lista_Curso> ObtenerPersonal(int nLista_Curso)
        //{
        //    List<Lista_Curso> lst = new List<Lista_Curso>();
        //    return lst;
        //}
        //#endregion
