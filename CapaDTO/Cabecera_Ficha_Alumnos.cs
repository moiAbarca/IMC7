using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Cabecera_Ficha_Alumnos
    {
        public Cabecera_Ficha_Alumnos() { }

        #region propiedades
        private string _cod_Ficha;
        private string _rut;
        private string _rut_RRHH;
        private double _estatura;
        private double _peso;
        private DateTime _fecha_Actualizacion;
        private string _idListaCurso;

        public string Cod_Ficha
        {
            get
            {
                return _cod_Ficha;
            }

            set
            {
                _cod_Ficha = value;
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

        public string Rut_RRHH
        {
            get
            {
                return _rut_RRHH;
            }

            set
            {
                _rut_RRHH = value;
            }
        }

        public double Estatura
        {
            get
            {
                return _estatura;
            }

            set
            {
                _estatura = value;
            }
        }

        public double Peso
        {
            get
            {
                return _peso;
            }

            set
            {
                _peso = value;
            }
        }

        public DateTime Fecha_Actualizacion
        {
            get
            {
                return _fecha_Actualizacion;
            }

            set
            {
                _fecha_Actualizacion = value;
            }
        }

        public string IdListaCurso
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
        #endregion

        public List<Cabecera_Ficha_Alumnos> ObtenerPersonal(int nCabecera_Ficha_Alumnos)
        {
            List<Cabecera_Ficha_Alumnos> lst = new List<Cabecera_Ficha_Alumnos>();
            return lst;
        }
    }
}
