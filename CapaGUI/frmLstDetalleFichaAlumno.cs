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
    public partial class frmLstDetalleFichaAlumno : Form
    {
        public frmLstDetalleFichaAlumno()
        {
            InitializeComponent();
        }

        private void btoMostrar_Click(object sender, EventArgs e)
        {
            ngDetalle_Ficha_Alumno car = new ngDetalle_Ficha_Alumno();

            this.dgListadoCargos.DataSource = car.retornaDetalle_Ficha_AlumnoDataSet();
            this.dgListadoCargos.DataMember = "Detalle_Ficha_Alumno";
        }
    }
}
