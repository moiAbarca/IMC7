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
    public partial class frmLstTipoMedidaCorrectiva : Form
    {
        public frmLstTipoMedidaCorrectiva()
        {
            InitializeComponent();
        }

        private void btoMostrar_Click(object sender, EventArgs e)
        {
            ngTipo_Medida_Correctiva car = new ngTipo_Medida_Correctiva();

            this.dgListadoCargos.DataSource = car.retornaTipo_Medida_CorrectivaDataSet();
            this.dgListadoCargos.DataMember = "Tipo_Medida_Correctiva";
        }
    }
}
