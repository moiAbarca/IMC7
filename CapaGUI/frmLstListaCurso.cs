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
    public partial class frmLstListaCurso : Form
    {
        public frmLstListaCurso()
        {
            InitializeComponent();
        }

        private void btoMostrar_Click(object sender, EventArgs e)
        {
            ngLista_Curso car = new ngLista_Curso();

            this.dgListadoCargos.DataSource = car.retornaLista_CursoDataSet();
            this.dgListadoCargos.DataMember = "Lista_Curso";
        }
    }
}
