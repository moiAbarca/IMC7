using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Tipo_Medida_Correctiva
    {
        public Tipo_Medida_Correctiva() { }

        #region properties
        private string _cod_TMC;
        private string _tipo_Medida;
        private string _descripcion;

        public string Cod_TMC
        {
            get
            {
                return _cod_TMC;
            }

            set
            {
                _cod_TMC = value;
            }
        }

        public string Tipo_Medida
        {
            get
            {
                return _tipo_Medida;
            }

            set
            {
                _tipo_Medida = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }

            set
            {
                _descripcion = value;
            }
        }

        #endregion

        #region public Methods
        //trae una Tipo_Medida_Correctiva o una lista de Tipo_Medida_Correctiva
        //si nTipo_Medida_Correctiva es 0 trae a todos
        public List<Tipo_Medida_Correctiva> ObtenerPersonal(int nTipo_Medida_Correctiva)
        {
            List<Tipo_Medida_Correctiva> lst = new List<Tipo_Medida_Correctiva>();
            return lst;
        }
        #endregion

    }
}
