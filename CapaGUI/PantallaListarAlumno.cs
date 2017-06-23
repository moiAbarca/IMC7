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
    public partial class PantallaListarAlumno : Form
    {
        public PantallaListarAlumno()
        {
            InitializeComponent();
        }

        private void btoMostrar_Click(object sender, EventArgs e)
        {
            srGuardaDatosAlumnos.wsGuardaDatosAlumnosSoapClient auxSwGuardarDatosAlumnos = new srGuardaDatosAlumnos.wsGuardaDatosAlumnosSoapClient();

            this.dataGridListadoCliente.DataSource = auxSwGuardarDatosAlumnos.entregaAlumnoDataSet();
            this.dataGridListadoCliente.DataMember = "Alumno";
        }
    }
}
