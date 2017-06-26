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
    public partial class frmListarCargo : Form
    {
        public frmListarCargo()
        {
            InitializeComponent();
        }

        private void btoMostrar_Click(object sender, EventArgs e)
        {
            ngCargo car = new ngCargo();
            
            this.dgListadoCargos.DataSource = car.retornaCargoDataSet();
            this.dgListadoCargos.DataMember = "Cargo";
        }
    }
}
