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
    public partial class frmTipoMedidaCorrectiva : Form
    {
        public frmTipoMedidaCorrectiva()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtCod_TMC.Clear();
            txtDescripcion.Clear();
            txtTipoMedida.Clear();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ngTipo_Medida_Correctiva car = new ngTipo_Medida_Correctiva();
            if (txtCod_TMC.Text.Trim().Length == 0 || txtDescripcion.Text.Trim().Length == 0 || txtTipoMedida.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (String.IsNullOrEmpty(car.buscaTipo_Medida_Correctiva(this.txtCod_TMC.Text).Cod_TMC))
                {
                    ngTipo_Medida_Correctiva ncargo = new ngTipo_Medida_Correctiva();
                    ngTipo_Medida_Correctiva tod = new ngTipo_Medida_Correctiva();
                    ncargo.Cod_TMC = txtCod_TMC.Text;
                    ncargo.Descripcion = txtDescripcion.Text;
                    ncargo.Tipo_Medida = txtTipoMedida.Text;
                    tod.ingresaTipo_Medida_Correctiva(ncargo);
                    MessageBox.Show("Tipo_Medida_Correctiva Guardada Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Tipo_Medida_Correctiva ya existe", "Mensaje Sistema");
                    return;
                }
            }
        }

        private void txtCod_TMC_Leave(object sender, EventArgs e)
        {
            ngTipo_Medida_Correctiva ncar = new ngTipo_Medida_Correctiva();
            Tipo_Medida_Correctiva ncar2 = new Tipo_Medida_Correctiva();
            ncar2 = ncar.buscaTipo_Medida_Correctiva(txtCod_TMC.Text);
            if (String.IsNullOrEmpty(ncar2.Cod_TMC))
            {
                return;
            }
            else
            {
                txtCod_TMC.Text = ncar2.Cod_TMC;
                txtDescripcion.Text = ncar2.Descripcion;
                txtTipoMedida.Text = ncar2.Tipo_Medida;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ngTipo_Medida_Correctiva ncargo = new ngTipo_Medida_Correctiva();

            if (String.IsNullOrEmpty(ncargo.buscaTipo_Medida_Correctiva(this.txtCod_TMC.Text).Cod_TMC))
            {
                MessageBox.Show("No se puede eliminar Tipo_Medida_Correctiva", "Mensaje Sistema");
            }

            else
            {

                ncargo.eliminarTipo_Medida_Correctiva(txtCod_TMC.Text);
                MessageBox.Show("Tipo_Medida_Correctiva eliminado", "Mensaje Sistema");
                Limpiar();
                this.txtCod_TMC.Focus();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ngTipo_Medida_Correctiva car = new ngTipo_Medida_Correctiva();
            if (txtCod_TMC.Text.Trim().Length == 0 || txtDescripcion.Text.Trim().Length == 0 || txtTipoMedida.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (!String.IsNullOrEmpty(car.buscaTipo_Medida_Correctiva(this.txtCod_TMC.Text).Cod_TMC))
                {
                    ngTipo_Medida_Correctiva ncargo = new ngTipo_Medida_Correctiva();
                    ngTipo_Medida_Correctiva tod = new ngTipo_Medida_Correctiva();
                    ncargo.Cod_TMC = txtCod_TMC.Text;
                    ncargo.Descripcion = txtDescripcion.Text;
                    ncargo.Tipo_Medida = txtTipoMedida.Text;

                    tod.actualizarTipo_Medida_Correctiva(ncargo);
                    MessageBox.Show("Tipo_Medida_Correctiva Actualizada Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar Tipo_Medida_Correctiva", "Mensaje Sistema");
                    return;
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmLstTipoMedidaCorrectiva from = new frmLstTipoMedidaCorrectiva();
            from.ShowDialog();
        }
    }
}
