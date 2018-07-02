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
		public int habitacion_numero { get; set; }
		public int habitacion_codigo { get; set; }
		public SeleccionHabitacionParaReserva()
		{
			InitializeComponent();
		}
		public SeleccionHabitacionParaReserva(int habitacionNumero, int habitacionCodigo)
		{
			this.habitacion_numero = habitacionNumero;
			this.habitacion_codigo = habitacion_codigo;
		}

		private void buscarHabitacion_Click(object sender, EventArgs e)
		{
			try
			{
				//Usuario.Instance.rol_nombre == "Administrador";
				if (fechaInicio.Text.Trim() == ""
					|| cantDias.Text.Trim() == "" || cantHuespedes.Text.Trim() == ""
					|| cantDias.Text.Trim() == "0" || cantHuespedes.Text.Trim() == "0")
				{
					MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				Habitacion habitacion = new Habitacion();
				List<Habitacion> habitacions = new List<Habitacion>();
				
				habitacions = habitacion
					.getHabitacionesDisponibles(
					Usuario.GetUserLogeado(), 
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
		public void cargarGrid(List<Habitacion>	habitacions) {
			try
			{
				//List<SeleccionHabitacionParaReserva> seleccionHabitacionParaReservas = new List<SeleccionHabitacionParaReserva>();
				
				//foreach (var item in habitacions)
				//{
				//	seleccionHabitacionParaReservas.Add(new SeleccionHabitacionParaReserva(
				//		habitacion_codigo = item.habitacion_codigo,
				//		habitacion_numero = item.habitacion_numero
				//		));
				//}
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
		private void dgvHabitaciones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (dgvHabitaciones.CurrentCell.ColumnIndex == 0)
				{					
					var row = dgvHabitaciones.CurrentRow;
					int nroHab = Convert.ToInt32(row.Cells[1].Value);
					nroHab= Convert.ToInt32(row.Cells[1].Value);
					Habitacion habitacion = new Habitacion();
					int idRegimen = cbxTipoRegimen.SelectedIndex;
					if (idRegimen == 0) {
						idRegimen = 0;
					}
					txtPrecioCalculado.Text= habitacion.getPrecioHabitacionPorNoche(
					Usuario.Instance.hotel_id,nroHab, int.Parse(cantHuespedes.Text), idRegimen)
					.ToString();
					//txtPrecioCalculado.Text = "500.00";
					txtPrecioFinalCalculado.Text = this.calcularPrecionTotalHabitacion(decimal.Parse(txtPrecioCalculado.Text)).ToString();
					//f.total = Convert.ToDecimal(row.Cells[7].Value);
					txtPrecioCalculado.ReadOnly = true;
					txtPrecioFinalCalculado.ReadOnly = true;
					this.pnlConfirmarReserva.Visible = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//private void ClickEnBoton(object sender, DataGridViewCellEventArgs e)
		//{
		//	try
		//	{
		//		if (dgvHabitaciones.CurrentCell.ColumnIndex == 7)
		//		{
		//			var row = dgvHabitaciones.CurrentRow;
		//			Factura f = new Factura();
		//			Cliente cli = new Cliente();
		//			f.codFactura = Convert.ToInt32(row.Cells[1].Value);
		//			f.empresa_id = Convert.ToInt32(row.Cells[3].Value);
		//			f.fechaAlta = Convert.ToDateTime(row.Cells[5].Value);
		//			f.fechaVenc = Convert.ToDateTime(row.Cells[6].Value);
		//			f.total = Convert.ToDecimal(row.Cells[7].Value);
		//			FacturaAPagar fap = new FacturaAPagar(f, sucursalF);
		//			fap.Show();

		//			// dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}


		//}

	}
}
