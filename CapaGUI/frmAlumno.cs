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

        private bool Limpiar()
        {
            bool cad = true;
            txtRut.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            dtFechaNacimiento.Text = string.Empty;
            return cad;
        }

        private void txtRut_Leave(object sender, EventArgs e)
        {
            ngAlumno ncar = new ngAlumno();
            Alumno ncar2 = new Alumno();
            ncar2 = ncar.buscaAlumno(txtRut.Text);

            bool rut1 = validarRut(txtRut.Text);
            bool rut2 = validaRut2(txtRut.Text);
            bool rut3 = validaRut3(txtRut.Text);

            try
            {
                if (rut1 == true && rut2 == true && rut3 == true)
                {
                    btnLimpiar.Enabled = true;
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
                else
                {
                    btnLimpiar.Enabled = false;
                    //bool cal = Limpiar();
                    if (txtRut.Text.Length == 0 /*|| cal == true*/)
                    {
                        //txtNombre.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un rut correcto");
                        txtRut.Focus();
                    }
                    
                }
            }
            catch (Exception)
            {

                
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
            else
            {
                srGuardaDatosAlumnos.wsGuardaDatosAlumnosSoapClient auxWsGuardaDatosAlumnos = new srGuardaDatosAlumnos.wsGuardaDatosAlumnosSoapClient();
                srGuardaDatosAlumnos.Alumno auxAlumno = new srGuardaDatosAlumnos.Alumno();
                auxAlumno = auxWsGuardaDatosAlumnos.buscarAlumno(this.txtRut.Text);

                if (String.IsNullOrEmpty(auxAlumno.Rut))
                {
                    MessageBox.Show("Alumno No existe", "Mensaje Sistema");
                    this.txtRut.Focus();
                }
                else
                {
                    this.txtNombre.Text = auxAlumno.Nombre;
                    this.txtApellido.Text = auxAlumno.Apellido;
                    this.dtFechaNacimiento.Value = auxAlumno.FechaNacimiento;
                }
                //HabilitarFormulario(true);
            }


            
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
            if (txtRut.Text.Trim().Length == 0 || txtNombre.Text.Trim().Length == 0 || txtApellido.Text.Trim().Length == 0 /*|| dtFechaNacimiento.Value.Date < DateTime.Now*/)
            {
                MessageBox.Show("Tiene algún campo vacío o la fecha no ha sido modificada");
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
                    MessageBox.Show("Alumno guardado", "Mensaje Sistema");
                    Limpiar();
                    this.txtRut.Focus();
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
                Limpiar();
                this.txtRut.Focus();
            }

            else
            {
                MessageBox.Show("No se pudo actualizar al Alumno", "Mensaje Sistema");
                this.txtRut.Focus();
            }
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite todo menos '
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
                return;
            }
        }

        public bool validarRut(string rut)
        {

            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
                
                
            }

            return validacion;
        }

        public bool validaRut2(string Rut)
        {
            bool validacion = false;
            try
            {
                if (Rut.Length >= 9 )
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {

                
            }
            return validacion;
        }

        public bool validaRut3(string Rut)
        {
            bool validacion = false;
            try
            {
                string sTexto1 = txtRut.Text.Substring(0, 1);
                string sTexto2 = txtRut.Text.Substring(1, 1);
                
                if (sTexto1 != sTexto2)
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {

                
            }
            
            
            return validacion;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permite solamente letras
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permite solamente letras
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
