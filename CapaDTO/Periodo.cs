using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Periodo
    {
        public Periodo() { }

        #region Propiedades
        private string _cod_Periodo;
        private int _ano;
        private string _semestre;

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

        #region métodos públicos
        public List<Periodo> ObtenerPersonal(int nPeriodo)
        {
            List<Periodo> lst = new List<Periodo>();
            return lst;
        }
        #endregion

    }
}
