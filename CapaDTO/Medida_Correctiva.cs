using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Medida_Correctiva
    {
        //constructor
        public Medida_Correctiva() { }

        #region Properties
        private string _cod_MC;
        private string _cod_Detalle_Ficha;
        private string _cod_TMC;
        private string _descripcion;
        private string _fecha_Inicio;
        private string _fecha_Termino;

        public string Cod_MC
        {
            get
            {
                return _cod_MC;
            }

            set
            {
                _cod_MC = value;
            }
        }

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

        public string Fecha_Inicio
        {
            get
            {
                return _fecha_Inicio;
            }

            set
            {
                _fecha_Inicio = value;
            }
        }

        public string Fecha_Termino
        {
            get
            {
                return _fecha_Termino;
            }

            set
            {
                _fecha_Termino = value;
            }
        }
        #endregion

        #region public Methods
        //trae una Medida_Correctiva o una lista de Medida_Correctiva
        //si nMedida_Correctiva es 0 trae a todos
        public List<Medida_Correctiva> ObtenerPersonal(int nMedida_Correctiva)
        {
            List<Medida_Correctiva> lst = new List<Medida_Correctiva>();
            return lst;
        }
        #endregion
    }
}
