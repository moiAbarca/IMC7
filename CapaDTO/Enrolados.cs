﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectorMarcas.DBClass
{
    public class Enrolados
    {
        public Enrolados()
        {
        }

        #region Properties
        // var privadas 
        //
        private int _idEnroll;
        private int _rut;
        private string _dv;
        private string _nombre;
        private string _nacionalidad;
        private DateTime _fnacimiento;
        private string _telefonos;
        private DateTime _altalaboral;
        private string _direccion;
        private string _genero;
        private byte[] _foto;
        private int _idDepartamento;
        private int _idHorario;
        private int _idTardanza;
        private int _idFalta;

        public int IdFalta
        {
            get { return _idFalta; }
            set { _idFalta = value; }
        }
        public int IdTardanza
        {
            get { return _idTardanza; }
            set { _idTardanza = value; }
        }

        public int IdHorario
        {
            get { return _idHorario; }
            set { _idHorario = value; }
        }

        public int IdDepartamento
        {
            get { return _idDepartamento; }
            set { _idDepartamento = value; }
        }

        public int IdEnroll
        {
            get { return _idEnroll; }
            set { _idEnroll = value; }
        }

        public int Rut
        {
            get { return _rut; }
            set
            {
                // if (this.ValidaRut())
                    _rut = value;
                //else
                //    throw new Exception();
            }
        }

        public string Dv
        {
            get { return _dv; }
            set { _dv = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Nacionalidad
        {
            get { return _nacionalidad; }
            set { _nacionalidad = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return _fnacimiento; }
            set { _fnacimiento = value; }
        }

        public string Telefonos
        {
            get { return _telefonos; }
            set { _telefonos = value; }
        }

        public DateTime AltaLaboral
        {
            get { return _altalaboral; }
            set { _altalaboral = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        public byte[] Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Obtener datos de una persona enrolada o una lista de registros del personal enrollado
        /// </summary>
        /// <param name="nIdEnroll">Si especifica cero, se devuelve una lista completa de las personas enroladas, de lo contrario se debuelve la información del id especificado.</param>
        /// <returns>Retorna una colección del tipo List/<Persona/></returns>
        public List<Enrolados> ObtenerPersonal(int nIdEnroll)
        {
            List<Enrolados> lst = new List<Enrolados>();


            return lst;
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Validación del rut
        /// </summary>
        /// <returns>Retorna true cuando el rut es correcto, de lo contrario false.</returns>
        internal bool ValidaRut()
        {
            Int32 Rut = 0;
            bool lret = false;

            int Digito;
            int Contador;
            int Multiplo;
            int Acumulador;

            Contador = 2;
            Acumulador = 0;

            while (Rut != 0)
            {
                Multiplo = (Rut % 10) * Contador;
                Acumulador = Acumulador + Multiplo;
                Rut = Rut / 10;
                Contador++;
                if (Contador == 8) Contador = 2;
            }
            Digito = 11 - (Acumulador % 11);

            if (Digito == 10)
            {
                lret = "K" == _dv ? true : false;
            }
            else
                if (Digito == 11)
                {
                    lret = "0" == _dv ? true : false;
                }
                else
                {
                    lret = Digito.ToString() == _dv.ToString() ? true : false;
                }
            return lret;

        }
        #endregion


    }
}
