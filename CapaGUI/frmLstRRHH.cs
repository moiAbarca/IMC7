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
    public partial class frmLstRRHH : Form
    {
        public frmLstRRHH()
        {
            InitializeComponent();
        }

        private void btoMostrar_Click(object sender, EventArgs e)
        {
            ngRRHH car = new ngRRHH();

            this.dgListadoCargos.DataSource = car.retornaRRHHDataSet();
            this.dgListadoCargos.DataMember = "RRHH";
        }
    }
}
