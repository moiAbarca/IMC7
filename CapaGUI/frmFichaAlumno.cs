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
            double tallaMEtro = talla / 100;
            txtValorIMC.Text = Convert.ToString((peso / (Math.Pow(tallaMEtro, 2))));
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
            if (txtCodDetalleFicha.Text.Trim().Length == 0 || txtCodCabeceraFicha.Text.Trim().Length == 0)
            {
                MessageBox.Show("Algunos campos no pueden estar vacíos", "Diálogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            ngDetalle_Ficha_Alumno det = new ngDetalle_Ficha_Alumno();
            ngDetalle_Ficha_Alumno de2 = new ngDetalle_Ficha_Alumno();

            det.Cod_Detalle_Ficha = txtCodDetalleFicha.Text;
            det.Cod_Ficha = txtCodCabeceraFicha.Text;
            det.Valor_IMC = Convert.ToDouble(txtValorIMC.Text);
            det.Clasificacion_IMC = txtClasifIMC.Text;
            det.Fecha_Revision = dtIFechaRevision.Value;
            det.Fecha_Proxima_Revision = dtFechaProxRevision.Value;

            de2.ingresaDetalle_Ficha_Alumno(det);
            
            
        }
    }
}
