using CapaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class frmRRHH : Form
    {
        public frmRRHH()
        {
            InitializeComponent();
        }

        private void frmRRHH_Load(object sender, EventArgs e)
        {
            //carga el cmb con los Cargos
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server=127.0.0.1;Database=IMC;Trusted_Connection=True;"))
            {
                string query = "select Cod_Tipo_RRHH, Nombre_Tipo from Cargo";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            cmbCodTipoRRHH.DisplayMember = "Nombre_Tipo";
            cmbCodTipoRRHH.ValueMember = "Cod_Tipo_RRHH";
            cmbCodTipoRRHH.DataSource = dt;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtRutRRHH.Clear();
            cmbCodTipoRRHH.SelectedIndex = -1;
            dtFechaNacimiento.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ngRRHH car = new ngRRHH();
            if (txtRutRRHH.Text.Trim().Length == 0 || txtNombre.Text.Trim().Length == 0 || txtApellido.Text.Trim().Length == 0 || cmbCodTipoRRHH.SelectedIndex == -1) // dtFechaNacimiento.Value.Date < DateTime.Now)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (String.IsNullOrEmpty(car.buscaRRHH(this.txtRutRRHH.Text).Rut_RRHH))
                {
                    ngRRHH ncargo = new ngRRHH();
                    ngRRHH tod = new ngRRHH();
                    ncargo.Rut_RRHH = txtRutRRHH.Text;
                    ncargo.Nombre = txtNombre.Text;
                    ncargo.Apellido = txtApellido.Text;
                    ncargo.FechaNacimiento = dtFechaNacimiento.Value.Date;
                    ncargo.Cod_Tipo_RRHH = Convert.ToString(cmbCodTipoRRHH.SelectedValue);
                    tod.ingresaRRHH(ncargo);
                    MessageBox.Show("RRHH Guardado Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("RRHH ya existe", "Mensaje Sistema");
                    return;
                }
            }
        }

        private void txtRutRRHH_Leave(object sender, EventArgs e)
        {
            ngRRHH ncar = new ngRRHH();
            RRHH ncar2 = new RRHH();
            ncar2 = ncar.buscaRRHH(txtRutRRHH.Text);
            if (String.IsNullOrEmpty(ncar2.Rut_RRHH))
            {
                return;
            }
            else
            {
                txtRutRRHH.Text = ncar2.Rut_RRHH;
                txtNombre.Text = ncar2.Nombre;
                txtApellido.Text = ncar2.Apellido;
                dtFechaNacimiento.Value = ncar2.FechaNacimiento;
                cmbCodTipoRRHH.SelectedValue = ncar2.Cod_Tipo_RRHH;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ngRRHH ncargo = new ngRRHH();

            if (String.IsNullOrEmpty(ncargo.buscaRRHH(this.txtRutRRHH.Text).Rut_RRHH))
            {
                MessageBox.Show("No se puede eliminar RRHH", "Mensaje Sistema");
            }

            else
            {

                ncargo.eliminarRRHH(txtRutRRHH.Text);
                MessageBox.Show("RRHH eliminado", "Mensaje Sistema");
                Limpiar();
                this.txtRutRRHH.Focus();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ngRRHH car = new ngRRHH();
            if (txtRutRRHH.Text.Trim().Length == 0 || txtNombre.Text.Trim().Length == 0 || txtApellido.Text.Trim().Length == 0 || cmbCodTipoRRHH.SelectedIndex == -1)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (!String.IsNullOrEmpty(car.buscaRRHH(this.txtRutRRHH.Text).Rut_RRHH))
                {
                    ngRRHH ncargo = new ngRRHH();
                    ngRRHH tod = new ngRRHH();
                    ncargo.Rut_RRHH = txtRutRRHH.Text;
                    ncargo.Nombre = txtNombre.Text;
                    ncargo.Apellido = txtApellido.Text;
                    ncargo.Cod_Tipo_RRHH = Convert.ToString(cmbCodTipoRRHH.SelectedValue);
                    ncargo.FechaNacimiento = this.dtFechaNacimiento.Value.Date;
                    tod.actualizarRRHH(ncargo);
                    MessageBox.Show("RRHH Actualizado Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar RRHH", "Mensaje Sistema");
                    return;
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmLstRRHH form = new frmLstRRHH();
            form.ShowDialog();
        }
    }
}
