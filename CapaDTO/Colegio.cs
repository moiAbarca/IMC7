using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Colegio
    {
        //Constructor
        public Colegio() { }

        #region Properties
        private string _cod_Colegio;
        private string _nombre;
        private string _direccion;
        private string _telefono;

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

        public string Direccion
        {
            get
            {
                return _direccion;
            }

            set
            {
                _direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }

            set
            {
                _telefono = value;
            }
        }

        #endregion

        #region Métodos públicos
        //obtener datos de un Colegio o una lista de Colegio
        //si nColegio es igual a cero, trae a todos los Colegio
        public List<Colegio> ObtenerPersonal(int nColegio)
        {
            List<Colegio> lst = new List<Colegio>();
            return lst;
        }
        #endregion

    }
}
