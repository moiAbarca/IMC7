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
    public partial class frmListarCurso : Form
    {
        public frmListarCurso()
        {
            InitializeComponent();
        }

        private void btoMostrar_Click(object sender, EventArgs e)
        {
            ngCurso car = new ngCurso();

            this.dgListadoCargos.DataSource = car.retornaCursoDataSet();
            this.dgListadoCargos.DataMember = "Curso";
        }
    }
}
