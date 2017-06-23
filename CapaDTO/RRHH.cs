using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class RRHH
    {
        public RRHH() { }

        #region propiedades
        private string _rut_RRHH;
        private string _cod_Tipo_RRHH;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;

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

        public string Cod_Tipo_RRHH
        {
            get
            {
                return _cod_Tipo_RRHH;
            }

            set
            {
                _cod_Tipo_RRHH = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _apellido;
            }

            set
            {
                _apellido = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }

            set
            {
                _fechaNacimiento = value;
            }
        }
        #endregion

        public List<RRHH> ObtenerPersonal(int nRRHH)
        {
            List<RRHH> lst = new List<RRHH>();
            return lst;
        }
    }
}
