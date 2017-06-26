﻿using CapaNegocio;
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
            Clasificacion(Convert.ToDouble(txtValorIMC.Text));
        }

        private void txtGuardarDetalle_Click(object sender, EventArgs e)
        {
            if (txtCodDetalleFicha.Text.Trim().Length == 0 || txtCodCabeceraFicha.Text.Trim().Length == 0 || txtEstatura.Text.Trim().Length == 0 || txtPeso.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Algunos campos no pueden estar vacíos", "Diálogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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
            
            
        }

        private void frmFichaAlumno_Load(object sender, EventArgs e)
        {
            //carga el cmb con la lista del curso
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server=127.0.0.1;Database=IMC;Trusted_Connection=True;"))
            {
                string query = "select IdListaCurso, Año from Lista_Curso";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            cmbIdListaCurso.DisplayMember = "Año";
            cmbIdListaCurso.ValueMember = "IdListaCurso";
            cmbIdListaCurso.DataSource = dt;
        }
    }
}
