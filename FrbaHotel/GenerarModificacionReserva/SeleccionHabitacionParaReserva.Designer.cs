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
			this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
			this.seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
			this.habitacion_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblTipoRegimenes = new System.Windows.Forms.Label();
			this.cbxTipoRegimen = new System.Windows.Forms.ComboBox();
			this.lblHabDisponibles = new System.Windows.Forms.Label();
			this.lblClienteMail = new System.Windows.Forms.Label();
			this.txtMailCliente = new System.Windows.Forms.TextBox();
			this.lblClienteIdentificacion = new System.Windows.Forms.Label();
			this.txtClienteIdentificacion = new System.Windows.Forms.TextBox();
			this.pnlConfirmarReserva = new System.Windows.Forms.Panel();
			this.lblTipoIdentificacion = new System.Windows.Forms.Label();
			this.cbxDocumentosTipo = new System.Windows.Forms.ComboBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtNroHabitacion = new System.Windows.Forms.TextBox();
			this.txtTipoHabitacion = new System.Windows.Forms.TextBox();
			this.lblHabitacionDescripcion = new System.Windows.Forms.Label();
			this.lblHabitacionNro = new System.Windows.Forms.Label();
			this.lblTipoHabitacion = new System.Windows.Forms.Label();
			this.lblDatosHabitacion = new System.Windows.Forms.Label();
			this.txtPrecioFinalCalculado = new System.Windows.Forms.TextBox();
			this.lblPrecioFinalHabitacion = new System.Windows.Forms.Label();
			this.btnGenerarReservas = new System.Windows.Forms.Button();
			this.txtPrecioCalculado = new System.Windows.Forms.TextBox();
			this.lblPrecioCalculado = new System.Windows.Forms.Label();
			this.pnlListadoHotel = new System.Windows.Forms.Panel();
			this.lblHotel = new System.Windows.Forms.Label();
			this.cbxHotel = new System.Windows.Forms.ComboBox();
			this.btnBuscarCliente = new System.Windows.Forms.Button();
			this.btnRegistrarNuevo = new System.Windows.Forms.Button();
			this.dgvCliente = new System.Windows.Forms.DataGridView();
			this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.cantHuespedes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cantDias)).BeginInit();
			this.pnlHabitacionesDisponibles.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
			this.pnlConfirmarReserva.SuspendLayout();
			this.pnlListadoHotel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
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
			this.lblCantDias.Location = new System.Drawing.Point(446, 28);
			this.lblCantDias.Name = "lblCantDias";
			this.lblCantDias.Size = new System.Drawing.Size(114, 17);
			this.lblCantDias.TabIndex = 23;
			this.lblCantDias.Text = "Cantidad de dias";
			// 
			// cantDias
			// 
			this.cantDias.Location = new System.Drawing.Point(564, 25);
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
			this.buscarHabitacion.Location = new System.Drawing.Point(467, 87);
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
			this.pnlHabitacionesDisponibles.Controls.Add(this.lblTipoRegimenes);
			this.pnlHabitacionesDisponibles.Controls.Add(this.cbxTipoRegimen);
			this.pnlHabitacionesDisponibles.Controls.Add(this.lblHabDisponibles);
			this.pnlHabitacionesDisponibles.Location = new System.Drawing.Point(12, 191);
			this.pnlHabitacionesDisponibles.Name = "pnlHabitacionesDisponibles";
			this.pnlHabitacionesDisponibles.Size = new System.Drawing.Size(752, 369);
			this.pnlHabitacionesDisponibles.TabIndex = 26;
			// 
			// dgvHabitaciones
			// 
			this.dgvHabitaciones.AllowUserToResizeRows = false;
			this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccionar,
            this.habitacion_numero});
			this.dgvHabitaciones.Location = new System.Drawing.Point(31, 65);
			this.dgvHabitaciones.Margin = new System.Windows.Forms.Padding(4);
			this.dgvHabitaciones.Name = "dgvHabitaciones";
			this.dgvHabitaciones.Size = new System.Drawing.Size(705, 213);
			this.dgvHabitaciones.TabIndex = 33;
			this.dgvHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellContentClick_1);
			// 
			// seleccionar
			// 
			this.seleccionar.HeaderText = "Seleccion";
			this.seleccionar.Name = "seleccionar";
			this.seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// habitacion_numero
			// 
			this.habitacion_numero.HeaderText = "Nro habitacion";
			this.habitacion_numero.Name = "habitacion_numero";
			// 
			// lblTipoRegimenes
			// 
			this.lblTipoRegimenes.AutoSize = true;
			this.lblTipoRegimenes.Location = new System.Drawing.Point(410, 23);
			this.lblTipoRegimenes.Name = "lblTipoRegimenes";
			this.lblTipoRegimenes.Size = new System.Drawing.Size(111, 17);
			this.lblTipoRegimenes.TabIndex = 28;
			this.lblTipoRegimenes.Text = "Tipo de regimen";
			// 
			// cbxTipoRegimen
			// 
			this.cbxTipoRegimen.FormattingEnabled = true;
			this.cbxTipoRegimen.Location = new System.Drawing.Point(527, 23);
			this.cbxTipoRegimen.Name = "cbxTipoRegimen";
			this.cbxTipoRegimen.Size = new System.Drawing.Size(206, 24);
			this.cbxTipoRegimen.TabIndex = 27;
			// 
			// lblHabDisponibles
			// 
			this.lblHabDisponibles.AutoSize = true;
			this.lblHabDisponibles.Location = new System.Drawing.Point(28, 30);
			this.lblHabDisponibles.Name = "lblHabDisponibles";
			this.lblHabDisponibles.Size = new System.Drawing.Size(169, 17);
			this.lblHabDisponibles.TabIndex = 26;
			this.lblHabDisponibles.Text = "Habitaciones disponibles:";
			// 
			// lblClienteMail
			// 
			this.lblClienteMail.AutoSize = true;
			this.lblClienteMail.Location = new System.Drawing.Point(73, 360);
			this.lblClienteMail.Name = "lblClienteMail";
			this.lblClienteMail.Size = new System.Drawing.Size(110, 17);
			this.lblClienteMail.TabIndex = 37;
			this.lblClienteMail.Text = "Email del cliente";
			// 
			// txtMailCliente
			// 
			this.txtMailCliente.Location = new System.Drawing.Point(189, 355);
			this.txtMailCliente.Name = "txtMailCliente";
			this.txtMailCliente.Size = new System.Drawing.Size(340, 22);
			this.txtMailCliente.TabIndex = 36;
			// 
			// lblClienteIdentificacion
			// 
			this.lblClienteIdentificacion.AutoSize = true;
			this.lblClienteIdentificacion.Location = new System.Drawing.Point(25, 322);
			this.lblClienteIdentificacion.Name = "lblClienteIdentificacion";
			this.lblClienteIdentificacion.Size = new System.Drawing.Size(158, 17);
			this.lblClienteIdentificacion.TabIndex = 35;
			this.lblClienteIdentificacion.Text = "Identificacion del cliente";
			// 
			// txtClienteIdentificacion
			// 
			this.txtClienteIdentificacion.Location = new System.Drawing.Point(189, 317);
			this.txtClienteIdentificacion.Name = "txtClienteIdentificacion";
			this.txtClienteIdentificacion.Size = new System.Drawing.Size(206, 22);
			this.txtClienteIdentificacion.TabIndex = 34;
			// 
			// pnlConfirmarReserva
			// 
			this.pnlConfirmarReserva.Controls.Add(this.dgvCliente);
			this.pnlConfirmarReserva.Controls.Add(this.btnRegistrarNuevo);
			this.pnlConfirmarReserva.Controls.Add(this.btnBuscarCliente);
			this.pnlConfirmarReserva.Controls.Add(this.lblTipoIdentificacion);
			this.pnlConfirmarReserva.Controls.Add(this.cbxDocumentosTipo);
			this.pnlConfirmarReserva.Controls.Add(this.lblClienteMail);
			this.pnlConfirmarReserva.Controls.Add(this.txtDescripcion);
			this.pnlConfirmarReserva.Controls.Add(this.txtMailCliente);
			this.pnlConfirmarReserva.Controls.Add(this.txtNroHabitacion);
			this.pnlConfirmarReserva.Controls.Add(this.lblClienteIdentificacion);
			this.pnlConfirmarReserva.Controls.Add(this.txtTipoHabitacion);
			this.pnlConfirmarReserva.Controls.Add(this.txtClienteIdentificacion);
			this.pnlConfirmarReserva.Controls.Add(this.lblHabitacionDescripcion);
			this.pnlConfirmarReserva.Controls.Add(this.lblHabitacionNro);
			this.pnlConfirmarReserva.Controls.Add(this.lblTipoHabitacion);
			this.pnlConfirmarReserva.Controls.Add(this.lblDatosHabitacion);
			this.pnlConfirmarReserva.Controls.Add(this.txtPrecioFinalCalculado);
			this.pnlConfirmarReserva.Controls.Add(this.lblPrecioFinalHabitacion);
			this.pnlConfirmarReserva.Controls.Add(this.btnGenerarReservas);
			this.pnlConfirmarReserva.Controls.Add(this.txtPrecioCalculado);
			this.pnlConfirmarReserva.Controls.Add(this.lblPrecioCalculado);
			this.pnlConfirmarReserva.Location = new System.Drawing.Point(780, 12);
			this.pnlConfirmarReserva.Name = "pnlConfirmarReserva";
			this.pnlConfirmarReserva.Size = new System.Drawing.Size(541, 682);
			this.pnlConfirmarReserva.TabIndex = 33;
			// 
			// lblTipoIdentificacion
			// 
			this.lblTipoIdentificacion.AutoSize = true;
			this.lblTipoIdentificacion.Location = new System.Drawing.Point(30, 283);
			this.lblTipoIdentificacion.Name = "lblTipoIdentificacion";
			this.lblTipoIdentificacion.Size = new System.Drawing.Size(142, 17);
			this.lblTipoIdentificacion.TabIndex = 47;
			this.lblTipoIdentificacion.Text = "Tipo de identificacion";
			// 
			// cbxDocumentosTipo
			// 
			this.cbxDocumentosTipo.FormattingEnabled = true;
			this.cbxDocumentosTipo.Location = new System.Drawing.Point(185, 276);
			this.cbxDocumentosTipo.Name = "cbxDocumentosTipo";
			this.cbxDocumentosTipo.Size = new System.Drawing.Size(213, 24);
			this.cbxDocumentosTipo.TabIndex = 46;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(187, 140);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(317, 22);
			this.txtDescripcion.TabIndex = 45;
			// 
			// txtNroHabitacion
			// 
			this.txtNroHabitacion.Location = new System.Drawing.Point(187, 101);
			this.txtNroHabitacion.Name = "txtNroHabitacion";
			this.txtNroHabitacion.Size = new System.Drawing.Size(172, 22);
			this.txtNroHabitacion.TabIndex = 44;
			// 
			// txtTipoHabitacion
			// 
			this.txtTipoHabitacion.Location = new System.Drawing.Point(187, 59);
			this.txtTipoHabitacion.Name = "txtTipoHabitacion";
			this.txtTipoHabitacion.Size = new System.Drawing.Size(172, 22);
			this.txtTipoHabitacion.TabIndex = 43;
			// 
			// lblHabitacionDescripcion
			// 
			this.lblHabitacionDescripcion.AutoSize = true;
			this.lblHabitacionDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblHabitacionDescripcion.Location = new System.Drawing.Point(74, 140);
			this.lblHabitacionDescripcion.Name = "lblHabitacionDescripcion";
			this.lblHabitacionDescripcion.Size = new System.Drawing.Size(95, 20);
			this.lblHabitacionDescripcion.TabIndex = 41;
			this.lblHabitacionDescripcion.Text = "descripcion";
			// 
			// lblHabitacionNro
			// 
			this.lblHabitacionNro.AutoSize = true;
			this.lblHabitacionNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblHabitacionNro.Location = new System.Drawing.Point(29, 103);
			this.lblHabitacionNro.Name = "lblHabitacionNro";
			this.lblHabitacionNro.Size = new System.Drawing.Size(140, 20);
			this.lblHabitacionNro.TabIndex = 40;
			this.lblHabitacionNro.Text = "Nro de habitacion";
			// 
			// lblTipoHabitacion
			// 
			this.lblTipoHabitacion.AutoSize = true;
			this.lblTipoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblTipoHabitacion.Location = new System.Drawing.Point(24, 61);
			this.lblTipoHabitacion.Name = "lblTipoHabitacion";
			this.lblTipoHabitacion.Size = new System.Drawing.Size(145, 20);
			this.lblTipoHabitacion.TabIndex = 38;
			this.lblTipoHabitacion.Text = "Tipo de habitacion";
			// 
			// lblDatosHabitacion
			// 
			this.lblDatosHabitacion.AutoSize = true;
			this.lblDatosHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
			this.lblDatosHabitacion.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblDatosHabitacion.Location = new System.Drawing.Point(81, 16);
			this.lblDatosHabitacion.Name = "lblDatosHabitacion";
			this.lblDatosHabitacion.Size = new System.Drawing.Size(360, 26);
			this.lblDatosHabitacion.TabIndex = 37;
			this.lblDatosHabitacion.Text = "Datos de la habitacion seleccionada";
			// 
			// txtPrecioFinalCalculado
			// 
			this.txtPrecioFinalCalculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecioFinalCalculado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtPrecioFinalCalculado.Location = new System.Drawing.Point(255, 220);
			this.txtPrecioFinalCalculado.Name = "txtPrecioFinalCalculado";
			this.txtPrecioFinalCalculado.Size = new System.Drawing.Size(172, 30);
			this.txtPrecioFinalCalculado.TabIndex = 36;
			// 
			// lblPrecioFinalHabitacion
			// 
			this.lblPrecioFinalHabitacion.AutoSize = true;
			this.lblPrecioFinalHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblPrecioFinalHabitacion.Location = new System.Drawing.Point(42, 226);
			this.lblPrecioFinalHabitacion.Name = "lblPrecioFinalHabitacion";
			this.lblPrecioFinalHabitacion.Size = new System.Drawing.Size(198, 24);
			this.lblPrecioFinalHabitacion.TabIndex = 35;
			this.lblPrecioFinalHabitacion.Text = "Precio total en Dólares";
			// 
			// btnGenerarReservas
			// 
			this.btnGenerarReservas.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.btnGenerarReservas.Location = new System.Drawing.Point(312, 616);
			this.btnGenerarReservas.Margin = new System.Windows.Forms.Padding(4);
			this.btnGenerarReservas.Name = "btnGenerarReservas";
			this.btnGenerarReservas.Size = new System.Drawing.Size(217, 60);
			this.btnGenerarReservas.TabIndex = 34;
			this.btnGenerarReservas.Text = "GENERAR RESERVA";
			this.btnGenerarReservas.UseVisualStyleBackColor = false;
			this.btnGenerarReservas.Click += new System.EventHandler(this.btnGenerarReservas_Click_1);
			// 
			// txtPrecioCalculado
			// 
			this.txtPrecioCalculado.Location = new System.Drawing.Point(187, 183);
			this.txtPrecioCalculado.Name = "txtPrecioCalculado";
			this.txtPrecioCalculado.Size = new System.Drawing.Size(172, 22);
			this.txtPrecioCalculado.TabIndex = 33;
			// 
			// lblPrecioCalculado
			// 
			this.lblPrecioCalculado.AutoSize = true;
			this.lblPrecioCalculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblPrecioCalculado.Location = new System.Drawing.Point(33, 183);
			this.lblPrecioCalculado.Name = "lblPrecioCalculado";
			this.lblPrecioCalculado.Size = new System.Drawing.Size(136, 20);
			this.lblPrecioCalculado.TabIndex = 32;
			this.lblPrecioCalculado.Text = "Precio por noche";
			// 
			// pnlListadoHotel
			// 
			this.pnlListadoHotel.Controls.Add(this.lblHotel);
			this.pnlListadoHotel.Controls.Add(this.cbxHotel);
			this.pnlListadoHotel.Location = new System.Drawing.Point(53, 107);
			this.pnlListadoHotel.Name = "pnlListadoHotel";
			this.pnlListadoHotel.Size = new System.Drawing.Size(383, 67);
			this.pnlListadoHotel.TabIndex = 34;
			// 
			// lblHotel
			// 
			this.lblHotel.AutoSize = true;
			this.lblHotel.Location = new System.Drawing.Point(21, 28);
			this.lblHotel.Name = "lblHotel";
			this.lblHotel.Size = new System.Drawing.Size(127, 17);
			this.lblHotel.TabIndex = 37;
			this.lblHotel.Text = "Seleccione el hotel";
			// 
			// cbxHotel
			// 
			this.cbxHotel.FormattingEnabled = true;
			this.cbxHotel.Location = new System.Drawing.Point(155, 21);
			this.cbxHotel.Name = "cbxHotel";
			this.cbxHotel.Size = new System.Drawing.Size(206, 24);
			this.cbxHotel.TabIndex = 36;
			// 
			// btnBuscarCliente
			// 
			this.btnBuscarCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnBuscarCliente.Location = new System.Drawing.Point(23, 397);
			this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
			this.btnBuscarCliente.Name = "btnBuscarCliente";
			this.btnBuscarCliente.Size = new System.Drawing.Size(217, 60);
			this.btnBuscarCliente.TabIndex = 48;
			this.btnBuscarCliente.Text = "Buscar cliente";
			this.btnBuscarCliente.UseVisualStyleBackColor = false;
			this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
			// 
			// btnRegistrarNuevo
			// 
			this.btnRegistrarNuevo.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnRegistrarNuevo.Location = new System.Drawing.Point(277, 397);
			this.btnRegistrarNuevo.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegistrarNuevo.Name = "btnRegistrarNuevo";
			this.btnRegistrarNuevo.Size = new System.Drawing.Size(217, 60);
			this.btnRegistrarNuevo.TabIndex = 49;
			this.btnRegistrarNuevo.Text = "Registrar cliente nuevo";
			this.btnRegistrarNuevo.UseVisualStyleBackColor = false;
			this.btnRegistrarNuevo.Click += new System.EventHandler(this.btnRegistrarNuevo_Click);
			// 
			// dgvCliente
			// 
			this.dgvCliente.AllowUserToResizeRows = false;
			this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1});
			this.dgvCliente.Location = new System.Drawing.Point(28, 465);
			this.dgvCliente.Margin = new System.Windows.Forms.Padding(4);
			this.dgvCliente.Name = "dgvCliente";
			this.dgvCliente.Size = new System.Drawing.Size(501, 143);
			this.dgvCliente.TabIndex = 50;
			// 
			// dataGridViewButtonColumn1
			// 
			this.dataGridViewButtonColumn1.HeaderText = "Seleccion";
			this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
			this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// SeleccionHabitacionParaReserva
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1333, 701);
			this.Controls.Add(this.pnlListadoHotel);
			this.Controls.Add(this.pnlConfirmarReserva);
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
			((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
			this.pnlConfirmarReserva.ResumeLayout(false);
			this.pnlConfirmarReserva.PerformLayout();
			this.pnlListadoHotel.ResumeLayout(false);
			this.pnlListadoHotel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
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
		private System.Windows.Forms.DataGridView dgvHabitaciones;
		private System.Windows.Forms.DataGridViewButtonColumn seleccionar;
		private System.Windows.Forms.DataGridViewTextBoxColumn habitacion_numero;
		private System.Windows.Forms.Label lblClienteMail;
		private System.Windows.Forms.TextBox txtMailCliente;
		private System.Windows.Forms.Label lblClienteIdentificacion;
		private System.Windows.Forms.TextBox txtClienteIdentificacion;
		private System.Windows.Forms.Panel pnlConfirmarReserva;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtNroHabitacion;
		private System.Windows.Forms.TextBox txtTipoHabitacion;
		private System.Windows.Forms.Label lblHabitacionDescripcion;
		private System.Windows.Forms.Label lblHabitacionNro;
		private System.Windows.Forms.Label lblTipoHabitacion;
		private System.Windows.Forms.Label lblDatosHabitacion;
		private System.Windows.Forms.TextBox txtPrecioFinalCalculado;
		private System.Windows.Forms.Label lblPrecioFinalHabitacion;
		private System.Windows.Forms.Button btnGenerarReservas;
		private System.Windows.Forms.TextBox txtPrecioCalculado;
		private System.Windows.Forms.Label lblPrecioCalculado;
		private System.Windows.Forms.Label lblTipoIdentificacion;
		private System.Windows.Forms.ComboBox cbxDocumentosTipo;
		private System.Windows.Forms.Panel pnlListadoHotel;
		private System.Windows.Forms.Label lblHotel;
		private System.Windows.Forms.ComboBox cbxHotel;
		private System.Windows.Forms.Button btnRegistrarNuevo;
		private System.Windows.Forms.Button btnBuscarCliente;
		private System.Windows.Forms.DataGridView dgvCliente;
		private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
		//private System.Windows.Forms.ToolTip toolTip;
	}
}