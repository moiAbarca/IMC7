using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Cargo
    {
        public Cargo() { }

        #region Propiedades
        private string _cod_Tipo_RRHH;
        private string _nombre_Tipo;

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

        public string Nombre_Tipo
        {
            get
            {
                return _nombre_Tipo;
            }

            set
            {
                _nombre_Tipo = value;
            }
        }
        #endregion

        public List<Cargo> ObtenerPersonal(int nCargo)
        {
            List<Cargo> lst = new List<Cargo>();
            return lst;
        }
    }
}
