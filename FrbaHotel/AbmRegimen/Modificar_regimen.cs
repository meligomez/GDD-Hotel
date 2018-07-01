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
    public partial class Modificar_regimen : FrbaHotel.Form1
    {
        public int _idRegimen { get; set; }
        public string rol { get; set; }
        public Modificar_regimen(int idRegimen)
        {
            this._idRegimen = idRegimen;
            rol = "administrador";
            InitializeComponent();
        }

        private void Modificar_regimen_Load(object sender, EventArgs e)
        {
            try
            {
                Regimen regimen = new Regimen();
                regimen = regimen.GetRegimenById(_idRegimen);
                _idRegimen = regimen.regimen_Id;
                descripcion.Text = regimen.regimen_Descripcion;
                precioBase.Text = regimen.regimen_precioBase.ToString();
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                throw;
            }
            
        }

        private void modificarRegimen_Click(object sender, EventArgs e)
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
                    regimen.regimen_Id = _idRegimen;
                    regimen.regimen_Descripcion = descripcion.Text;
                    regimen.regimen_precioBase = decimal.Parse(precioBase.Text);
                    if (regimen.UpdateRegimen(regimen) == 0)
                    {
                        //Retorno un mensaje de error, fallo la insercion
                        MessageBox.Show("Falló la actualizacion del regimen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    this.limpiarCuadrosDeTexto();
                    Listar_Regimen vpr = new Listar_Regimen();
                    this.Hide();
                    vpr.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                throw;
            }
        }
        private void limpiarCuadrosDeTexto()
        {
            descripcion.Text = "";
            precioBase.Text = "";

        }
    }
}
