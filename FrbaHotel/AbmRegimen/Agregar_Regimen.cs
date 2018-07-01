using FrbaHotel.FrbaHotelModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.AbmRegimen
{
    public partial class Agregar_Regimen : FrbaHotel.Form1
    {
        public string rol { get; set; }
        public Agregar_Regimen()
        {
            rol = "administrador";
            InitializeComponent();
        }

        private void agregarEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                if (descripcion.Text.Trim() == "" | precioBase.Text.Trim() == "")
                {

                    MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (rol != "administrador")
                {
                    MessageBox.Show("Sólo el rol administrador puede registrar un regimen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Regimen regimen = new Regimen();
                    regimen.regimen_Descripcion = descripcion.Text;
                    regimen.regimen_precioBase = decimal.Parse(precioBase.Text);
                    if (regimen.addRegimen(regimen) == 0)
                    {
                        //Retorno un mensaje de error, fallo la insercion
                        MessageBox.Show("Falló la actualizacion del regimen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }

                    this.limpiarCuadrosDeTexto();
                    ABM_Regimen vpr = new ABM_Regimen();
                    this.Hide();
                    vpr.ShowDialog();
                }

            }
            catch (Exception)
            {

                throw;
            }
            

        }
        private void limpiarCuadrosDeTexto()
        {
            descripcion.Text = "";
            precioBase.Text = "";
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }
    }
}
