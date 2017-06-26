using CapaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class frmAlumno : Form
    {
        #region
        private int posicion;
        private int ultimo;

        public int Posicion
        {
            get
            {
                return posicion;
            }

            set
            {
                posicion = value;
            }
        }

        public int Ultimo
        {
            get
            {
                return ultimo;
            }

            set
            {
                ultimo = value;
            }
        }
        #endregion
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void HabilitarFormulario(bool habilitar)
        {
            txtRut.Enabled = !habilitar;
            txtNombre.Enabled = habilitar;
            txtApellido.Enabled = habilitar;
            dtFechaNacimiento.Enabled = habilitar;
            btnGuardar.Enabled = habilitar;
            btnListar.Enabled = habilitar;
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            HabilitarFormulario(true);
            txtRut.Enabled = true;
        }

        private void Limpiar()
        {
            txtRut.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            dtFechaNacimiento.Text = string.Empty;
        }

        private void txtRut_Leave(object sender, EventArgs e)
        {
            ngAlumno ncar = new ngAlumno();
            Alumno ncar2 = new Alumno();
            ncar2 = ncar.buscaAlumno(txtRut.Text);
            if (String.IsNullOrEmpty(ncar2.Rut))
            {
                return;
            }
            else
            {
                txtRut.Text = ncar2.Rut;
                txtNombre.Text = ncar2.Nombre;
                txtApellido.Text = ncar2.Apellido;
                dtFechaNacimiento.Value = ncar2.FechaNacimiento;
                
            }
        }

        private void TraerDatos()
        {
            if (String.IsNullOrEmpty(this.txtRut.Text))
            {
                MessageBox.Show("Rut en blanco", "Mensaje Sistema");
                this.txtRut.Focus();
                return;
            }


            srGuardaDatosAlumnos.wsGuardaDatosAlumnosSoapClient auxWsGuardaDatosAlumnos = new srGuardaDatosAlumnos.wsGuardaDatosAlumnosSoapClient();
            srGuardaDatosAlumnos.Alumno auxAlumno = new srGuardaDatosAlumnos.Alumno();
            auxAlumno = auxWsGuardaDatosAlumnos.buscarAlumno(this.txtRut.Text);

            if (String.IsNullOrEmpty(auxAlumno.Rut))
            {
                MessageBox.Show("Cliente No existe", "Mensaje Sistema");
                this.txtRut.Focus();
            }
            else
            {
                this.txtNombre.Text = auxAlumno.Nombre;
                this.txtApellido.Text = auxAlumno.Apellido;
                this.dtFechaNacimiento.Value = auxAlumno.FechaNacimiento;
            }
            HabilitarFormulario(true);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtRut.Enabled = true;
            txtRut.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            srGuardaDatosAlumnos.wsGuardaDatosAlumnosSoapClient auxSwGuardarDatosAlumnos = new srGuardaDatosAlumnos.wsGuardaDatosAlumnosSoapClient();
            srGuardaDatosAlumnos.Alumno auxAlumno = new srGuardaDatosAlumnos.Alumno();
            if (txtRut.Text.Trim().Length == 0 || txtNombre.Text.Trim().Length == 0 || txtApellido.Text.Trim().Length == 0 || dtFechaNacimiento.Value == DateTime.Now)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (String.IsNullOrEmpty(auxSwGuardarDatosAlumnos.buscarAlumno(this.txtRut.Text).Rut))
                {

                    auxAlumno.Rut = this.txtRut.Text;
                    auxAlumno.Nombre = this.txtNombre.Text;
                    auxAlumno.Apellido = this.txtApellido.Text;
                    auxAlumno.FechaNacimiento = this.dtFechaNacimiento.Value.Date;

                    auxSwGuardarDatosAlumnos.agregaAlumno(auxAlumno);
                    MessageBox.Show("Alumno Guardado", "Mensaje Sistema");
                }

                else
                {
                    MessageBox.Show("Alumno ya existe", "Mensaje Sistema");
                    this.txtRut.Focus();
                }
            }            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            srGuardaDatosAlumnos.wsGuardaDatosAlumnosSoapClient auxSwGuardarDatosAlumnos = new srGuardaDatosAlumnos.wsGuardaDatosAlumnosSoapClient();
            srGuardaDatosAlumnos.Alumno auxAlumno = new srGuardaDatosAlumnos.Alumno();

            if (String.IsNullOrEmpty(auxSwGuardarDatosAlumnos.buscarAlumno(this.txtRut.Text).Rut))
            {
                MessageBox.Show("Rut no existe", "Mensaje Sistema");
            }

            else
            {
                
                auxSwGuardarDatosAlumnos.eliminarAlumno(txtRut.Text);
                MessageBox.Show("Alumno eliminado", "Mensaje Sistema");
                Limpiar();
                this.txtRut.Focus();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            PantallaListarAlumno pListar = new PantallaListarAlumno();
            pListar.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            srGuardaDatosAlumnos.wsGuardaDatosAlumnosSoapClient auxSwGuardarDatosAlumnos = new srGuardaDatosAlumnos.wsGuardaDatosAlumnosSoapClient();
            srGuardaDatosAlumnos.Alumno auxAlumno = new srGuardaDatosAlumnos.Alumno();

            if (!String.IsNullOrEmpty(auxSwGuardarDatosAlumnos.buscarAlumno(this.txtRut.Text).Rut))
            {

                auxAlumno.Rut = this.txtRut.Text;
                auxAlumno.Nombre = this.txtNombre.Text;
                auxAlumno.Apellido = this.txtApellido.Text;
                auxAlumno.FechaNacimiento = this.dtFechaNacimiento.Value.Date;

                auxSwGuardarDatosAlumnos.actualizaAlumno(auxAlumno);
                MessageBox.Show("Alumno Actualizado", "Mensaje Sistema");
            }

            else
            {
                MessageBox.Show("No se pudo actualizar al Alumno", "Mensaje Sistema");
                this.txtRut.Focus();
            }
        }
    }
}
