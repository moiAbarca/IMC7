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

            bool rut1 = validarRut(txtRutRRHH.Text);
            bool rut2 = validaRut2(txtRutRRHH.Text);
            bool rut3 = validaRut3(txtRutRRHH.Text);

            try
            {
                if (rut1 == true && rut2 == true && rut3 == true)
                {
                    btnLimpiar.Enabled = true;
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
                else
                {
                    btnLimpiar.Enabled = false;
                    //bool cal = Limpiar();
                    if (txtRutRRHH.Text.Length == 0 /*|| cal == true*/)
                    {
                        //txtNombre.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un rut correcto");
                        txtRutRRHH.Focus();
                        
                    }

                }
            }
            catch (Exception)
            {


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
                if (Rut.Length >= 9)
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
                string sTexto1 = txtRutRRHH.Text.Substring(0, 1);
                string sTexto2 = txtRutRRHH.Text.Substring(1, 1);

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

        private void txtRutRRHH_KeyPress(object sender, KeyPressEventArgs e)
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
