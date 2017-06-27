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
    public partial class frmLstMedidaCorrectiva : Form
    {
        public frmLstMedidaCorrectiva()
        {
            InitializeComponent();
        }

        private void btoMostrar_Click(object sender, EventArgs e)
        {
            ngMedida_Correctiva car = new ngMedida_Correctiva();

            this.dgListadoCargos.DataSource = car.retornaMedida_CorrectivaDataSet();
            this.dgListadoCargos.DataMember = "Medida_Correctiva";
        }
    }
}
