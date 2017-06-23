using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Detalle_Ficha_Alumno
    {
        public Detalle_Ficha_Alumno() { }

        #region propiedades
        private string _cod_Detalle_Ficha;
        private string _cod_Ficha;
        private double _valor_IMC;
        private string _clasificacion_IMC;
        private DateTime _fecha_Revision;
        private DateTime _fecha_Proxima_Revision;

        public string Cod_Detalle_Ficha
        {
            get
            {
                return _cod_Detalle_Ficha;
            }

            set
            {
                _cod_Detalle_Ficha = value;
            }
        }

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

        public double Valor_IMC
        {
            get
            {
                return _valor_IMC;
            }

            set
            {
                _valor_IMC = value;
            }
        }

        public string Clasificacion_IMC
        {
            get
            {
                return _clasificacion_IMC;
            }

            set
            {
                _clasificacion_IMC = value;
            }
        }

        public DateTime Fecha_Revision
        {
            get
            {
                return _fecha_Revision;
            }

            set
            {
                _fecha_Revision = value;
            }
        }

        public DateTime Fecha_Proxima_Revision
        {
            get
            {
                return _fecha_Proxima_Revision;
            }

            set
            {
                _fecha_Proxima_Revision = value;
            }
        }


        #endregion

        #region public Methods
        //trae una detalle o una lista de detalles
        //si nDetalle_Ficha_Alumno es 0 trae a todos
        public List<Detalle_Ficha_Alumno> ObtenerPersonal(int nDetalle_Ficha_Alumno)
        {
            List<Detalle_Ficha_Alumno> lst = new List<Detalle_Ficha_Alumno>();
            return lst;
        }
        #endregion
    }
}
