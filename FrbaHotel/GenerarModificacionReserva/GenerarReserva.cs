using FrbaHotel.FrbaHotelModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class GenerarReserva : FrbaHotel.Form1
    {
        public GenerarReserva()
        {
            InitializeComponent();
        }

        private void GenerarReserva_Load(object sender, EventArgs e)
        {

            cargarComboRegimen();
        }
        private void cargarComboRegimen() {
            try
            {   //Vaciar comboBox
                this.cbxTipoRegimen.DataSource = null;
                Regimen regimen = new Regimen();
                //Asignar la propiedad DataSource
                this.cbxTipoRegimen.DataSource = regimen.getRegimenes("administrador");
                //Indicar qué propiedad se verá en la lista
                this.cbxTipoRegimen.DisplayMember = "regimen_Descripcion";
                //Indicar qué valor tendrá cada ítem
                this.cbxTipoRegimen.ValueMember = "regimen_Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void agregarEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                //Usuario.Instance.rol_nombre == "Administrador";
                if (fechaInicio.Text.Trim() == "" | cantDias.Text.Trim() == "")
                {
                    MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                    Reserva reserva = new Reserva();
                    //regimen.regimen_Descripcion = descripcion.Text;
                    //regimen.regimen_precioBase = decimal.Parse(precioBase.Text);
                    //if (regimen.addRegimen(regimen) == 0)
                    //{
                    //    //Retorno un mensaje de error, fallo la insercion
                    //    MessageBox.Show("Falló la actualizacion del regimen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //}

                    this.limpiarCuadrosDeTexto();
                   // ABM_Regimen vpr = new ABM_Regimen();
                    this.Hide();
                    //vpr.ShowDialog();
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void limpiarCuadrosDeTexto()
        {
            //descripcion.Text = "";
            //precioBase.Text = "";

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboHabit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
