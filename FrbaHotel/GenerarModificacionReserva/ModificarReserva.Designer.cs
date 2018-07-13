namespace FrbaHotel.GenerarModificacionReserva
{
    partial class ModificarReserva
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
			this.botonDisponibilidad = new System.Windows.Forms.Button();
			this.textPrecio = new System.Windows.Forms.TextBox();
			this.labelPrecio = new System.Windows.Forms.Label();
			this.labelRegimen = new System.Windows.Forms.Label();
			this.labelPersonas = new System.Windows.Forms.Label();
			this.labelHabitacion = new System.Windows.Forms.Label();
			this.labelFechaHasta = new System.Windows.Forms.Label();
			this.labelFechaDesde = new System.Windows.Forms.Label();
			this.comboTipoRegimen = new System.Windows.Forms.ComboBox();
			this.textCant = new System.Windows.Forms.MaskedTextBox();
			this.comboTipoHab = new System.Windows.Forms.ComboBox();
			this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
			this.botonModificar = new System.Windows.Forms.Button();
			this.labelHuesped = new System.Windows.Forms.Label();
			this.textHuesped = new System.Windows.Forms.TextBox();
			this.textNroReserva = new System.Windows.Forms.TextBox();
			this.labelNroReserva = new System.Windows.Forms.Label();
			this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
			this.botonLimpiar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// botonDisponibilidad
			// 
			this.botonDisponibilidad.Location = new System.Drawing.Point(220, 405);
			this.botonDisponibilidad.Margin = new System.Windows.Forms.Padding(4);
			this.botonDisponibilidad.Name = "botonDisponibilidad";
			this.botonDisponibilidad.Size = new System.Drawing.Size(243, 40);
			this.botonDisponibilidad.TabIndex = 34;
			this.botonDisponibilidad.Text = "VERIFICAR DATOS";
			this.botonDisponibilidad.UseVisualStyleBackColor = true;
			// 
			// textPrecio
			// 
			this.textPrecio.Location = new System.Drawing.Point(537, 343);
			this.textPrecio.Margin = new System.Windows.Forms.Padding(4);
			this.textPrecio.Name = "textPrecio";
			this.textPrecio.ReadOnly = true;
			this.textPrecio.Size = new System.Drawing.Size(132, 22);
			this.textPrecio.TabIndex = 33;
			// 
			// labelPrecio
			// 
			this.labelPrecio.AutoSize = true;
			this.labelPrecio.Location = new System.Drawing.Point(393, 343);
			this.labelPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPrecio.Name = "labelPrecio";
			this.labelPrecio.Size = new System.Drawing.Size(136, 17);
			this.labelPrecio.TabIndex = 32;
			this.labelPrecio.Text = "Costo de la Reserva";
			// 
			// labelRegimen
			// 
			this.labelRegimen.AutoSize = true;
			this.labelRegimen.Location = new System.Drawing.Point(21, 266);
			this.labelRegimen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelRegimen.Name = "labelRegimen";
			this.labelRegimen.Size = new System.Drawing.Size(116, 17);
			this.labelRegimen.TabIndex = 31;
			this.labelRegimen.Text = "Tipo de Régimen";
			// 
			// labelPersonas
			// 
			this.labelPersonas.AutoSize = true;
			this.labelPersonas.Location = new System.Drawing.Point(13, 322);
			this.labelPersonas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPersonas.Name = "labelPersonas";
			this.labelPersonas.Size = new System.Drawing.Size(160, 17);
			this.labelPersonas.TabIndex = 30;
			this.labelPersonas.Text = "Cantidad de Huespedes";
			this.labelPersonas.Click += new System.EventHandler(this.labelPersonas_Click);
			// 
			// labelHabitacion
			// 
			this.labelHabitacion.AutoSize = true;
			this.labelHabitacion.Location = new System.Drawing.Point(21, 202);
			this.labelHabitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelHabitacion.Name = "labelHabitacion";
			this.labelHabitacion.Size = new System.Drawing.Size(127, 17);
			this.labelHabitacion.TabIndex = 29;
			this.labelHabitacion.Text = "Tipo de Habitación";
			// 
			// labelFechaHasta
			// 
			this.labelFechaHasta.AutoSize = true;
			this.labelFechaHasta.Location = new System.Drawing.Point(284, 109);
			this.labelFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelFechaHasta.Name = "labelFechaHasta";
			this.labelFechaHasta.Size = new System.Drawing.Size(90, 17);
			this.labelFechaHasta.TabIndex = 28;
			this.labelFechaHasta.Text = "Fecha de Fin";
			// 
			// labelFechaDesde
			// 
			this.labelFechaDesde.AutoSize = true;
			this.labelFechaDesde.Location = new System.Drawing.Point(13, 113);
			this.labelFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelFechaDesde.Name = "labelFechaDesde";
			this.labelFechaDesde.Size = new System.Drawing.Size(103, 17);
			this.labelFechaDesde.TabIndex = 27;
			this.labelFechaDesde.Text = "Fecha de Inicio";
			// 
			// comboTipoRegimen
			// 
			this.comboTipoRegimen.FormattingEnabled = true;
			this.comboTipoRegimen.Location = new System.Drawing.Point(156, 263);
			this.comboTipoRegimen.Margin = new System.Windows.Forms.Padding(4);
			this.comboTipoRegimen.Name = "comboTipoRegimen";
			this.comboTipoRegimen.Size = new System.Drawing.Size(132, 24);
			this.comboTipoRegimen.TabIndex = 26;
			// 
			// textCant
			// 
			this.textCant.Location = new System.Drawing.Point(181, 319);
			this.textCant.Margin = new System.Windows.Forms.Padding(4);
			this.textCant.Mask = "99";
			this.textCant.Name = "textCant";
			this.textCant.Size = new System.Drawing.Size(53, 22);
			this.textCant.TabIndex = 25;
			// 
			// comboTipoHab
			// 
			this.comboTipoHab.FormattingEnabled = true;
			this.comboTipoHab.Location = new System.Drawing.Point(156, 201);
			this.comboTipoHab.Margin = new System.Windows.Forms.Padding(4);
			this.comboTipoHab.Name = "comboTipoHab";
			this.comboTipoHab.Size = new System.Drawing.Size(132, 24);
			this.comboTipoHab.TabIndex = 24;
			// 
			// dateTimeInicio
			// 
			this.dateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimeInicio.Location = new System.Drawing.Point(124, 109);
			this.dateTimeInicio.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimeInicio.Name = "dateTimeInicio";
			this.dateTimeInicio.Size = new System.Drawing.Size(132, 22);
			this.dateTimeInicio.TabIndex = 22;
			// 
			// botonModificar
			// 
			this.botonModificar.Location = new System.Drawing.Point(493, 497);
			this.botonModificar.Margin = new System.Windows.Forms.Padding(4);
			this.botonModificar.Name = "botonModificar";
			this.botonModificar.Size = new System.Drawing.Size(163, 38);
			this.botonModificar.TabIndex = 37;
			this.botonModificar.Text = "MODIFICAR RESERVA";
			this.botonModificar.UseVisualStyleBackColor = true;
			// 
			// labelHuesped
			// 
			this.labelHuesped.AutoSize = true;
			this.labelHuesped.Location = new System.Drawing.Point(325, 22);
			this.labelHuesped.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelHuesped.Name = "labelHuesped";
			this.labelHuesped.Size = new System.Drawing.Size(100, 17);
			this.labelHuesped.TabIndex = 36;
			this.labelHuesped.Text = "Realizada por:";
			// 
			// textHuesped
			// 
			this.textHuesped.Location = new System.Drawing.Point(433, 22);
			this.textHuesped.Margin = new System.Windows.Forms.Padding(4);
			this.textHuesped.Name = "textHuesped";
			this.textHuesped.ReadOnly = true;
			this.textHuesped.Size = new System.Drawing.Size(263, 22);
			this.textHuesped.TabIndex = 35;
			// 
			// textNroReserva
			// 
			this.textNroReserva.Location = new System.Drawing.Point(156, 19);
			this.textNroReserva.Margin = new System.Windows.Forms.Padding(4);
			this.textNroReserva.Name = "textNroReserva";
			this.textNroReserva.ReadOnly = true;
			this.textNroReserva.Size = new System.Drawing.Size(132, 22);
			this.textNroReserva.TabIndex = 21;
			this.textNroReserva.TextChanged += new System.EventHandler(this.textNroReserva_TextChanged);
			// 
			// labelNroReserva
			// 
			this.labelNroReserva.AutoSize = true;
			this.labelNroReserva.Location = new System.Drawing.Point(13, 22);
			this.labelNroReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelNroReserva.Name = "labelNroReserva";
			this.labelNroReserva.Size = new System.Drawing.Size(129, 17);
			this.labelNroReserva.TabIndex = 20;
			this.labelNroReserva.Text = "Codigo de Reserva";
			this.labelNroReserva.Click += new System.EventHandler(this.labelNroReserva_Click);
			// 
			// dateTimeFin
			// 
			this.dateTimeFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimeFin.Location = new System.Drawing.Point(392, 108);
			this.dateTimeFin.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimeFin.Name = "dateTimeFin";
			this.dateTimeFin.Size = new System.Drawing.Size(132, 22);
			this.dateTimeFin.TabIndex = 23;
			// 
			// botonLimpiar
			// 
			this.botonLimpiar.Location = new System.Drawing.Point(24, 497);
			this.botonLimpiar.Margin = new System.Windows.Forms.Padding(4);
			this.botonLimpiar.Name = "botonLimpiar";
			this.botonLimpiar.Size = new System.Drawing.Size(145, 38);
			this.botonLimpiar.TabIndex = 38;
			this.botonLimpiar.Text = "CANCELAR";
			this.botonLimpiar.UseVisualStyleBackColor = true;
			// 
			// ModificarReserva
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.ClientSize = new System.Drawing.Size(709, 580);
			this.Controls.Add(this.botonDisponibilidad);
			this.Controls.Add(this.textPrecio);
			this.Controls.Add(this.labelPrecio);
			this.Controls.Add(this.labelRegimen);
			this.Controls.Add(this.labelPersonas);
			this.Controls.Add(this.labelHabitacion);
			this.Controls.Add(this.labelFechaHasta);
			this.Controls.Add(this.labelFechaDesde);
			this.Controls.Add(this.comboTipoRegimen);
			this.Controls.Add(this.textCant);
			this.Controls.Add(this.comboTipoHab);
			this.Controls.Add(this.dateTimeInicio);
			this.Controls.Add(this.botonModificar);
			this.Controls.Add(this.labelHuesped);
			this.Controls.Add(this.textHuesped);
			this.Controls.Add(this.textNroReserva);
			this.Controls.Add(this.labelNroReserva);
			this.Controls.Add(this.dateTimeFin);
			this.Controls.Add(this.botonLimpiar);
			this.Name = "ModificarReserva";
			this.Text = "Modificar la reserva";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button botonDisponibilidad;
		private System.Windows.Forms.TextBox textPrecio;
		private System.Windows.Forms.Label labelPrecio;
		private System.Windows.Forms.Label labelRegimen;
		private System.Windows.Forms.Label labelPersonas;
		private System.Windows.Forms.Label labelHabitacion;
		private System.Windows.Forms.Label labelFechaHasta;
		private System.Windows.Forms.Label labelFechaDesde;
		private System.Windows.Forms.ComboBox comboTipoRegimen;
		private System.Windows.Forms.MaskedTextBox textCant;
		private System.Windows.Forms.ComboBox comboTipoHab;
		private System.Windows.Forms.DateTimePicker dateTimeInicio;
		private System.Windows.Forms.Button botonModificar;
		private System.Windows.Forms.Label labelHuesped;
		private System.Windows.Forms.TextBox textHuesped;
		private System.Windows.Forms.TextBox textNroReserva;
		private System.Windows.Forms.Label labelNroReserva;
		private System.Windows.Forms.DateTimePicker dateTimeFin;
		private System.Windows.Forms.Button botonLimpiar;
	}
}
