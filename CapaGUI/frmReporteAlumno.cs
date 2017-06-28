using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using CapaNegocio;
using CapaDTO;


namespace CapaGUI
{
    public partial class frmReporteAlumno : Form
    {
        public frmReporteAlumno()
        {
            InitializeComponent();
        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < dtEntregaResultados.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtEntregaResultados.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = dtEntregaResultados.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }

                //Excel.Application xlApp;
                //Excel.Workbook xlWorkBook;
                //Excel.Worksheet xlWorkSheet;
                //object misValue = System.Reflection.Missing.Value;

                //xlApp = new Excel.Application();
                //xlWorkBook = xlApp.Workbooks.Add(misValue);
                //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                //int i = 0;
                //int j = 0;

                //for (i = 0; i <= dtReporteAlu.RowCount - 1; i++)
                //{
                //    for (j = 0; j <= dtReporteAlu.ColumnCount - 1; j++)
                //    {
                //        DataGridViewCell cell = dtReporteAlu[j, i];
                //        xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                //    }
                //}

                //xlWorkBook.SaveAs("Reporte_Historico.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                //xlWorkBook.Close(true, misValue, misValue);
                //xlApp.Quit();

                //releaseObject(xlWorkSheet);
                //releaseObject(xlWorkBook);
                //releaseObject(xlApp);

                //MessageBox.Show("Excel creado en =  c:\\Reporte_Historico.xls");
            }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            srComparaIMC.wsComparaIMCSoapClient compimc = new srComparaIMC.wsComparaIMCSoapClient();
            this.dtReporteAlu.DataSource = compimc.comparaIMC(txtRut.Text);
            this.dtReporteAlu.DataMember = "Detalle_Ficha_Alumno";
            //this.dtReporteAlu.DataMember = "Reporte_Alumno";

            srEntregaResultadosAlumno.wsGeneraResultadosSoapClient entrega = new srEntregaResultadosAlumno.wsGeneraResultadosSoapClient();
            this.dtEntregaResultados.DataSource = entrega.generaResultados(txtRut.Text);
            //this.dtEntregaResultados.DataMember = "Reporte_Resultados_Alumno";
            this.dtEntregaResultados.DataMember = "Detalle_Ficha_Alumno";
        }
    }
}
