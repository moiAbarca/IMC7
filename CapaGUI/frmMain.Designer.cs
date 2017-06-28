namespace CapaGUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mantenedorColegioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosColegioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorMedidasCorrectivasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoMedidaCorrectivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medidaCorrectivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorRRHHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rRHHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesGeneralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedorColegioToolStripMenuItem,
            this.mantenedorAlumnoToolStripMenuItem,
            this.mantenedorMedidasCorrectivasToolStripMenuItem,
            this.mantenedorRRHHToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(416, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mantenedorColegioToolStripMenuItem
            // 
            this.mantenedorColegioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosColegioToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.listaCursoToolStripMenuItem});
            this.mantenedorColegioToolStripMenuItem.Name = "mantenedorColegioToolStripMenuItem";
            this.mantenedorColegioToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mantenedorColegioToolStripMenuItem.Text = "Colegio";
            // 
            // datosColegioToolStripMenuItem
            // 
            this.datosColegioToolStripMenuItem.Name = "datosColegioToolStripMenuItem";
            this.datosColegioToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.datosColegioToolStripMenuItem.Text = "Datos Colegio";
            this.datosColegioToolStripMenuItem.Click += new System.EventHandler(this.datosColegioToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.cursoToolStripMenuItem.Text = "Curso";
            this.cursoToolStripMenuItem.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click);
            // 
            // listaCursoToolStripMenuItem
            // 
            this.listaCursoToolStripMenuItem.Name = "listaCursoToolStripMenuItem";
            this.listaCursoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.listaCursoToolStripMenuItem.Text = "Lista Curso";
            this.listaCursoToolStripMenuItem.Click += new System.EventHandler(this.listaCursoToolStripMenuItem_Click);
            // 
            // mantenedorAlumnoToolStripMenuItem
            // 
            this.mantenedorAlumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosAlumnosToolStripMenuItem,
            this.fichaAlumnoToolStripMenuItem});
            this.mantenedorAlumnoToolStripMenuItem.Name = "mantenedorAlumnoToolStripMenuItem";
            this.mantenedorAlumnoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.mantenedorAlumnoToolStripMenuItem.Text = " Alumno";
            // 
            // datosAlumnosToolStripMenuItem
            // 
            this.datosAlumnosToolStripMenuItem.Name = "datosAlumnosToolStripMenuItem";
            this.datosAlumnosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.datosAlumnosToolStripMenuItem.Text = "Datos Alumnos";
            this.datosAlumnosToolStripMenuItem.Click += new System.EventHandler(this.datosAlumnosToolStripMenuItem_Click);
            // 
            // fichaAlumnoToolStripMenuItem
            // 
            this.fichaAlumnoToolStripMenuItem.Name = "fichaAlumnoToolStripMenuItem";
            this.fichaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.fichaAlumnoToolStripMenuItem.Text = "Ficha Alumno";
            this.fichaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.fichaAlumnoToolStripMenuItem_Click);
            // 
            // mantenedorMedidasCorrectivasToolStripMenuItem
            // 
            this.mantenedorMedidasCorrectivasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoMedidaCorrectivaToolStripMenuItem,
            this.medidaCorrectivaToolStripMenuItem});
            this.mantenedorMedidasCorrectivasToolStripMenuItem.Name = "mantenedorMedidasCorrectivasToolStripMenuItem";
            this.mantenedorMedidasCorrectivasToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.mantenedorMedidasCorrectivasToolStripMenuItem.Text = "Medidas Correctivas";
            // 
            // tipoMedidaCorrectivaToolStripMenuItem
            // 
            this.tipoMedidaCorrectivaToolStripMenuItem.Name = "tipoMedidaCorrectivaToolStripMenuItem";
            this.tipoMedidaCorrectivaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.tipoMedidaCorrectivaToolStripMenuItem.Text = "Tipo Medida Correctiva";
            this.tipoMedidaCorrectivaToolStripMenuItem.Click += new System.EventHandler(this.tipoMedidaCorrectivaToolStripMenuItem_Click);
            // 
            // medidaCorrectivaToolStripMenuItem
            // 
            this.medidaCorrectivaToolStripMenuItem.Name = "medidaCorrectivaToolStripMenuItem";
            this.medidaCorrectivaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.medidaCorrectivaToolStripMenuItem.Text = "Medida Correctiva";
            this.medidaCorrectivaToolStripMenuItem.Click += new System.EventHandler(this.medidaCorrectivaToolStripMenuItem_Click);
            // 
            // mantenedorRRHHToolStripMenuItem
            // 
            this.mantenedorRRHHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargoToolStripMenuItem,
            this.rRHHToolStripMenuItem});
            this.mantenedorRRHHToolStripMenuItem.Name = "mantenedorRRHHToolStripMenuItem";
            this.mantenedorRRHHToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.mantenedorRRHHToolStripMenuItem.Text = "RRHH";
            // 
            // cargoToolStripMenuItem
            // 
            this.cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
            this.cargoToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cargoToolStripMenuItem.Text = "Cargo";
            this.cargoToolStripMenuItem.Click += new System.EventHandler(this.cargoToolStripMenuItem_Click);
            // 
            // rRHHToolStripMenuItem
            // 
            this.rRHHToolStripMenuItem.Name = "rRHHToolStripMenuItem";
            this.rRHHToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.rRHHToolStripMenuItem.Text = "RRHH";
            this.rRHHToolStripMenuItem.Click += new System.EventHandler(this.rRHHToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteAlumnosToolStripMenuItem,
            this.reportesGeneralesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteAlumnosToolStripMenuItem
            // 
            this.reporteAlumnosToolStripMenuItem.Name = "reporteAlumnosToolStripMenuItem";
            this.reporteAlumnosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.reporteAlumnosToolStripMenuItem.Text = "Reporte Alumnos";
            this.reporteAlumnosToolStripMenuItem.Click += new System.EventHandler(this.reporteAlumnosToolStripMenuItem_Click);
            // 
            // reportesGeneralesToolStripMenuItem
            // 
            this.reportesGeneralesToolStripMenuItem.Name = "reportesGeneralesToolStripMenuItem";
            this.reportesGeneralesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.reportesGeneralesToolStripMenuItem.Text = "Reportes Generales";
            this.reportesGeneralesToolStripMenuItem.Click += new System.EventHandler(this.reportesGeneralesToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 399);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mantenedorColegioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosColegioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorMedidasCorrectivasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoMedidaCorrectivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medidaCorrectivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenedorRRHHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rRHHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesGeneralesToolStripMenuItem;
    }
}