using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Alumno
    {
        //Constructor
        public Alumno() { }

        #region Properties
        private string _rut;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;

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

        #region Métodos públicos
        //obtener datos de un alumno o una lista de alumnos
        //si nAlumno es igual a cero, trae a todos los alumnos
        public List<Alumno> ObtenerPersonal(int nAlumno)
        {
            List<Alumno> lst = new List<Alumno>();


            return lst;
        }

        #endregion

    }
}
