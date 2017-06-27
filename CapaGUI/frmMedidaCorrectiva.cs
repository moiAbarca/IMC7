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
    public partial class frmMedidaCorrectiva : Form
    {
        public frmMedidaCorrectiva()
        {
            InitializeComponent();
        }

        private void frmMedidaCorrectiva_Load(object sender, EventArgs e)
        {
            //carga los cmb
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            
            using (SqlConnection conn = new SqlConnection("Server=127.0.0.1;Database=IMC;Trusted_Connection=True;"))
            {
                string query1 = "select Cod_Detalle_Ficha, Clasificacion_IMC from Detalle_Ficha_Alumno";
                string query2 = "select Cod_TMC, Tipo_Medida from Tipo_Medida_Correctiva";
            
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                
                da1.Fill(dt1);
                da2.Fill(dt2);                
            }

            cmbCodFichaDetalle.DisplayMember = "Clasificacion_IMC";
            cmbCodFichaDetalle.ValueMember = "Cod_Detalle_Ficha";
            cmbCodFichaDetalle.DataSource = dt1;

            cmbCodTMC.DisplayMember = "Tipo_Medida";
            cmbCodTMC.ValueMember = "Cod_TMC";
            cmbCodTMC.DataSource = dt2;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            srGuardaDatosCorrectivos.wsGuardaDatosCorrectivosSoapClient auxSwGuardarDatosCorrectivos = new srGuardaDatosCorrectivos.wsGuardaDatosCorrectivosSoapClient();
            srGuardaDatosCorrectivos.Medida_Correctiva auxMedidaCorrectiva = new srGuardaDatosCorrectivos.Medida_Correctiva();
            if (txtCodMC.Text.Trim().Length == 0 || txtDescripcion.Text.Trim().Length == 0 || cmbCodFichaDetalle.SelectedIndex == -1 || cmbCodTMC.SelectedIndex == -1)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (String.IsNullOrEmpty(auxSwGuardarDatosCorrectivos.buscarMedida_Correctiva(this.txtCodMC.Text).Cod_MC))
                {
                    auxMedidaCorrectiva.Cod_MC = txtCodMC.Text;
                    auxMedidaCorrectiva.Descripcion = txtDescripcion.Text;

                    auxMedidaCorrectiva.Cod_TMC = Convert.ToString(cmbCodTMC.SelectedValue);
                    auxMedidaCorrectiva.Cod_Detalle_Ficha = Convert.ToString(cmbCodFichaDetalle.SelectedValue);

                    auxMedidaCorrectiva.Fecha_Termino = dtFechaTermino.Value.Date;
                    auxMedidaCorrectiva.Fecha_Inicio = dtFechaInicio.Value.Date;
                    
                    auxSwGuardarDatosCorrectivos.agregaDatosCorrectivos(auxMedidaCorrectiva);
                    MessageBox.Show("MedidaCorrectiva guardada", "Mensaje Sistema");
                    Limpiar();
                    this.txtCodMC.Focus();
                }

                else
                {
                    MessageBox.Show("MedidaCorrectiva ya existe", "Mensaje Sistema");
                    this.txtCodMC.Focus();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtCodMC.Clear();
            txtDescripcion.Clear();
            cmbCodTMC.SelectedIndex = -1;
            cmbCodFichaDetalle.SelectedIndex = -1;
            dtFechaInicio.Value = DateTime.Now;
            dtFechaTermino.Value = DateTime.Now;
        }

        private void txtCodMC_Leave(object sender, EventArgs e)
        {
            ngMedida_Correctiva ncar = new ngMedida_Correctiva();
            Medida_Correctiva ncar2 = new Medida_Correctiva();
            ncar2 = ncar.buscaMedida_Correctiva(txtCodMC.Text);
            if (String.IsNullOrEmpty(ncar2.Cod_MC))
            {
                return;
            }
            else
            {
                txtCodMC.Text = ncar2.Cod_MC;
                txtDescripcion.Text = ncar2.Descripcion;
                
                cmbCodFichaDetalle.SelectedValue = ncar2.Cod_Detalle_Ficha;
                cmbCodTMC.SelectedValue = ncar2.Cod_TMC;
                
                dtFechaInicio.Value = ncar2.Fecha_Inicio;
                dtFechaTermino.Value = ncar2.Fecha_Termino;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ngMedida_Correctiva car = new ngMedida_Correctiva();
            if (txtCodMC.Text.Trim().Length == 0 || txtDescripcion.Text.Trim().Length == 0 || cmbCodFichaDetalle.SelectedIndex == -1 || cmbCodTMC.SelectedIndex == -1)
            {
                MessageBox.Show("Ningún campo puede estar vacío");
                return;
            }
            else
            {
                if (!String.IsNullOrEmpty(car.buscaMedida_Correctiva(this.txtCodMC.Text).Cod_MC))
                {
                    ngMedida_Correctiva ncargo = new ngMedida_Correctiva();
                    ngMedida_Correctiva tod = new ngMedida_Correctiva();
                    ncargo.Cod_MC = txtCodMC.Text;
                    ncargo.Descripcion = txtDescripcion.Text;

                    ncargo.Cod_TMC = Convert.ToString(cmbCodTMC.SelectedValue);
                    ncargo.Cod_Detalle_Ficha = Convert.ToString(cmbCodFichaDetalle.SelectedValue);

                    ncargo.Fecha_Termino = dtFechaTermino.Value.Date;
                    ncargo.Fecha_Inicio = dtFechaInicio.Value.Date;

                    tod.actualizarMedida_Correctiva(ncargo);
                    MessageBox.Show("Medida_Correctiva Actualizado Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar Medida_Correctiva", "Mensaje Sistema");
                    return;
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            srGuardaDatosCorrectivos.wsGuardaDatosCorrectivosSoapClient auxSwGuardarDatosAlumnos = new srGuardaDatosCorrectivos.wsGuardaDatosCorrectivosSoapClient();
            srGuardaDatosCorrectivos.Medida_Correctiva auxAlumno = new srGuardaDatosCorrectivos.Medida_Correctiva();

            if (String.IsNullOrEmpty(auxSwGuardarDatosAlumnos.buscarMedida_Correctiva(this.txtCodMC.Text).Cod_MC))
            {
                MessageBox.Show("Medida Correctiva no existe", "Mensaje Sistema");
            }

            else
            {

                auxSwGuardarDatosAlumnos.eliminarMedidaCorrectiva(txtCodMC.Text);
                MessageBox.Show("MedidaCorrectiva eliminada", "Mensaje Sistema");
                Limpiar();
                this.txtCodMC.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmLstMedidaCorrectiva from = new frmLstMedidaCorrectiva();
            from.ShowDialog();
        }
    }
}
