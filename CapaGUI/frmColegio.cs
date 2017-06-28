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
    public partial class frmColegio : Form
    {
        public frmColegio()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ngColegio car = new ngColegio();
            if (txtCod_Colegio.Text.Trim().Length == 0 || txtDireccion.Text.Trim().Length == 0 || txtNombre.Text.Trim().Length == 0 || txtTelefono.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (String.IsNullOrEmpty(car.buscColegio(this.txtCod_Colegio.Text).Cod_Colegio))
                {
                    ngColegio ncargo = new ngColegio();
                    ngColegio tod = new ngColegio();
                    ncargo.Cod_Colegio = txtCod_Colegio.Text;
                    ncargo.Direccion = txtDireccion.Text;
                    ncargo.Nombre = txtNombre.Text;
                    ncargo.Telefono = txtTelefono.Text;

                    tod.ingresaCurso(ncargo);
                    MessageBox.Show("Colegio Guardado Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Colegio ya existe", "Mensaje Sistema");
                    return;
                }
            }
        }

        private void Limpiar()
        {
            txtCod_Colegio.Clear();
            txtDireccion.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ngColegio ncargo = new ngColegio();

            if (String.IsNullOrEmpty(ncargo.buscColegio(this.txtCod_Colegio.Text).Cod_Colegio))
            {
                MessageBox.Show("No se puede eliminar Colegio", "Mensaje Sistema");
            }

            else
            {

                ncargo.eliminarColegio(txtCod_Colegio.Text);
                MessageBox.Show("Colegio eliminado", "Mensaje Sistema");
                Limpiar();
                this.txtCod_Colegio.Focus();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListarColegio pListar = new frmListarColegio();
            pListar.ShowDialog();
        }

        private void txtCod_Colegio_Leave(object sender, EventArgs e)
        {
            ngColegio ncar = new ngColegio();
            Colegio ncar2 = new Colegio();
            ncar2 = ncar.buscColegio(txtCod_Colegio.Text);
            if (String.IsNullOrEmpty(ncar2.Cod_Colegio))
            {
                return;
            }
            else
            {
                txtCod_Colegio.Text = ncar2.Cod_Colegio;
                txtDireccion.Text = ncar2.Direccion;
                txtNombre.Text = ncar2.Nombre;
                txtTelefono.Text = ncar2.Telefono;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ngColegio car = new ngColegio();
            if (txtCod_Colegio.Text.Trim().Length == 0 || txtDireccion.Text.Trim().Length == 0 || txtNombre.Text.Trim().Length == 0 || txtTelefono.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (!String.IsNullOrEmpty(car.buscColegio(this.txtCod_Colegio.Text).Cod_Colegio))
                {
                    ngColegio ncargo = new ngColegio();
                    ngColegio tod = new ngColegio();
                    ncargo.Cod_Colegio = txtCod_Colegio.Text;
                    ncargo.Direccion = txtDireccion.Text;
                    ncargo.Nombre = txtNombre.Text;
                    ncargo.Telefono = txtTelefono.Text;

                    tod.actualizarColegio(ncargo);
                    MessageBox.Show("Colegio Actualizado Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar Colegio", "Mensaje Sistema");
                    return;
                }
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != (char)Keys.Return)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtCod_Colegio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite todo menos '
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
                return;
            }
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

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite todo menos '
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
