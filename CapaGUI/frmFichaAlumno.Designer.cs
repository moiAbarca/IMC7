namespace CapaGUI
{
    partial class frmFichaAlumno
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
            this.gboxCabecera = new System.Windows.Forms.GroupBox();
            this.cmbRutRRHH = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaActualizacion = new System.Windows.Forms.DateTimePicker();
            this.cmbIdListaCurso = new System.Windows.Forms.ComboBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCod_Ficha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dtFechaProxRevision = new System.Windows.Forms.DateTimePicker();
            this.dtIFechaRevision = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txtClasifIMC = new System.Windows.Forms.TextBox();
            this.txtValorIMC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGuardarDetalle = new System.Windows.Forms.Button();
            this.txtCodCabeceraFicha = new System.Windows.Forms.TextBox();
            this.txtCodDetalleFicha = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRutAlumno = new System.Windows.Forms.TextBox();
            this.gboxCabecera.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxCabecera
            // 
            this.gboxCabecera.Controls.Add(this.txtRutAlumno);
            this.gboxCabecera.Controls.Add(this.cmbRutRRHH);
            this.gboxCabecera.Controls.Add(this.button1);
            this.gboxCabecera.Controls.Add(this.button2);
            this.gboxCabecera.Controls.Add(this.button3);
            this.gboxCabecera.Controls.Add(this.button4);
            this.gboxCabecera.Controls.Add(this.btnGuardar);
            this.gboxCabecera.Controls.Add(this.label11);
            this.gboxCabecera.Controls.Add(this.label3);
            this.gboxCabecera.Controls.Add(this.dtFechaActualizacion);
            this.gboxCabecera.Controls.Add(this.cmbIdListaCurso);
            this.gboxCabecera.Controls.Add(this.txtPeso);
            this.gboxCabecera.Controls.Add(this.txtEstatura);
            this.gboxCabecera.Controls.Add(this.label6);
            this.gboxCabecera.Controls.Add(this.label7);
            this.gboxCabecera.Controls.Add(this.label8);
            this.gboxCabecera.Controls.Add(this.label5);
            this.gboxCabecera.Controls.Add(this.txtCod_Ficha);
            this.gboxCabecera.Controls.Add(this.label4);
            this.gboxCabecera.Controls.Add(this.label2);
            this.gboxCabecera.Controls.Add(this.label1);
            this.gboxCabecera.Location = new System.Drawing.Point(12, 12);
            this.gboxCabecera.Name = "gboxCabecera";
            this.gboxCabecera.Size = new System.Drawing.Size(526, 212);
            this.gboxCabecera.TabIndex = 0;
            this.gboxCabecera.TabStop = false;
            this.gboxCabecera.Text = "Cabecera";
            this.gboxCabecera.Enter += new System.EventHandler(this.gboxCabecera_Enter);
            // 
            // cmbRutRRHH
            // 
            this.cmbRutRRHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRutRRHH.FormattingEnabled = true;
            this.cmbRutRRHH.Location = new System.Drawing.Point(103, 60);
            this.cmbRutRRHH.Name = "cmbRutRRHH";
            this.cmbRutRRHH.Size = new System.Drawing.Size(121, 21);
            this.cmbRutRRHH.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 23);
            this.button3.TabIndex = 47;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(434, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 23);
            this.button4.TabIndex = 46;
            this.button4.Text = "Listar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(116, 171);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(65, 23);
            this.btnGuardar.TabIndex = 45;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(491, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "cm";
            // 
            // dtFechaActualizacion
            // 
            this.dtFechaActualizacion.Location = new System.Drawing.Point(355, 133);
            this.dtFechaActualizacion.Name = "dtFechaActualizacion";
            this.dtFechaActualizacion.Size = new System.Drawing.Size(147, 20);
            this.dtFechaActualizacion.TabIndex = 42;
            // 
            // cmbIdListaCurso
            // 
            this.cmbIdListaCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdListaCurso.FormattingEnabled = true;
            this.cmbIdListaCurso.Location = new System.Drawing.Point(103, 98);
            this.cmbIdListaCurso.Name = "cmbIdListaCurso";
            this.cmbIdListaCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbIdListaCurso.TabIndex = 41;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(355, 95);
            this.txtPeso.MaxLength = 50;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(128, 20);
            this.txtPeso.TabIndex = 40;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(355, 57);
            this.txtEstatura.MaxLength = 50;
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(128, 20);
            this.txtEstatura.TabIndex = 39;
            this.txtEstatura.TextChanged += new System.EventHandler(this.txtEstatura_TextChanged);
            this.txtEstatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstatura_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Peso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Estatura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "RUT Alumno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Fecha Actualización";
            // 
            // txtCod_Ficha
            // 
            this.txtCod_Ficha.Location = new System.Drawing.Point(103, 22);
            this.txtCod_Ficha.MaxLength = 15;
            this.txtCod_Ficha.Name = "txtCod_Ficha";
            this.txtCod_Ficha.Size = new System.Drawing.Size(121, 20);
            this.txtCod_Ficha.TabIndex = 27;
            this.txtCod_Ficha.TextChanged += new System.EventHandler(this.txtCod_Ficha_TextChanged);
            this.txtCod_Ficha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_Ficha_KeyPress);
            this.txtCod_Ficha.Leave += new System.EventHandler(this.txtCod_Ficha_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "ListaCurso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Rut RRHH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Código Cab Ficha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.dtFechaProxRevision);
            this.groupBox1.Controls.Add(this.dtIFechaRevision);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtClasifIMC);
            this.groupBox1.Controls.Add(this.txtValorIMC);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtGuardarDetalle);
            this.groupBox1.Controls.Add(this.txtCodCabeceraFicha);
            this.groupBox1.Controls.Add(this.txtCodDetalleFicha);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(12, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(226, 183);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(65, 23);
            this.btnActualizar.TabIndex = 65;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(334, 183);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(65, 23);
            this.btnLimpiar.TabIndex = 64;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(10, 183);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 23);
            this.btnEliminar.TabIndex = 63;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(442, 183);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(65, 23);
            this.btnListar.TabIndex = 62;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dtFechaProxRevision
            // 
            this.dtFechaProxRevision.Location = new System.Drawing.Point(115, 140);
            this.dtFechaProxRevision.Name = "dtFechaProxRevision";
            this.dtFechaProxRevision.Size = new System.Drawing.Size(147, 20);
            this.dtFechaProxRevision.TabIndex = 61;
            // 
            // dtIFechaRevision
            // 
            this.dtIFechaRevision.Location = new System.Drawing.Point(115, 103);
            this.dtIFechaRevision.Name = "dtIFechaRevision";
            this.dtIFechaRevision.Size = new System.Drawing.Size(147, 20);
            this.dtIFechaRevision.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 13);
            this.label15.TabIndex = 59;
            this.label15.Text = "Fecha Prox Revisión";
            // 
            // txtClasifIMC
            // 
            this.txtClasifIMC.Enabled = false;
            this.txtClasifIMC.Location = new System.Drawing.Point(358, 66);
            this.txtClasifIMC.MaxLength = 50;
            this.txtClasifIMC.Name = "txtClasifIMC";
            this.txtClasifIMC.Size = new System.Drawing.Size(147, 20);
            this.txtClasifIMC.TabIndex = 54;
            // 
            // txtValorIMC
            // 
            this.txtValorIMC.Enabled = false;
            this.txtValorIMC.Location = new System.Drawing.Point(358, 28);
            this.txtValorIMC.MaxLength = 50;
            this.txtValorIMC.Name = "txtValorIMC";
            this.txtValorIMC.Size = new System.Drawing.Size(147, 20);
            this.txtValorIMC.TabIndex = 53;
            this.txtValorIMC.TextChanged += new System.EventHandler(this.txtValorIMC_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Clasif IMC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Valor IMC";
            // 
            // txtGuardarDetalle
            // 
            this.txtGuardarDetalle.Location = new System.Drawing.Point(118, 183);
            this.txtGuardarDetalle.Name = "txtGuardarDetalle";
            this.txtGuardarDetalle.Size = new System.Drawing.Size(65, 23);
            this.txtGuardarDetalle.TabIndex = 48;
            this.txtGuardarDetalle.Text = "Guardar";
            this.txtGuardarDetalle.UseVisualStyleBackColor = true;
            this.txtGuardarDetalle.Click += new System.EventHandler(this.txtGuardarDetalle_Click);
            // 
            // txtCodCabeceraFicha
            // 
            this.txtCodCabeceraFicha.Enabled = false;
            this.txtCodCabeceraFicha.Location = new System.Drawing.Point(115, 29);
            this.txtCodCabeceraFicha.MaxLength = 50;
            this.txtCodCabeceraFicha.Name = "txtCodCabeceraFicha";
            this.txtCodCabeceraFicha.Size = new System.Drawing.Size(121, 20);
            this.txtCodCabeceraFicha.TabIndex = 47;
            // 
            // txtCodDetalleFicha
            // 
            this.txtCodDetalleFicha.Location = new System.Drawing.Point(115, 66);
            this.txtCodDetalleFicha.MaxLength = 10;
            this.txtCodDetalleFicha.Name = "txtCodDetalleFicha";
            this.txtCodDetalleFicha.Size = new System.Drawing.Size(121, 20);
            this.txtCodDetalleFicha.TabIndex = 46;
            this.txtCodDetalleFicha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodDetalleFicha_KeyPress);
            this.txtCodDetalleFicha.Leave += new System.EventHandler(this.txtCodDetalleFicha_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Fecha Revisión";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Código Cab Ficha";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Código Det Ficha";
            // 
            // txtRutAlumno
            // 
            this.txtRutAlumno.Location = new System.Drawing.Point(355, 21);
            this.txtRutAlumno.MaxLength = 10;
            this.txtRutAlumno.Name = "txtRutAlumno";
            this.txtRutAlumno.Size = new System.Drawing.Size(128, 20);
            this.txtRutAlumno.TabIndex = 52;
            this.txtRutAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRutAlumno_KeyPress);
            this.txtRutAlumno.Leave += new System.EventHandler(this.txtRutAlumno_Leave);
            // 
            // frmFichaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxCabecera);
            this.Name = "frmFichaAlumno";
            this.Text = "Ficha Alumno";
            this.Load += new System.EventHandler(this.frmFichaAlumno_Load);
            this.gboxCabecera.ResumeLayout(false);
            this.gboxCabecera.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxCabecera;
        private System.Windows.Forms.DateTimePicker dtFechaActualizacion;
        private System.Windows.Forms.ComboBox cmbIdListaCurso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCod_Ficha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFechaProxRevision;
        private System.Windows.Forms.DateTimePicker dtIFechaRevision;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtClasifIMC;
        private System.Windows.Forms.TextBox txtValorIMC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button txtGuardarDetalle;
        private System.Windows.Forms.TextBox txtCodDetalleFicha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbRutRRHH;
        private System.Windows.Forms.TextBox txtCodCabeceraFicha;
        private System.Windows.Forms.TextBox txtRutAlumno;
    }
}