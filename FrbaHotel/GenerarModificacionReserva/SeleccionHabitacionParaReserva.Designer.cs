namespace FrbaHotel.GenerarModificacionReserva
{
	partial class SeleccionHabitacionParaReserva
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
			this.lblFechaInicio = new System.Windows.Forms.Label();
			this.fechaInicio = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.cantHuespedes = new System.Windows.Forms.NumericUpDown();
			this.lblCantDias = new System.Windows.Forms.Label();
			this.cantDias = new System.Windows.Forms.NumericUpDown();
			this.buscarHabitacion = new System.Windows.Forms.Button();
			this.pnlHabitacionesDisponibles = new System.Windows.Forms.Panel();
			this.lblHabDisponibles = new System.Windows.Forms.Label();
			this.lblTipoRegimenes = new System.Windows.Forms.Label();
			this.cbxTipoRegimen = new System.Windows.Forms.ComboBox();
			this.pnlConfirmarReserva = new System.Windows.Forms.Panel();
			this.txtPrecioCalculado = new System.Windows.Forms.TextBox();
			this.lblPrecioCalculado = new System.Windows.Forms.Label();
			this.btnGenerarReservas = new System.Windows.Forms.Button();
			this.txtPrecioFinalCalculado = new System.Windows.Forms.TextBox();
			this.lblPrecioFinalHabitacion = new System.Windows.Forms.Label();
			this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
			this.seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.cantHuespedes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cantDias)).BeginInit();
			this.pnlHabitacionesDisponibles.SuspendLayout();
			this.pnlConfirmarReserva.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
			this.SuspendLayout();
			// 
			// lblFechaInicio
			// 
			this.lblFechaInicio.AutoSize = true;
			this.lblFechaInicio.Location = new System.Drawing.Point(50, 26);
			this.lblFechaInicio.Name = "lblFechaInicio";
			this.lblFechaInicio.Size = new System.Drawing.Size(103, 17);
			this.lblFechaInicio.TabIndex = 3;
			this.lblFechaInicio.Text = "Fecha de inicio";
			// 
			// fechaInicio
			// 
			this.fechaInicio.Location = new System.Drawing.Point(159, 23);
			this.fechaInicio.Name = "fechaInicio";
			this.fechaInicio.Size = new System.Drawing.Size(256, 22);
			this.fechaInicio.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(158, 17);
			this.label2.TabIndex = 21;
			this.label2.Text = "Cantidad de huespedes";
			// 
			// cantHuespedes
			// 
			this.cantHuespedes.Location = new System.Drawing.Point(214, 70);
			this.cantHuespedes.Name = "cantHuespedes";
			this.cantHuespedes.Size = new System.Drawing.Size(81, 22);
			this.cantHuespedes.TabIndex = 20;
			this.cantHuespedes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lblCantDias
			// 
			this.lblCantDias.AutoSize = true;
			this.lblCantDias.Location = new System.Drawing.Point(595, 28);
			this.lblCantDias.Name = "lblCantDias";
			this.lblCantDias.Size = new System.Drawing.Size(114, 17);
			this.lblCantDias.TabIndex = 23;
			this.lblCantDias.Text = "Cantidad de dias";
			// 
			// cantDias
			// 
			this.cantDias.Location = new System.Drawing.Point(713, 25);
			this.cantDias.Name = "cantDias";
			this.cantDias.Size = new System.Drawing.Size(120, 22);
			this.cantDias.TabIndex = 22;
			this.cantDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// buscarHabitacion
			// 
			this.buscarHabitacion.Location = new System.Drawing.Point(615, 83);
			this.buscarHabitacion.Margin = new System.Windows.Forms.Padding(4);
			this.buscarHabitacion.Name = "buscarHabitacion";
			this.buscarHabitacion.Size = new System.Drawing.Size(217, 60);
			this.buscarHabitacion.TabIndex = 24;
			this.buscarHabitacion.Text = "BUSCAR HABITACION";
			this.buscarHabitacion.UseVisualStyleBackColor = true;
			this.buscarHabitacion.Click += new System.EventHandler(this.buscarHabitacion_Click);
			// 
			// pnlHabitacionesDisponibles
			// 
			this.pnlHabitacionesDisponibles.Controls.Add(this.dgvHabitaciones);
			this.pnlHabitacionesDisponibles.Controls.Add(this.pnlConfirmarReserva);
			this.pnlHabitacionesDisponibles.Controls.Add(this.lblTipoRegimenes);
			this.pnlHabitacionesDisponibles.Controls.Add(this.cbxTipoRegimen);
			this.pnlHabitacionesDisponibles.Controls.Add(this.lblHabDisponibles);
			this.pnlHabitacionesDisponibles.Location = new System.Drawing.Point(53, 154);
			this.pnlHabitacionesDisponibles.Name = "pnlHabitacionesDisponibles";
			this.pnlHabitacionesDisponibles.Size = new System.Drawing.Size(878, 386);
			this.pnlHabitacionesDisponibles.TabIndex = 26;
			// 
			// lblHabDisponibles
			// 
			this.lblHabDisponibles.AutoSize = true;
			this.lblHabDisponibles.Location = new System.Drawing.Point(3, 30);
			this.lblHabDisponibles.Name = "lblHabDisponibles";
			this.lblHabDisponibles.Size = new System.Drawing.Size(169, 17);
			this.lblHabDisponibles.TabIndex = 26;
			this.lblHabDisponibles.Text = "Habitaciones disponibles:";
			// 
			// lblTipoRegimenes
			// 
			this.lblTipoRegimenes.AutoSize = true;
			this.lblTipoRegimenes.Location = new System.Drawing.Point(314, 23);
			this.lblTipoRegimenes.Name = "lblTipoRegimenes";
			this.lblTipoRegimenes.Size = new System.Drawing.Size(111, 17);
			this.lblTipoRegimenes.TabIndex = 28;
			this.lblTipoRegimenes.Text = "Tipo de regimen";
			// 
			// cbxTipoRegimen
			// 
			this.cbxTipoRegimen.FormattingEnabled = true;
			this.cbxTipoRegimen.Location = new System.Drawing.Point(431, 23);
			this.cbxTipoRegimen.Name = "cbxTipoRegimen";
			this.cbxTipoRegimen.Size = new System.Drawing.Size(206, 24);
			this.cbxTipoRegimen.TabIndex = 27;
			// 
			// pnlConfirmarReserva
			// 
			this.pnlConfirmarReserva.Controls.Add(this.txtPrecioFinalCalculado);
			this.pnlConfirmarReserva.Controls.Add(this.lblPrecioFinalHabitacion);
			this.pnlConfirmarReserva.Controls.Add(this.btnGenerarReservas);
			this.pnlConfirmarReserva.Controls.Add(this.txtPrecioCalculado);
			this.pnlConfirmarReserva.Controls.Add(this.lblPrecioCalculado);
			this.pnlConfirmarReserva.Location = new System.Drawing.Point(6, 285);
			this.pnlConfirmarReserva.Name = "pnlConfirmarReserva";
			this.pnlConfirmarReserva.Size = new System.Drawing.Size(774, 100);
			this.pnlConfirmarReserva.TabIndex = 32;
			// 
			// txtPrecioCalculado
			// 
			this.txtPrecioCalculado.Location = new System.Drawing.Point(319, 17);
			this.txtPrecioCalculado.Name = "txtPrecioCalculado";
			this.txtPrecioCalculado.Size = new System.Drawing.Size(172, 22);
			this.txtPrecioCalculado.TabIndex = 33;
			// 
			// lblPrecioCalculado
			// 
			this.lblPrecioCalculado.AutoSize = true;
			this.lblPrecioCalculado.Location = new System.Drawing.Point(9, 18);
			this.lblPrecioCalculado.Name = "lblPrecioCalculado";
			this.lblPrecioCalculado.Size = new System.Drawing.Size(307, 17);
			this.lblPrecioCalculado.TabIndex = 32;
			this.lblPrecioCalculado.Text = "Precio por noche de la habitacion seleccionada";
			// 
			// btnGenerarReservas
			// 
			this.btnGenerarReservas.Location = new System.Drawing.Point(553, 18);
			this.btnGenerarReservas.Margin = new System.Windows.Forms.Padding(4);
			this.btnGenerarReservas.Name = "btnGenerarReservas";
			this.btnGenerarReservas.Size = new System.Drawing.Size(217, 60);
			this.btnGenerarReservas.TabIndex = 34;
			this.btnGenerarReservas.Text = "GENERAR RESERVA";
			this.btnGenerarReservas.UseVisualStyleBackColor = true;
			// 
			// txtPrecioFinalCalculado
			// 
			this.txtPrecioFinalCalculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecioFinalCalculado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtPrecioFinalCalculado.Location = new System.Drawing.Point(351, 49);
			this.txtPrecioFinalCalculado.Name = "txtPrecioFinalCalculado";
			this.txtPrecioFinalCalculado.Size = new System.Drawing.Size(172, 30);
			this.txtPrecioFinalCalculado.TabIndex = 36;
			// 
			// lblPrecioFinalHabitacion
			// 
			this.lblPrecioFinalHabitacion.AutoSize = true;
			this.lblPrecioFinalHabitacion.Location = new System.Drawing.Point(9, 49);
			this.lblPrecioFinalHabitacion.Name = "lblPrecioFinalHabitacion";
			this.lblPrecioFinalHabitacion.Size = new System.Drawing.Size(345, 17);
			this.lblPrecioFinalHabitacion.TabIndex = 35;
			this.lblPrecioFinalHabitacion.Text = "Precio de la habitacion con los valores seleccionados";
			// 
			// dgvHabitaciones
			// 
			this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccionar});
			this.dgvHabitaciones.Location = new System.Drawing.Point(106, 65);
			this.dgvHabitaciones.Margin = new System.Windows.Forms.Padding(4);
			this.dgvHabitaciones.Name = "dgvHabitaciones";
			this.dgvHabitaciones.Size = new System.Drawing.Size(636, 213);
			this.dgvHabitaciones.TabIndex = 33;
			this.dgvHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellContentClick_1);
			// 
			// seleccionar
			// 
			this.seleccionar.HeaderText = "Seleccion";
			this.seleccionar.Name = "seleccionar";
			// 
			// SeleccionHabitacionParaReserva
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(957, 556);
			this.Controls.Add(this.pnlHabitacionesDisponibles);
			this.Controls.Add(this.buscarHabitacion);
			this.Controls.Add(this.lblCantDias);
			this.Controls.Add(this.cantDias);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cantHuespedes);
			this.Controls.Add(this.lblFechaInicio);
			this.Controls.Add(this.fechaInicio);
			this.Name = "SeleccionHabitacionParaReserva";
			this.Text = "Seleccion de habitaciones para generar reservas";
			this.Load += new System.EventHandler(this.SeleccionHabitacionParaReserva_Load);
			((System.ComponentModel.ISupportInitialize)(this.cantHuespedes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cantDias)).EndInit();
			this.pnlHabitacionesDisponibles.ResumeLayout(false);
			this.pnlHabitacionesDisponibles.PerformLayout();
			this.pnlConfirmarReserva.ResumeLayout(false);
			this.pnlConfirmarReserva.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFechaInicio;
		private System.Windows.Forms.DateTimePicker fechaInicio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown cantHuespedes;
		private System.Windows.Forms.Label lblCantDias;
		private System.Windows.Forms.NumericUpDown cantDias;
		private System.Windows.Forms.Button buscarHabitacion;
		private System.Windows.Forms.Panel pnlHabitacionesDisponibles;
		private System.Windows.Forms.Label lblHabDisponibles;
		private System.Windows.Forms.Label lblTipoRegimenes;
		private System.Windows.Forms.ComboBox cbxTipoRegimen;
		private System.Windows.Forms.Panel pnlConfirmarReserva;
		private System.Windows.Forms.Button btnGenerarReservas;
		private System.Windows.Forms.TextBox txtPrecioCalculado;
		private System.Windows.Forms.Label lblPrecioCalculado;
		private System.Windows.Forms.TextBox txtPrecioFinalCalculado;
		private System.Windows.Forms.Label lblPrecioFinalHabitacion;
		private System.Windows.Forms.DataGridView dgvHabitaciones;
		private System.Windows.Forms.DataGridViewButtonColumn seleccionar;
	}
}