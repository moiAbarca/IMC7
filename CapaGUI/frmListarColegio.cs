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
    public partial class frmListarColegio : Form
    {
        public frmListarColegio()
        {
            InitializeComponent();
        }

        private void btoMostrar_Click(object sender, EventArgs e)
        {
            //srGuardaDatosAlumnos.wsGuardaDatosAlumnosSoapClient auxSwGuardarDatosAlumnos = new srGuardaDatosAlumnos.wsGuardaDatosAlumnosSoapClient();
            ngColegio car = new ngColegio();

            this.dgListadoCargos.DataSource = car.retornaColegioDataSet();
            this.dgListadoCargos.DataMember = "Colegio";
        }
    }
}
