using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using CapaNegocio;
using CapaDTO;

namespace CapaGUI
{
    public partial class frmListaCurso : Form
    {
        public frmListaCurso()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtIdListaCurso.Clear();
            cmbAlumno.SelectedIndex = -1;
            txtAno.Clear();
            txtSemestre.Clear();
            cmbCod_Curso.SelectedIndex = -1;
        }

        private void frmListaCurso_Load(object sender, EventArgs e)
        {
            //carga el cmb con los cursos
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server=127.0.0.1;Database=IMC;Trusted_Connection=True;"))
            {
                string query = "select Cod_Curso, NombreCurso from Curso";
                string query2 = "select Rut, Nombre+' '+Apellido  as nombres from Alumno";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlCommand cmd2 = new SqlCommand(query2, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);

                da.Fill(dt);
                da2.Fill(dt2);
            }

            cmbCod_Curso.DisplayMember = "NombreCurso";
            cmbCod_Curso.ValueMember = "Cod_Curso";
            cmbCod_Curso.DataSource = dt;

            cmbAlumno.DisplayMember = "nombres";
            cmbAlumno.ValueMember = "Rut";
            cmbAlumno.DataSource = dt2;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ngLista_Curso car = new ngLista_Curso();
            if (txtIdListaCurso.Text.Trim().Length == 0 || txtAno.Text.Trim().Length == 0 || txtSemestre.Text.Trim().Length == 0 || cmbAlumno.SelectedIndex == -1 || cmbCod_Curso.SelectedIndex == -1)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (String.IsNullOrEmpty(Convert.ToString(car.buscaLista_Curso(this.txtIdListaCurso.Text).IdListaCurso)))
                {
                    ngLista_Curso ncargo = new ngLista_Curso();
                    ngLista_Curso tod = new ngLista_Curso();
                    ncargo.IdListaCurso = txtIdListaCurso.Text;
                    ncargo.Ano = Convert.ToInt32(txtAno.Text);
                    ncargo.Semestre = txtSemestre.Text;
                    ncargo.Rut = Convert.ToString(cmbAlumno.SelectedValue);
                    ncargo.Cod_Curso = Convert.ToString(cmbCod_Curso.SelectedValue);
                    tod.ingresaLista_Curso(ncargo);
                    MessageBox.Show("Lista Curso Guardada Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Lista Curso ya existe", "Mensaje Sistema");
                    return;
                }
            }
        }

        private void txtIdListaCurso_Leave(object sender, EventArgs e)
        {
            ngLista_Curso ncar = new ngLista_Curso();
            Lista_Curso ncar2 = new Lista_Curso();
            ncar2 = ncar.buscaLista_Curso(txtIdListaCurso.Text);
            if (String.IsNullOrEmpty(Convert.ToString(ncar2.IdListaCurso)))
            {
                return;
            }
            else
            {
                txtIdListaCurso.Text = Convert.ToString(ncar2.IdListaCurso);
                txtAno.Text = Convert.ToString(ncar2.Ano);
                txtSemestre.Text = ncar2.Semestre;
                cmbAlumno.SelectedValue = ncar2.Rut;
                cmbCod_Curso.SelectedValue = ncar2.Cod_Curso;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ngLista_Curso ncargo = new ngLista_Curso();

            if (String.IsNullOrEmpty(Convert.ToString(ncargo.buscaLista_Curso(this.txtIdListaCurso.Text).IdListaCurso)))
            {
                MessageBox.Show("No se puede eliminar la Lista del Curso", "Mensaje Sistema");
            }

            else
            {

                ncargo.eliminarLista_Curso(txtIdListaCurso.Text);
                MessageBox.Show("Lista del Curso eliminada", "Mensaje Sistema");
                Limpiar();
                this.txtIdListaCurso.Focus();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ngLista_Curso car = new ngLista_Curso();
            if (txtIdListaCurso.Text.Trim().Length == 0 || txtAno.Text.Trim().Length == 0 || txtSemestre.Text.Trim().Length == 0 || cmbAlumno.SelectedIndex == -1 || cmbCod_Curso.SelectedIndex == -1)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (!String.IsNullOrEmpty(car.buscaLista_Curso(this.txtIdListaCurso.Text).IdListaCurso))
                {
                    ngLista_Curso ncargo = new ngLista_Curso();
                    ngLista_Curso tod = new ngLista_Curso();
                    ncargo.IdListaCurso = txtIdListaCurso.Text;
                    ncargo.Ano = Convert.ToInt32(txtAno.Text);
                    ncargo.Semestre = txtSemestre.Text;
                    ncargo.Cod_Curso = Convert.ToString(cmbCod_Curso.SelectedValue);
                    ncargo.Rut = Convert.ToString(cmbAlumno.SelectedValue);

                    tod.actualizarLista_Curso(ncargo);
                    MessageBox.Show("La Lista del Curso se ha Actualizado Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la Lista del Curso", "Mensaje Sistema");
                    return;
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmLstListaCurso frm = new frmLstListaCurso();
            frm.ShowDialog();
        }
    }
}
