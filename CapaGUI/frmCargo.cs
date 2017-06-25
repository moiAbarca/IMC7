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
    public partial class frmCargo : Form
    {
        public frmCargo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ngCargo car = new ngCargo();
            if (txtCod_Tipo_RRHH.Text.Trim().Length ==0 && txtNombre_TipoCargo.Text.Trim().Length ==0)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (String.IsNullOrEmpty(car.buscaCargo(this.txtCod_Tipo_RRHH.Text).Cod_Tipo_RRHH))
                {
                    ngCargo ncargo = new ngCargo();
                    ngCargo tod = new ngCargo();
                    ncargo.Nombre_Tipo = txtNombre_TipoCargo.Text;
                    ncargo.Cod_Tipo_RRHH = txtCod_Tipo_RRHH.Text;
                    tod.ingresaCargo(ncargo);
                    MessageBox.Show("Cargo Guardado Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Cargo ya existe", "Mensaje Sistema");
                    this.txtNombre_TipoCargo.Focus();
                }                
            }
        }

        private void Limpiar()
        {
            txtCod_Tipo_RRHH.Text = string.Empty;
            txtNombre_TipoCargo.Text = string.Empty;
        }

        private void txtCod_Tipo_RRHH_Leave(object sender, EventArgs e)
        {
            ngCargo ncar = new ngCargo();
            Cargo ncar2 = new Cargo();
            ncar2 = ncar.buscaCargo(txtCod_Tipo_RRHH.Text);

            txtCod_Tipo_RRHH.Text = ncar2.Cod_Tipo_RRHH;
            txtNombre_TipoCargo.Text = ncar2.Nombre_Tipo;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ngCargo ncargo = new ngCargo();

            if (String.IsNullOrEmpty(ncargo.buscaCargo(this.txtCod_Tipo_RRHH.Text).Cod_Tipo_RRHH))
            {
                MessageBox.Show("Ingrese un Cargo", "Mensaje Sistema");
            }

            else
            {

                ncargo.eliminarCargo(txtCod_Tipo_RRHH.Text);
                MessageBox.Show("Cargo eliminado", "Mensaje Sistema");
                Limpiar();
                this.txtCod_Tipo_RRHH.Focus();
            }
        }
    }
}
