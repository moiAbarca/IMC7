using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Curso
    {
        public Curso() { }

        #region Propiedades
        private string _cod_Curso;
        private string _nombreCurso;
        private string _jornada;
        private string _cod_Periodo;
        private string _cod_Colegio;

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

        public string NombreCurso
        {
            get
            {
                return _nombreCurso;
            }

            set
            {
                _nombreCurso = value;
            }
        }

        public string Jornada
        {
            get
            {
                return _jornada;
            }

            set
            {
                _jornada = value;
            }
        }

        public string Cod_Periodo
        {
            get
            {
                return _cod_Periodo;
            }

            set
            {
                _cod_Periodo = value;
            }
        }

        public string Cod_Colegio
        {
            get
            {
                return _cod_Colegio;
            }

            set
            {
                _cod_Colegio = value;
            }
        }
        #endregion

        #region Public Methods
        //obtener datos de un Curso o una lista de Curso
        //si nCurso es igual a cero, trae a todos los Curso
        public List<Curso> ObtenerPersonal(int nCurso)
        {
            List<Curso> lst = new List<Curso>();
            return lst;
        }
        #endregion
    }
}
