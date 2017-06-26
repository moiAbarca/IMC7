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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void datosColegioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColegio pCliente = new frmColegio();
            pCliente.ShowDialog();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurso pCliente = new frmCurso();
            pCliente.ShowDialog();
        }

        private void periodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listaCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaCurso pCliente = new frmListaCurso();
            pCliente.ShowDialog();
        }

        private void datosAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno pCliente = new frmAlumno();
            pCliente.ShowDialog();
        }

        private void fichaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaAlumno pCliente = new frmFichaAlumno();
            pCliente.ShowDialog();
        }

        private void tipoMedidaCorrectivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoMedidaCorrectiva pCliente = new frmTipoMedidaCorrectiva();
            pCliente.ShowDialog();
        }

        private void medidaCorrectivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedidaCorrectiva pCliente = new frmMedidaCorrectiva();
            pCliente.ShowDialog();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargo pCliente = new frmCargo();
            pCliente.ShowDialog();
        }

        private void rRHHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRRHH pCliente = new frmRRHH();
            pCliente.ShowDialog();
        }
    }
}
