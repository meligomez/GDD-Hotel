using FrbaHotel.FrbaHotelModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva
{
	public partial class SeleccionHabitacionParaReserva : Form
	{
		//public int habitacion_numero { get; set; }
		//public int habitacion_codigo { get; set; }
		public SeleccionHabitacionParaReserva()
		{
			InitializeComponent();
			if (Usuario.Instance!=null) {
				if (Usuario.Instance.rol_nombre != "recepcionista")
				{
					cargarComboHoteles();
					pnlListadoHotel.Visible = true;
				}
				else {
					pnlListadoHotel.Visible = false;
				}
			}
			cargarComboHoteles();
			pnlListadoHotel.Visible = true;
		}
		//public SeleccionHabitacionParaReserva(int habitacionNumero, int habitacionCodigo)
		//{
		//	this.habitacion_numero = habitacionNumero;
		//	this.habitacion_codigo = habitacion_codigo;
		//}

		private void buscarHabitacion_Click(object sender, EventArgs e)
		{
			try
			{
				HabitacionesDisponibles habitacion = new HabitacionesDisponibles();
				List<HabitacionesDisponibles> habitacions = new List<HabitacionesDisponibles>();
				if (Usuario.Instance != null) {
					//Usuario.Instance.rol_nombre == "Administrador";
					if (fechaInicio.Text.Trim() == ""
						|| cantDias.Text.Trim() == "" || cantHuespedes.Text.Trim() == ""
						|| cantDias.Text.Trim() == "0" || cantHuespedes.Text.Trim() == "0")
					{
						MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
						
					}
					habitacions = habitacion
						.getHabitacionesDisponibles(
						Usuario.Instance.hotel_id,
						fechaInicio.Text,
						int.Parse(cantDias.Text), int.Parse(cantHuespedes.Text));
					cargarComboRegimenes();
					cargarGrid(habitacions);
					pnlHabitacionesDisponibles.Visible = true;

				}
				//Usuario == "GUEST";
				if (fechaInicio.Text.Trim() == ""
					|| cantDias.Text.Trim() == "" || cantHuespedes.Text.Trim() == ""
					|| cantDias.Text.Trim() == "0" || cantHuespedes.Text.Trim() == "0"
					|| cbxHotel.SelectedIndex == 0)
				{
					MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				habitacions = habitacion
					.getHabitacionesDisponibles(
					cbxHotel.SelectedIndex,
					fechaInicio.Text,
					int.Parse(cantDias.Text), int.Parse(cantHuespedes.Text));
				cargarComboRegimenes();
				cargarGrid(habitacions);
				pnlHabitacionesDisponibles.Visible = true;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void cargarGrid(List<HabitacionesDisponibles>habitacions) {
			try
			{
				dgvHabitaciones.Columns.Clear();
				dgvHabitaciones.DataSource = null;
				AddButtonColumn();
				dgvHabitaciones.DataSource = habitacions;//seleccionHabitacionParaReservas;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void AddButtonColumn()
		{
			DataGridViewButtonColumn btnSelecc = new DataGridViewButtonColumn();
				btnSelecc.HeaderText = "Seleccionar";
				btnSelecc.Name = "seleccionar";
				btnSelecc.Text = "seleccionar";
				btnSelecc.UseColumnTextForButtonValue = true;
				btnSelecc.CellTemplate.Style.BackColor = Color.DarkGreen;
				dgvHabitaciones.Columns.Add(btnSelecc);
				btnSelecc.DisplayIndex = 0;
		}
		private decimal calcularPrecionTotalHabitacion(decimal precioPorNoche) {
			try
			{
				decimal precioCalculado = 0;
				DateTime fecha_ingreso = DateTime.Parse(fechaInicio.Text);
				//DateTime fecha_ingreso = "25-07-2017 16:45";
				TimeSpan ts = DateTime.Now - fecha_ingreso;
				int differenceInDias = ts.Days + int.Parse(cantDias.Text);
				//int cantDias=dateTime.
				precioCalculado = (precioPorNoche*differenceInDias);
				return precioCalculado;
			}
			catch (Exception ex){throw ex;}
		}
		private void SeleccionHabitacionParaReserva_Load(object sender, EventArgs e)
		{
			this.pnlHabitacionesDisponibles.Visible = false;
			this.pnlConfirmarReserva.Visible = false;
		}
		private void cargarComboRegimenes() {
			try
			{
				//Vaciar comboBox
				cbxTipoRegimen.DataSource = null;
				Regimen regimen = new Regimen();
				List<Regimen> listita = new List<Regimen>();
				listita= regimen.getRegimenes();
				//Asignar la propiedad DataSource
				//Indicar qué propiedad se verá en la lista
				this.cbxTipoRegimen.DisplayMember = "regimen_Descripcion";
				//Indicar qué valor tendrá cada ítem
				this.cbxTipoRegimen.ValueMember = "regimen_Id";
				//this.cbxTipoRegimen.Items.Insert(0, "Seleccione un rol");
				//cbxTipoRegimen.Items.Insert(0, new Regimen(0, "Seleccione elemento"));
				listita.Add(new Regimen(0, "Seleccione un regimen"));
				listita = listita.OrderBy(x => x.regimen_Id).ToList();
				this.cbxTipoRegimen.DataSource = listita;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void cargarComboDocumentosTipo()
		{
			try
			{
				//Vaciar comboBox
				cbxDocumentosTipo.DataSource = null;
				DocumentosTipo regimen = new DocumentosTipo();
				List<DocumentosTipo> listita = new List<DocumentosTipo>();
				listita = regimen.GetDocumentosTipos();
				//Asignar la propiedad DataSource
				//Indicar qué propiedad se verá en la lista
				this.cbxDocumentosTipo.DisplayMember = "tipo";
				//Indicar qué valor tendrá cada ítem
				this.cbxDocumentosTipo.ValueMember = "DocumentoId";
				//this.cbxTipoRegimen.Items.Insert(0, "Seleccione un rol");
				//cbxTipoRegimen.Items.Insert(0, new Regimen(0, "Seleccione elemento"));
				listita.Add(new DocumentosTipo(0, "Seleccione un documento"));
				listita = listita.OrderBy(x => x.DocumentoId).ToList();
				this.cbxDocumentosTipo.DataSource = listita;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void cargarComboHoteles()
		{
			try
			{
				//Vaciar comboBox
				cbxHotel.DataSource = null;
				Hotel regimen = new Hotel();
				List<Hotel> listita = new List<Hotel>();
				listita = regimen.getHotelesDisponibles();
				//Asignar la propiedad DataSource
				//Indicar qué propiedad se verá en la lista
				this.cbxHotel.DisplayMember = "hotel_direccion";
				//Indicar qué valor tendrá cada ítem
				this.cbxHotel.ValueMember = "hotel_id";
				//this.cbxTipoRegimen.Items.Insert(0, "Seleccione un rol");
				//cbxTipoRegimen.Items.Insert(0, new Regimen(0, "Seleccione elemento"));
				//listita.Add(new Hotel(0, "Seleccione un hotel"));
				listita = listita.OrderBy(x => x.hotel_id).ToList();
				this.cbxHotel.DataSource = listita;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void dgvHabitaciones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (dgvHabitaciones.CurrentCell.ColumnIndex == 0)
				{					
					var row = dgvHabitaciones.CurrentRow;
					int nroHab = Convert.ToInt32(row.Cells[1].Value);
					//nroHab = Convert.ToInt32(row.Cells[1].Value);
					Habitacion habitacion = new Habitacion();
					int tipoRegimen = cbxTipoRegimen.SelectedIndex;
					if (Usuario.Instance == null)
					{ int idHotel = 0;
						idHotel = cbxHotel.SelectedIndex;
						if (idHotel > 0) {
							txtPrecioCalculado.Text = habitacion.getPrecioHabitacionPorNoche(
							idHotel,
							nroHab, int.Parse(cantHuespedes.Text), tipoRegimen)
							.ToString();
						}
						else
						{
							//showToolTip("Seleccione una fecha de Salida.", cbxHotel, cbxHotel.Location);
							
						}
					}
					else
					{
						txtPrecioCalculado.Text = habitacion.getPrecioHabitacionPorNoche(
						Usuario.Instance.hotel_id, nroHab, int.Parse(cantHuespedes.Text), tipoRegimen)
						.ToString();
					}
					
					txtPrecioFinalCalculado.Text = this.calcularPrecionTotalHabitacion(decimal.Parse(txtPrecioCalculado.Text)).ToString();
					txtPrecioCalculado.ReadOnly = true;
					txtPrecioFinalCalculado.ReadOnly = true;
					txtNroHabitacion.Text = Text = Convert.ToString(row.Cells[1].Value);
					txtNroHabitacion.ReadOnly = true;
					//txtCodigo.Text= Convert.ToString(row.Cells[2].Value);
					//txtCodigo.ReadOnly = true;
					txtTipoHabitacion.Text= Convert.ToString(row.Cells[2].Value);
					txtNroHabitacion.ReadOnly = true;
					txtDescripcion.Text = Convert.ToString(row.Cells[3].Value);
					txtDescripcion.ReadOnly = true;
					cargarComboDocumentosTipo();
					this.pnlConfirmarReserva.Visible = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnGenerarReservas_Click_1(object sender, EventArgs e)
		{
			try
			{
				int hotelId = 0;
				Reserva reserva = new Reserva();
				if (Usuario.Instance == null)
				{
					hotelId = cbxHotel.SelectedIndex;
					reserva.reserva_usuario = 3;
				}
				else
				{
					if (Usuario.Instance.rol_id == 3)
					{
						reserva.reserva_usuario = Usuario.Instance.usuarioXHotel_usuario;
						hotelId = Usuario.Instance.rol_id;
					}
				}
				int tipoRegimen = cbxTipoRegimen.SelectedIndex;
				if (fechaInicio.Text.Trim() == "" || tipoRegimen == 0
					|| cantDias.Text.Trim() == "" || cantHuespedes.Text.Trim() == ""
					|| cantDias.Text.Trim() == "0" || cantHuespedes.Text.Trim() == "0"
					|| txtClienteIdentificacion.Text.Trim() == "" || txtMailCliente.Text.Trim() == ""
					)
				{
					MessageBox.Show("Faltan completar campos para completar la reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					reserva.reserva_fechaInicio = fechaInicio.Value;
					reserva.reserva_cantDias = int.Parse(cantDias.Value.ToString());
					reserva.reserva_tipoHabitacion = int.Parse(txtTipoHabitacion.Text);
					reserva.reserva_tipoRegimen = tipoRegimen;
					reserva.reserva_valor = decimal.Parse(txtPrecioFinalCalculado.Text);
					reserva.reserva_clienteIdentificacion = decimal.Parse(txtClienteIdentificacion.Text);
					reserva.reserva_clienteMail = txtMailCliente.Text;
					reserva.reserva_habitacionNro = int.Parse(txtNroHabitacion.Text);
					reserva.reserva_cantHuespedes = int.Parse(cantHuespedes.Value.ToString());
					int resultado = reserva.addReserva(reserva);
					if (resultado > 0)
					{
						MessageBox.Show("Se generó el siguiente código de reserva: " + resultado, "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else
					{
						MessageBox.Show("No se pudo registrar la reserva, vuelva intentelo más tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		/// <summary>
		/// Buequeda de un cliente por tipo de documento y mail
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnBuscarCliente_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtClienteIdentificacion.Text.Trim() == ""
						|| txtMailCliente.Text.Trim() == "")
				{
					MessageBox.Show("Faltan completar campos del cliente", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

				}
				else
				{
					Cliente cliente = new Cliente();
					cliente = cliente.GetCliente(int.Parse(txtClienteIdentificacion.Text), txtMailCliente.Text);
					txtClienteIdentificacion.Text = cliente.cliente_identificacion.ToString();
					txtMailCliente.Text = cliente.cliente_email;
					cargarGridCliente(cliente);
								
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
				throw;
			}
		}
		public void cargarGridCliente(Cliente cliente)
		{
			try
			{
				List<Cliente> clientes = new List<Cliente>();
				clientes.Add(cliente);
				dgvCliente.Columns.Clear();
				dgvCliente.DataSource = null;
				AddButtonColumn();
				dgvCliente.DataSource = clientes;//seleccionHabitacionParaReservas;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		/// <summary>
		/// Registracion de un nuevo cliente, redireccionamiento al formulario de abm de cliente
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnRegistrarNuevo_Click(object sender, EventArgs e)
		{
			try
			{
				AbmCliente.AgregarCliente agregar = new AbmCliente.AgregarCliente();
				agregar.Show();
				this.Dispose();
				//SeleccionHabitacionParaReserva seleccionHabitacionParaReserva = new SeleccionHabitacionParaReserva();
				//seleccionHabitacionParaReserva.Hide();
			}
			catch (Exception)
			{

				throw;
			}
		}
		private void pnlConfirmarReserva_Paint(object sender, PaintEventArgs e)
		{

		}

		private void lblPrecioCalculado_Click(object sender, EventArgs e)
		{

		}

		//private void btnGenerarReservas_Click(object sender, EventArgs e)
		//{
		//	try
		//	{
		//		int hotelId = 0;
		//		Reserva reserva = new Reserva();
		//		if (Usuario.Instance == null)
		//		{
		//			hotelId = cbxHotel.SelectedIndex;
		//			reserva.reserva_usuario = 3;
		//		}
		//		int tipoRegimen = cbxTipoRegimen.SelectedIndex;
		//		if (fechaInicio.Text.Trim() == "" || tipoRegimen == 0
		//			|| cantDias.Text.Trim() == "" || cantHuespedes.Text.Trim() == ""
		//			|| cantDias.Text.Trim() == "0" || cantHuespedes.Text.Trim() == "0"
		//			//|| txtClienteIdentificacion.Text.Trim() == "" || txtMailCliente.Text.Trim() == "0"
		//			)
		//		{
		//			MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//		}
		//		else
		//		{
		//			if (Usuario.Instance.rol_id == 3)
		//			{

		//			}

		//			reserva.reserva_fechaInicio = fechaInicio.Value;
		//			reserva.reserva_cantDias = int.Parse(cantDias.Value.ToString());
		//			reserva.reserva_tipoHabitacion = int.Parse(txtTipoHabitacion.Text);
		//			reserva.reserva_tipoRegimen = tipoRegimen;
		//			reserva.reserva_valor = decimal.Parse(txtPrecioFinalCalculado.Text);
		//			reserva.reserva_clienteIdentificacion = decimal.Parse(txtClienteIdentificacion.Text);
		//			reserva.reserva_clienteMail = txtMailCliente.Text;
		//			reserva.reserva_habitacionId = int.Parse(txtCodigo.Text);
		//			reserva.reserva_habitacionNro = int.Parse(txtNroHabitacion.Text);
		//			reserva.reserva_usuario = Usuario.Instance.usuarioXHotel_usuario;
		//			reserva.reserva_cantHuespedes = int.Parse(cantHuespedes.Value.ToString());
		//			int resultado = reserva.addReserva(reserva);
		//			if (resultado > 0)
		//			{
		//				MessageBox.Show("Se generó el siguiente código de reserva: " + resultado, "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		//			}
		//			else
		//			{
		//				MessageBox.Show("No se pudo registrar la reserva, vuelva intentelo más tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//			}
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}
		//}
		//private void showToolTip(string msj, Control ventana, Point pos)
		//{
		//	toolTip.Hide(ventana);
		//	toolTip.SetToolTip(ventana, "Entrada Invalida");
		//	toolTip.Show(msj, ventana, 50, 10, 5000);
		//}
	}

}
