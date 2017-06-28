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
    public partial class frmCurso : Form
    {
        public frmCurso()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void Limpiar()
        {
            txtCod_Curso.Clear();
            txtJornada.Clear();
            txtNombreCurso.Clear();
            cmbColegio.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Guardar cmb--> hor.IdTipoHorario = Convert.ToInt32(cmbTipoHorario.SelectedValue);
            //Mostrar datos (GET)cmb --> cmbTipoHorario.SelectedValue = hor.IdTipoHorario;

            ngCurso car = new ngCurso();
            if (txtCod_Curso.Text.Trim().Length == 0 || txtJornada.Text.Trim().Length == 0 || txtNombreCurso.Text.Trim().Length == 0 || cmbColegio.SelectedIndex == -1)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (String.IsNullOrEmpty(car.buscaCurso(this.txtCod_Curso.Text).Cod_Curso))
                {
                    ngCurso ncargo = new ngCurso();
                    ngCurso tod = new ngCurso();
                    ncargo.Cod_Curso = txtCod_Curso.Text;
                    ncargo.Jornada = txtJornada.Text;
                    ncargo.NombreCurso = txtNombreCurso.Text;
                    ncargo.Cod_Colegio = Convert.ToString(cmbColegio.SelectedValue);
                    tod.ingresaCurso(ncargo);
                    MessageBox.Show("Curso Guardado Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Curso ya existe", "Mensaje Sistema");
                    return;
                }
            }


        }

        private void frmCurso_Load(object sender, EventArgs e)
        {
            //carga el cmb con los colegios
           DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server=127.0.0.1;Database=IMC;Trusted_Connection=True;"))
            {
                string query = "select Cod_Colegio, Nombre from Colegio";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            cmbColegio.DisplayMember = "Nombre";
            cmbColegio.ValueMember = "Cod_Colegio";
            cmbColegio.DataSource = dt;


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ngCurso ncargo = new ngCurso();

            if (String.IsNullOrEmpty(ncargo.buscaCurso(this.txtCod_Curso.Text).Cod_Curso))
            {
                MessageBox.Show("No se puede eliminar Curso", "Mensaje Sistema");
            }

            else
            {

                ncargo.eliminarCurso(txtCod_Curso.Text);
                MessageBox.Show("Curso eliminado", "Mensaje Sistema");
                Limpiar();
                this.txtCod_Curso.Focus();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListarCurso pListar = new frmListarCurso();
            pListar.ShowDialog();
        }

        private void txtCod_Curso_Leave(object sender, EventArgs e)
        {
            ngCurso ncar = new ngCurso();
            Curso ncar2 = new Curso();
            ncar2 = ncar.buscaCurso(txtCod_Curso.Text);
            if (String.IsNullOrEmpty(ncar2.Cod_Curso))
            {
                return;
            }
            else
            {
                txtCod_Curso.Text = ncar2.Cod_Curso;
                txtJornada.Text = ncar2.Jornada;
                txtNombreCurso.Text = ncar2.NombreCurso;
                cmbColegio.SelectedValue = ncar2.Cod_Colegio;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ngCurso car = new ngCurso();
            if (txtCod_Curso.Text.Trim().Length == 0 || txtJornada.Text.Trim().Length == 0 || txtNombreCurso.Text.Trim().Length == 0 || cmbColegio.SelectedIndex == -1)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (!String.IsNullOrEmpty(car.buscaCurso(this.txtCod_Curso.Text).Cod_Curso))
                {
                    ngCurso ncargo = new ngCurso();
                    ngCurso tod = new ngCurso();
                    ncargo.Cod_Curso = txtCod_Curso.Text;
                    ncargo.Jornada = txtJornada.Text;
                    ncargo.NombreCurso = txtNombreCurso.Text;
                    ncargo.Cod_Colegio = Convert.ToString(cmbColegio.SelectedValue);
                    tod.actualizarCurso(ncargo);
                    MessageBox.Show("Curso Actualizado Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar Cargo", "Mensaje Sistema");
                    return;
                }
            }
        }

        private void txtCod_Curso_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite todo menos '
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtNombreCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite todo menos '
            if (e.KeyChar == (char)39)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtJornada_KeyPress(object sender, KeyPressEventArgs e)
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
