namespace FrbaHotel.GenerarModificacionReserva
{
    partial class GenerarReserva
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cantDias = new System.Windows.Forms.NumericUpDown();
            this.lblCantDias = new System.Windows.Forms.Label();
            this.lblTipoHabitacion = new System.Windows.Forms.Label();
            this.cbxTipoRegimen = new System.Windows.Forms.ComboBox();
            this.lblTipoRegimenes = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtClienteIdentificacion = new System.Windows.Forms.TextBox();
            this.lblClienteIdentificacion = new System.Windows.Forms.Label();
            this.txtMailCliente = new System.Windows.Forms.TextBox();
            this.lblClienteMail = new System.Windows.Forms.Label();
            this.agregarEmpresa = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaskIdentif = new System.Windows.Forms.MaskedTextBox();
            this.comboHabit = new System.Windows.Forms.ComboBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cbxPiso = new System.Windows.Forms.ComboBox();
            this.lblPiso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cantDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cantDias
            // 
            this.cantDias.Location = new System.Drawing.Point(557, 66);
            this.cantDias.Name = "cantDias";
            this.cantDias.Size = new System.Drawing.Size(120, 22);
            this.cantDias.TabIndex = 2;
            // 
            // lblCantDias
            // 
            this.lblCantDias.AutoSize = true;
            this.lblCantDias.Location = new System.Drawing.Point(427, 69);
            this.lblCantDias.Name = "lblCantDias";
            this.lblCantDias.Size = new System.Drawing.Size(114, 17);
            this.lblCantDias.TabIndex = 3;
            this.lblCantDias.Text = "Cantidad de dias";
            // 
            // lblTipoHabitacion
            // 
            this.lblTipoHabitacion.AutoSize = true;
            this.lblTipoHabitacion.Location = new System.Drawing.Point(499, 354);
            this.lblTipoHabitacion.Name = "lblTipoHabitacion";
            this.lblTipoHabitacion.Size = new System.Drawing.Size(125, 17);
            this.lblTipoHabitacion.TabIndex = 5;
            this.lblTipoHabitacion.Text = "Tipo de habitacion";
            // 
            // cbxTipoRegimen
            // 
            this.cbxTipoRegimen.FormattingEnabled = true;
            this.cbxTipoRegimen.Location = new System.Drawing.Point(544, 278);
            this.cbxTipoRegimen.Name = "cbxTipoRegimen";
            this.cbxTipoRegimen.Size = new System.Drawing.Size(206, 24);
            this.cbxTipoRegimen.TabIndex = 6;
            // 
            // lblTipoRegimenes
            // 
            this.lblTipoRegimenes.AutoSize = true;
            this.lblTipoRegimenes.Location = new System.Drawing.Point(427, 278);
            this.lblTipoRegimenes.Name = "lblTipoRegimenes";
            this.lblTipoRegimenes.Size = new System.Drawing.Size(111, 17);
            this.lblTipoRegimenes.TabIndex = 7;
            this.lblTipoRegimenes.Text = "Tipo de regimen";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(153, 159);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(174, 22);
            this.txtValor.TabIndex = 8;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(106, 164);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(41, 17);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor";
            // 
            // txtClienteIdentificacion
            // 
            this.txtClienteIdentificacion.Location = new System.Drawing.Point(577, 157);
            this.txtClienteIdentificacion.Name = "txtClienteIdentificacion";
            this.txtClienteIdentificacion.Size = new System.Drawing.Size(206, 22);
            this.txtClienteIdentificacion.TabIndex = 10;
            // 
            // lblClienteIdentificacion
            // 
            this.lblClienteIdentificacion.AutoSize = true;
            this.lblClienteIdentificacion.Location = new System.Drawing.Point(402, 164);
            this.lblClienteIdentificacion.Name = "lblClienteIdentificacion";
            this.lblClienteIdentificacion.Size = new System.Drawing.Size(158, 17);
            this.lblClienteIdentificacion.TabIndex = 11;
            this.lblClienteIdentificacion.Text = "Identificacion del cliente";
            // 
            // txtMailCliente
            // 
            this.txtMailCliente.Location = new System.Drawing.Point(153, 206);
            this.txtMailCliente.Name = "txtMailCliente";
            this.txtMailCliente.Size = new System.Drawing.Size(340, 22);
            this.txtMailCliente.TabIndex = 13;
            // 
            // lblClienteMail
            // 
            this.lblClienteMail.AutoSize = true;
            this.lblClienteMail.Location = new System.Drawing.Point(37, 206);
            this.lblClienteMail.Name = "lblClienteMail";
            this.lblClienteMail.Size = new System.Drawing.Size(110, 17);
            this.lblClienteMail.TabIndex = 14;
            this.lblClienteMail.Text = "Email del cliente";
            // 
            // agregarEmpresa
            // 
            this.agregarEmpresa.Location = new System.Drawing.Point(408, 444);
            this.agregarEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.agregarEmpresa.Name = "agregarEmpresa";
            this.agregarEmpresa.Size = new System.Drawing.Size(133, 60);
            this.agregarEmpresa.TabIndex = 17;
            this.agregarEmpresa.Text = "AGREGAR RESERVA";
            this.agregarEmpresa.UseVisualStyleBackColor = true;
            this.agregarEmpresa.Click += new System.EventHandler(this.agregarEmpresa_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(201, 444);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 60);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cantidad de huespedes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(663, 211);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Identificacion del cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMaskIdentif
            // 
            this.txtMaskIdentif.Location = new System.Drawing.Point(201, 238);
            this.txtMaskIdentif.Mask = "999999999999999999";
            this.txtMaskIdentif.Name = "txtMaskIdentif";
            this.txtMaskIdentif.Size = new System.Drawing.Size(183, 22);
            this.txtMaskIdentif.TabIndex = 22;
            this.txtMaskIdentif.ValidatingType = typeof(int);
            this.txtMaskIdentif.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // comboHabit
            // 
            this.comboHabit.FormattingEnabled = true;
            this.comboHabit.Location = new System.Drawing.Point(647, 347);
            this.comboHabit.Name = "comboHabit";
            this.comboHabit.Size = new System.Drawing.Size(206, 24);
            this.comboHabit.TabIndex = 23;
            this.comboHabit.SelectedIndexChanged += new System.EventHandler(this.comboHabit_SelectedIndexChanged);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(44, 71);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(103, 17);
            this.lblFechaInicio.TabIndex = 1;
            this.lblFechaInicio.Text = "Fecha de inicio";
            // 
            // fechaInicio
            // 
            this.fechaInicio.Location = new System.Drawing.Point(153, 68);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(256, 22);
            this.fechaInicio.TabIndex = 0;
            // 
            // cbxPiso
            // 
            this.cbxPiso.FormattingEnabled = true;
            this.cbxPiso.Location = new System.Drawing.Point(178, 354);
            this.cbxPiso.Name = "cbxPiso";
            this.cbxPiso.Size = new System.Drawing.Size(206, 24);
            this.cbxPiso.TabIndex = 24;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(44, 361);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(122, 17);
            this.lblPiso.TabIndex = 25;
            this.lblPiso.Text = "Seleccione el piso";
            // 
            // GenerarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(925, 528);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.cbxPiso);
            this.Controls.Add(this.comboHabit);
            this.Controls.Add(this.txtMaskIdentif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.agregarEmpresa);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblClienteMail);
            this.Controls.Add(this.txtMailCliente);
            this.Controls.Add(this.lblClienteIdentificacion);
            this.Controls.Add(this.txtClienteIdentificacion);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblTipoRegimenes);
            this.Controls.Add(this.cbxTipoRegimen);
            this.Controls.Add(this.lblTipoHabitacion);
            this.Controls.Add(this.lblCantDias);
            this.Controls.Add(this.cantDias);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.fechaInicio);
            this.Name = "GenerarReserva";
            this.Text = "Generar reserva";
            this.Load += new System.EventHandler(this.GenerarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown cantDias;
        private System.Windows.Forms.Label lblCantDias;
        private System.Windows.Forms.Label lblTipoHabitacion;
        private System.Windows.Forms.ComboBox cbxTipoRegimen;
        private System.Windows.Forms.Label lblTipoRegimenes;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtClienteIdentificacion;
        private System.Windows.Forms.Label lblClienteIdentificacion;
        private System.Windows.Forms.TextBox txtMailCliente;
        private System.Windows.Forms.Label lblClienteMail;
        private System.Windows.Forms.Button agregarEmpresa;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtMaskIdentif;
        private System.Windows.Forms.ComboBox comboHabit;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.ComboBox cbxPiso;
        private System.Windows.Forms.Label lblPiso;
    }
}
