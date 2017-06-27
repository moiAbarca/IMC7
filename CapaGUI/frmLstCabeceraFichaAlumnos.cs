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
    public partial class frmLstCabeceraFichaAlumnos : Form
    {
        public frmLstCabeceraFichaAlumnos()
        {
            InitializeComponent();
        }

        private void btoMostrar_Click(object sender, EventArgs e)
        {
            ngCabecera_Ficha_Alumnos car = new ngCabecera_Ficha_Alumnos();

            this.dgListadoCargos.DataSource = car.retornaCabecera_Ficha_AlumnosDataSet();
            this.dgListadoCargos.DataMember = "Cabecera_Ficha_Alumnos";
        }
    }
}
