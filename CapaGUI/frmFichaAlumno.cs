using CapaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class frmFichaAlumno : Form
    {
        public frmFichaAlumno()
        {
            InitializeComponent();
        }

        private void gboxCabecera_Enter(object sender, EventArgs e)
        {

        }

        private void txtEstatura_TextChanged(object sender, EventArgs e)
        {
            if (txtEstatura.Text.Trim().Length > 0 && txtPeso.Text.Trim().Length > 0)
            {
                double peso = 0, talla = 0;
                peso = Convert.ToDouble(txtPeso.Text);
                talla = Convert.ToDouble(txtEstatura.Text);
                generaIMC(peso, talla);
            }
            else
                return;
        }

        public void generaIMC(double peso, double talla)
        {
            srCalculaIMC.wsCalculaIMCSoapClient auxSwCalculaIMC = new srCalculaIMC.wsCalculaIMCSoapClient();
            double pesoLocal = Convert.ToDouble(txtPeso.Text);
            double alturaLocal = Convert.ToDouble(txtEstatura.Text);
            double IMC;

            if (txtEstatura.Text.Trim().Length == 0 && txtPeso.Text.Trim().Length == 0)
            {
                MessageBox.Show("Los campos altura y peso no pueden estar vacíos");
            }
            else
            {
                IMC = auxSwCalculaIMC.calculaIMC(pesoLocal, alturaLocal);

                txtValorIMC.Text = Convert.ToString(IMC);
            }
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            if (txtEstatura.Text.Trim().Length > 0 && txtPeso.Text.Trim().Length > 0)
            {
                float peso, talla;
                peso = Convert.ToSingle(txtPeso.Text);
                talla = Convert.ToSingle(txtEstatura.Text);
                generaIMC(peso, talla);
            }
            else
                return;
        }

        private void txtCod_Ficha_TextChanged(object sender, EventArgs e)
        {
            txtCodCabeceraFicha.Text = txtCod_Ficha.Text;
        }

        private void Clasificacion(double IMC)
        {
            if (IMC < 16)
            {
                txtClasifIMC.Text = "Infrapeso: Delgadez Severa";
            }
            else if (IMC >= 16 && IMC <=16.99)
            {
                txtClasifIMC.Text = "Infrapeso: Delgadez moderada";
            }
            else if (IMC >= 17.00 && IMC <= 18.49)
            {
                txtClasifIMC.Text = "Infrapeso: Delgadez aceptable";
            }
            else if (IMC >= 18.50 && IMC <= 24.99)
            {
                txtClasifIMC.Text = "Peso Normal";
            }
            else if (IMC >= 25.00 && IMC <= 29.99)
            {
                txtClasifIMC.Text = "Sobrepeso";
            }
            else if (IMC >= 30.00 && IMC <= 34.99)
            {
                txtClasifIMC.Text = "Obeso: Tipo I";
            }
            else if (IMC >= 35.00 && IMC <= 40.00)
            {
                txtClasifIMC.Text = "Obeso: Tipo II";
            }
            else if (IMC > 40.00)
            {
                txtClasifIMC.Text = "Obeso: Tipo III";
            }
        }

        private void txtValorIMC_TextChanged(object sender, EventArgs e)
        {
            if (txtValorIMC.Text == String.Empty)
            {
                return;
            }
            else
            {
                Clasificacion(Convert.ToDouble(txtValorIMC.Text));
            }
            
        }

        private void txtGuardarDetalle_Click(object sender, EventArgs e)
        {
            ngDetalle_Ficha_Alumno car = new ngDetalle_Ficha_Alumno();
            if (txtCodDetalleFicha.Text.Trim().Length == 0 || txtCodCabeceraFicha.Text.Trim().Length == 0 || txtValorIMC.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Algunos campos no pueden estar vacíos", "Diálogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (String.IsNullOrEmpty(car.buscaDetalle_Ficha_Alumno(this.txtCodDetalleFicha.Text).Cod_Detalle_Ficha))
                {
                    Cursor.Current = Cursors.WaitCursor;
                    ngDetalle_Ficha_Alumno det = new ngDetalle_Ficha_Alumno();
                    ngDetalle_Ficha_Alumno de2 = new ngDetalle_Ficha_Alumno();

                    det.Cod_Detalle_Ficha = txtCodDetalleFicha.Text;
                    det.Cod_Ficha = txtCodCabeceraFicha.Text;

                    double value = Convert.ToDouble(txtValorIMC.Text);

                    //darle formato al double de valor IMC
                    det.Valor_IMC = Convert.ToDouble((String.Format(CultureInfo.InvariantCulture,
                                                    "{0:0.00}", txtValorIMC.Text)));


                    det.Clasificacion_IMC = txtClasifIMC.Text;
                    det.Fecha_Revision = dtIFechaRevision.Value.Date;
                    det.Fecha_Proxima_Revision = dtFechaProxRevision.Value.Date;

                    de2.ingresaDetalle_Ficha_Alumno(det);
                    MessageBox.Show("Detalle Ficha Alumnos Guardada Correctamente");
                    LimpiarDetalle();
                }
                else
                {
                    MessageBox.Show("Detalle Ficha Alumnos ya existe", "Mensaje Sistema");
                    return;
                }
            }

            
            
            
        }

        private void frmFichaAlumno_Load(object sender, EventArgs e)
        {
            //carga los cmb
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server=127.0.0.1;Database=IMC;Trusted_Connection=True;"))
            {
                string query1 = "select IdListaCurso, Año from Lista_Curso";
                string query2 = "select Rut_RRHH, Nombre+' '+Apellido  as nombres from RRHH";
                string query3 = "select Rut, Nombre+' '+Apellido as nombres from Alumno";

                SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                SqlCommand cmd3 = new SqlCommand(query3, conn);

                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);

                da1.Fill(dt1);
                da2.Fill(dt2);
                da3.Fill(dt3);
            }

            cmbIdListaCurso.DisplayMember = "Año";
            cmbIdListaCurso.ValueMember = "IdListaCurso";
            cmbIdListaCurso.DataSource = dt1;

            cmbRutRRHH.DisplayMember = "nombres";
            cmbRutRRHH.ValueMember = "Rut_RRHH";
            cmbRutRRHH.DataSource = dt2;

            cmbRutAlumno.DisplayMember = "nombres";
            cmbRutAlumno.ValueMember = "Rut";
            cmbRutAlumno.DataSource = dt3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarCabecera();
        }

        private void LimpiarCabecera()
        {
            txtCod_Ficha.Clear();
            cmbIdListaCurso.SelectedIndex = -1;
            cmbRutAlumno.SelectedIndex = -1;
            cmbRutRRHH.SelectedIndex = -1;
            txtEstatura.Clear();
            txtPeso.Clear();
            dtFechaActualizacion.Value = DateTime.Now;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ngCabecera_Ficha_Alumnos car = new ngCabecera_Ficha_Alumnos();
            if (txtCod_Ficha.Text.Trim().Length == 0 || txtEstatura.Text.Trim().Length == 0 || txtPeso.Text.Trim().Length == 0 || cmbIdListaCurso.SelectedIndex == -1 || cmbRutAlumno.SelectedIndex == -1 || cmbRutRRHH.SelectedIndex == -1)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (String.IsNullOrEmpty(car.buscaCabecera_Ficha_Alumnos(this.txtCod_Ficha.Text).Cod_Ficha))
                {
                    ngCabecera_Ficha_Alumnos ncargo = new ngCabecera_Ficha_Alumnos();
                    ngCabecera_Ficha_Alumnos tod = new ngCabecera_Ficha_Alumnos();
                    ncargo.Cod_Ficha = txtCod_Ficha.Text;
                    ncargo.Estatura = Convert.ToDouble(txtEstatura.Text);
                    ncargo.Peso = Convert.ToDouble(txtPeso.Text);
                    
                    ncargo.IdListaCurso = Convert.ToString(cmbIdListaCurso.SelectedValue);
                    ncargo.Rut = Convert.ToString(cmbRutAlumno.SelectedValue);
                    ncargo.Rut_RRHH = Convert.ToString(cmbRutRRHH.SelectedValue);
                    ncargo.Fecha_Actualizacion = dtFechaActualizacion.Value.Date;

                    tod.ingresaCabecera_Ficha_Alumnos(ncargo);
                    MessageBox.Show("Cabecera Ficha Alumnos Guardada Correctamente");
                    LimpiarCabecera();
                }
                else
                {
                    MessageBox.Show("Cabecera Ficha Alumnos ya existe", "Mensaje Sistema");
                    return;
                }
            }


        }

        private void txtCod_Ficha_Leave(object sender, EventArgs e)
        {
            ngCabecera_Ficha_Alumnos ncar = new ngCabecera_Ficha_Alumnos();
            Cabecera_Ficha_Alumnos ncar2 = new Cabecera_Ficha_Alumnos();
            ncar2 = ncar.buscaCabecera_Ficha_Alumnos(txtCod_Ficha.Text);
            if (String.IsNullOrEmpty(ncar2.Cod_Ficha))
            {
                return;
            }
            else
            {
                txtCod_Ficha.Text = ncar2.Cod_Ficha;
                txtPeso.Text = Convert.ToString(ncar2.Peso);
                txtEstatura.Text = Convert.ToString(ncar2.Estatura);
                
                cmbIdListaCurso.SelectedValue = ncar2.IdListaCurso;
                cmbRutAlumno.SelectedValue = ncar2.Rut;
                cmbRutRRHH.SelectedValue = ncar2.Rut_RRHH;

                dtFechaActualizacion.Value = ncar2.Fecha_Actualizacion;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ngCabecera_Ficha_Alumnos ncargo = new ngCabecera_Ficha_Alumnos();

            if (String.IsNullOrEmpty(ncargo.buscaCabecera_Ficha_Alumnos(this.txtCod_Ficha.Text).Cod_Ficha))
            {
                MessageBox.Show("No se puede eliminar Cabecera Ficha Alumnos", "Mensaje Sistema");
            }

            else
            {

                ncargo.eliminarCabecera_Ficha_Alumnos(txtCod_Ficha.Text);
                MessageBox.Show("Cabecera Ficha Alumnos eliminada", "Mensaje Sistema");
                LimpiarCabecera();
                this.txtCod_Ficha.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ngCabecera_Ficha_Alumnos car = new ngCabecera_Ficha_Alumnos();
            if (txtCod_Ficha.Text.Trim().Length == 0 || txtPeso.Text.Trim().Length == 0 || txtEstatura.Text.Trim().Length == 0 || cmbIdListaCurso.SelectedIndex == -1 || cmbRutAlumno.SelectedIndex == -1 || cmbRutRRHH.SelectedIndex == -1)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (!String.IsNullOrEmpty(car.buscaCabecera_Ficha_Alumnos(this.txtCod_Ficha.Text).Cod_Ficha))
                {
                    ngCabecera_Ficha_Alumnos ncargo = new ngCabecera_Ficha_Alumnos();
                    ngCabecera_Ficha_Alumnos tod = new ngCabecera_Ficha_Alumnos();

                    ncargo.Cod_Ficha = txtCod_Ficha.Text;
                    ncargo.Estatura = Convert.ToDouble(txtEstatura.Text);
                    ncargo.Peso = Convert.ToDouble(txtPeso.Text);

                    ncargo.IdListaCurso = Convert.ToString(cmbIdListaCurso.SelectedValue);
                    ncargo.Rut = Convert.ToString(cmbRutAlumno.SelectedValue);
                    ncargo.Rut_RRHH = Convert.ToString(cmbRutRRHH.SelectedValue);
                    ncargo.Fecha_Actualizacion = dtFechaActualizacion.Value.Date;

                    tod.actualizarCabecera_Ficha_Alumnos(ncargo);
                    MessageBox.Show("Cabecera_Ficha_Alumnos Actualizado Correctamente");
                    LimpiarCabecera();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar Cabecera_Ficha_Alumnos", "Mensaje Sistema");
                    return;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmLstCabeceraFichaAlumnos form = new frmLstCabeceraFichaAlumnos();
            form.ShowDialog();
        }

        private void txtCodDetalleFicha_Leave(object sender, EventArgs e)
        {
            ngDetalle_Ficha_Alumno ncar = new ngDetalle_Ficha_Alumno();
            Detalle_Ficha_Alumno ncar2 = new Detalle_Ficha_Alumno();
            ncar2 = ncar.buscaDetalle_Ficha_Alumno(txtCodDetalleFicha.Text);
            if (String.IsNullOrEmpty(ncar2.Cod_Detalle_Ficha))
            {
                return;
            }
            else
            {
                txtCodCabeceraFicha.Text = ncar2.Cod_Ficha;
                txtCodDetalleFicha.Text = ncar2.Cod_Detalle_Ficha;
                txtValorIMC.Text = Convert.ToString(ncar2.Valor_IMC);
                txtClasifIMC.Text = ncar2.Clasificacion_IMC;

                dtIFechaRevision.Value = ncar2.Fecha_Revision;
                dtFechaProxRevision.Value = ncar2.Fecha_Proxima_Revision;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDetalle();
        }

        private void LimpiarDetalle()
        {
            txtCodCabeceraFicha.Clear();
            txtCodDetalleFicha.Clear();
            txtClasifIMC.Clear();
            txtValorIMC.Clear();
            
            dtFechaProxRevision.Value = DateTime.Now;
            dtIFechaRevision.Value = DateTime.Now;            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ngDetalle_Ficha_Alumno ncargo = new ngDetalle_Ficha_Alumno();

            if (String.IsNullOrEmpty(ncargo.buscaDetalle_Ficha_Alumno(this.txtCodDetalleFicha.Text).Cod_Detalle_Ficha))
            {
                MessageBox.Show("No se puede eliminar Detalle Ficha Alumnos", "Mensaje Sistema");
            }

            else
            {

                ncargo.eliminarDetalle_Ficha_Alumno(txtCodDetalleFicha.Text);
                MessageBox.Show("Detalle Ficha Alumnos eliminada", "Mensaje Sistema");
                LimpiarDetalle();
                this.txtCodDetalleFicha.Focus();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ngDetalle_Ficha_Alumno car = new ngDetalle_Ficha_Alumno();
            if (txtCodDetalleFicha.Text.Trim().Length == 0 || txtCodCabeceraFicha.Text.Trim().Length == 0 || txtValorIMC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (!String.IsNullOrEmpty(car.buscaDetalle_Ficha_Alumno(this.txtCodDetalleFicha.Text).Cod_Detalle_Ficha))
                {
                    Cursor.Current = Cursors.WaitCursor;
                    ngDetalle_Ficha_Alumno det = new ngDetalle_Ficha_Alumno();
                    ngDetalle_Ficha_Alumno de2 = new ngDetalle_Ficha_Alumno();

                    det.Cod_Detalle_Ficha = txtCodDetalleFicha.Text;
                    det.Cod_Ficha = txtCodCabeceraFicha.Text;

                    double value = Convert.ToDouble(txtValorIMC.Text);

                    //darle formato al double de valor IMC
                    det.Valor_IMC = Convert.ToDouble((String.Format(CultureInfo.InvariantCulture,
                                                    "{0:0.00}", txtValorIMC.Text)));


                    det.Clasificacion_IMC = txtClasifIMC.Text;
                    det.Fecha_Revision = dtIFechaRevision.Value.Date;
                    det.Fecha_Proxima_Revision = dtFechaProxRevision.Value.Date;

                    de2.actualizarDetalle_Ficha_Alumno(det);
                    MessageBox.Show("Detalle_Ficha_Alumnos Actualizado Correctamente");
                    LimpiarCabecera();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar Detalle_Ficha_Alumnos", "Mensaje Sistema");
                    return;
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmLstDetalleFichaAlumno form = new frmLstDetalleFichaAlumno();
            form.ShowDialog();
        }
    }
}
