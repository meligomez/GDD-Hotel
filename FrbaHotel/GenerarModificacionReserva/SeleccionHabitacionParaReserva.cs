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
		public SeleccionHabitacionParaReserva()
		{
			InitializeComponent();
	    }
		private void buscarHabitacion_Click(object sender, EventArgs e)
		{
			try
			{
				pnlConfirmarReserva.Visible = false;
				if (Usuario.Instance.rol_id == 3)
					{
						buscarHabitacionesDisponibleUsuarioGuest();
					}
					if (Usuario.Instance.rol_id == 2)
					{
						buscarHabitacionesDisponibleUsuarioRecepcionista();
					}
				
					
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void buscarHabitacionesDisponibleUsuarioGuest() {
			try
			{
			 if (chequearDatos()) { 
				if (chequearDatosUsuarioGuest()) {
					HabitacionesDisponibles habitacion = new HabitacionesDisponibles();
					List<HabitacionesDisponibles> habitacions = new List<HabitacionesDisponibles>();
					habitacions = habitacion.getHabitacionesDisponibles(
						cbxHotel.SelectedIndex,
						fechaInicio.Text,
						fechaFin.Text,
						int.Parse(cantHuespedes.Text));
					cargarComboRegimenes();
					cargarGrid(habitacions);
					pnlHabitacionesDisponibles.Visible = true;
				}
			}
			}
			catch (Exception)
			{

				throw;
			}
		}
		public void buscarHabitacionesDisponibleUsuarioRecepcionista()
		{
			try
			{
				if (chequearDatos())
				{
					HabitacionesDisponibles habitacion = new HabitacionesDisponibles();
					List<HabitacionesDisponibles> habitacions = new List<HabitacionesDisponibles>();
					habitacions = habitacion
						.getHabitacionesDisponibles(
						Usuario.Instance.hotel_id,
						fechaInicio.Text,
						fechaFin.Text, int.Parse(cantHuespedes.Text));
					cargarComboRegimenes();
					cargarGrid(habitacions);
					pnlHabitacionesDisponibles.Visible = true;

				}
			}
			catch (Exception)
			{

				throw;
			}
		}
		public void cargarGrid(List<HabitacionesDisponibles>habitacions) {
			try
			{
				dgvHabitaciones.Columns.Clear();
				dgvHabitaciones.DataSource = null;
				AddButtonColumn();
				
				this.lblHabDisponibles.Text = "Cantidad de habitaciones disponibles: " + habitacions.Count().ToString();
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
				int totalDias = fechaFin.Value.Date.Subtract(fechaInicio.Value.Date).Days;
				precioCalculado = (precioPorNoche* totalDias);
				return precioCalculado;
			}
			catch (Exception ex){throw ex;}
		}
		private void SeleccionHabitacionParaReserva_Load(object sender, EventArgs e)
		{
			onSuccess();
		}
		private void cargarComboRegimenes() {
			try
			{
				//Vaciar comboBox
				cbxTipoRegimen.DataSource = null;
				Regimen regimen = new Regimen();
				List<Regimen> listita = new List<Regimen>();
				//Usuario Recepcionista
				if (Usuario.Instance.rol_id == 2) { 
					listita= regimen.getRegimenes(Usuario.Instance.hotel_id);
				}
				//Usuario Guest
				else if(Usuario.Instance.rol_id == 3)
				{
					listita = regimen.getRegimenes(cbxHotel.SelectedIndex);
				}

				//Asignar la propiedad DataSource
				//Indicar qué propiedad se verá en la lista
				this.cbxTipoRegimen.DisplayMember = "regimen_Descripcion";
				//Indicar qué valor tendrá cada ítem
				this.cbxTipoRegimen.ValueMember = "regimen_Id";
				regimen.regimen_Id = 5;
				regimen.regimen_Descripcion= "Sin especificar";
				listita.Add(regimen);
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
				listita.Add(new Hotel(0, "Seleccione un hotel"));
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
				if (chequearDatos()) { 
				if (cbxTipoRegimen.SelectedIndex == 0)
				{
					showToolTip("Seleccione un regimen.", cbxTipoRegimen, cbxTipoRegimen.Location);
				}
				else
				{
					if (dgvHabitaciones.CurrentCell.ColumnIndex == 0)
					{
						var row = dgvHabitaciones.CurrentRow;
						int nroHab = Convert.ToInt32(row.Cells[1].Value);
						//nroHab = Convert.ToInt32(row.Cells[1].Value);
						Habitacion habitacion = new Habitacion();
						int tipoRegimen = cbxTipoRegimen.SelectedIndex;
						if (Usuario.Instance.rol_id == 3)
						{
							if (cbxHotel.SelectedIndex > 0)
							{
								txtPrecioCalculado.Text = habitacion.getPrecioHabitacionPorNoche(
								cbxHotel.SelectedIndex,
								nroHab, int.Parse(cantHuespedes.Text), tipoRegimen)
								.ToString();
							}
							else
							{
								showToolTip("Seleccione un hotel.", cbxHotel, cbxHotel.Location);

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
						txtTipoHabitacion.Text = Convert.ToString(row.Cells[2].Value);
						txtTipoHabitacion.ReadOnly = true;
						txtDescripcion.Text = Convert.ToString(row.Cells[3].Value);
						txtDescripcion.ReadOnly = true;
						cargarComboDocumentosTipo();
						this.pnlConfirmarReserva.Visible = true;
					}
				}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void onSuccess() {
			this.pnlHabitacionesDisponibles.Visible = false;
			this.pnlConfirmarReserva.Visible = false;
			pnlListadoHotel.Visible = false;
			btnGenerarReservas.Visible = false;
			txtMaskIdentif.Text = "";
			txtMailCliente.Text = "";
			if (Usuario.Instance.rol_id == 3)
			{
				cargarComboHoteles();
				pnlListadoHotel.Visible = true;
			}
			else
			{
				pnlListadoHotel.Visible = false;
			}

		}
		//Generar reserva
		private void btnGenerarReservas_Click_1(object sender, EventArgs e)
		{
			try
			{
				if (chequearDatos())
				{
					Reserva reserva = new Reserva();
					reserva.reserva_fechaInicio = fechaInicio.Value;
					reserva.reserva_fechaFin = fechaFin.Value;
					reserva.reserva_cantDias = int.Parse(cantDias.Value.ToString());
					reserva.reserva_tipoHabitacion = int.Parse(txtTipoHabitacion.Text);
					reserva.reserva_tipoRegimen = cbxTipoRegimen.SelectedIndex;
					//
					reserva.reserva_valor = decimal.Parse(txtPrecioFinalCalculado.Text);
					var row = dgvCliente.CurrentRow;
					reserva.reserva_clienteIdentificacion = Convert.ToDecimal(row.Cells[0].Value); //decimal.Parse(txtClienteIdentificacion.Text);
					reserva.reserva_clienteMail = Convert.ToString(row.Cells[1].Value);
					reserva.reserva_habitacionNro = int.Parse(txtNroHabitacion.Text);
					reserva.reserva_cantHuespedes = int.Parse(cantHuespedes.Value.ToString());
					reserva.reserva_usuario = Usuario.Instance.usuarioXHotel_usuario;
					//		hotelId = Usuario.Instance.hotel_id;
					int resultado = reserva.addReserva(reserva);
					if (resultado > 0)
					{
						MessageBox.Show("Se generó el siguiente código de reserva: " + resultado, "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						onSuccess();
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
		private void btnBuscarCliente_Click(object sender, EventArgs e)
		{
			try
			{
				if (chequearDatosCliente()) {
					Cliente cliente = new Cliente();
					cliente = cliente.GetCliente(int.Parse(txtMaskIdentif.Text), txtMailCliente.Text);
					if (cliente == null) {
						MessageBox.Show("No existe un cliente con los datos ingresados", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						txtMaskIdentif.Text = "";
						txtMailCliente.Text = "";
					}
					else
					{
						txtMaskIdentif.Text = cliente.cliente_identificacion.ToString();
						txtMailCliente.Text = cliente.cliente_email;
						cargarGridCliente(cliente);
					}
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
				btnGenerarReservas.Visible = false;
				List<Cliente> clientes = new List<Cliente>();
				clientes.Add(cliente);
				dgvCliente.Columns.Clear();
				dgvCliente.DataSource = null;
				//AddButtonColumn();
				dgvCliente.DataSource = clientes;//seleccionHabitacionParaReservas;
				if (clientes.Count == 1) {
					btnGenerarReservas.Visible = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnRegistrarNuevo_Click(object sender, EventArgs e)
		{
			try
			{
				AbmCliente.AgregarCliente agregar = new AbmCliente.AgregarCliente();
				//agregar.DialogResult();
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
		private bool chequearDatosCliente() {
			if (cbxDocumentosTipo.SelectedIndex == 0)
			{
				showToolTip("Seleccione una el tipo de documento.", cbxDocumentosTipo, cbxDocumentosTipo.Location);
				return false;
			}
			if (txtMaskIdentif.Text.Trim() == "") {
				showToolTip("Ingrese una identificacion.", txtMaskIdentif, txtMaskIdentif.Location);
				return false;
			}
			if (txtMailCliente.Text.Trim() == "") {
				showToolTip("Ingrese un mail.", txtMailCliente, txtMailCliente.Location);
				return false;
			}
			return true;
		}
		private bool chequearDatosUsuarioGuest() {
			
			if (cbxHotel.SelectedIndex == 0)
			{
				showToolTip("Ingrese un hotel.", cbxHotel, cbxHotel.Location);
				return false;
			}
			return true;
		}
		private bool chequearDatos()
		{
			if (fechaInicio.Value == null)
			{
				showToolTip("Seleccione una fecha de Inicio", fechaInicio, fechaInicio.Location);
				return false;
			}
			if (fechaFin.Value == null)
			{
				showToolTip("Seleccione una fecha de Fin", fechaFin, fechaFin.Location);
				return false;
			}
			if (fechaInicio.Value.CompareTo(fechaFin.Value) >= 0)
			{
				showToolTip("Seleccione un rango de fechas válido", fechaFin, fechaFin.Location);
				return false;
			}
			if (textFecha.Value.CompareTo(fechaInicio.Value) >= 0)
			{
				showToolTip("Seleccione un rango de fechas válido", fechaInicio, fechaInicio.Location);
				return false;
			}
			if (cantDias.Text.Trim() == ""|| cantDias.Text.Trim() == "0")
			{
				showToolTip("Ingrese la cantidad de dias", cantDias, cantDias.Location);
				return false;
			}
			if (cantHuespedes.Text.Trim() == "" || cantHuespedes.Value == 0)
			{
				showToolTip("Ingrese la cantidad de huespedes", cantHuespedes, cantHuespedes.Location);
				return false;
			}
			if (cantHuespedes.Value > 6)
			{
				showToolTip("La cantidad máxima por habitacion 6, caso contrario realice dos o más reservas", cantHuespedes, cantHuespedes.Location);
				return false;
			}
			return true;
		}
		private void showToolTip(string msj, Control ventana, Point pos)
		{
			ToolTip toolTip = new ToolTip();
			toolTip.Hide(ventana);
			toolTip.SetToolTip(ventana, "Entrada Invalida");
			toolTip.Show(msj, ventana, 50, 10, 5000);
		}
	}

}
