using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLayer;

namespace ErpGestion
{
    public partial class MantenimientoForm : MetroFramework.Forms.MetroForm
    {
        VehiculosManager Vehiculos;
        TallerManager taller;
        public MantenimientoForm()
        {
            InitializeComponent();
            Vehiculos = new VehiculosManager();
            taller = new TallerManager();
        }

        private void MantenimientoForm_Load(object sender, EventArgs e)
        {
            //vehiculo
            metroComboBoxVehiculo.DataSource = Vehiculos.listaVehiculosActivos();
            metroComboBoxVehiculo.DisplayMember = "Patente";
            metroComboBoxVehiculo.ValueMember = "IDVehiculo";
            //actividades
            metroComboBoxActividad.DataSource = Vehiculos.GetActividadMantenimientos();
            metroComboBoxActividad.DisplayMember = "Detalle";
            metroComboBoxActividad.ValueMember = "IDActividadMantenimiento";

            //taller
           
            metroComboBoxTaller.DataSource = taller.TalleresMecanicos();
            metroComboBoxTaller.DisplayMember = "NombreTaller";
            metroComboBoxTaller.ValueMember = "IDTalleres";
            //Chofer
            metroComboBoxEMPLEADO.DataSource = Vehiculos.Choferes();
            metroComboBoxEMPLEADO.DisplayMember = "Chofer";
            metroComboBoxEMPLEADO.ValueMember = "IDEmpleado";



        }

        private void metroComboBoxTaller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonAgregarPago_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LBLKM.Text))
            {
                MessageBox.Show("Error, Debe agregar el Kilometraje","Sistema Gestion",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
            else
            {
                Vehiculos.InsertarMantenimiento(metroDateTimeFECHA.Value,(int)metroComboBoxVehiculo.SelectedValue,
                int.Parse(metroTextBoxKm.Text),(int)metroComboBoxEMPLEADO.SelectedValue,(int)metroComboBoxTaller.SelectedValue,
                (int)metroComboBoxActividad.SelectedValue,metroTextBoxcomentario.Text
                    );
                MessageBox.Show("Se ha ingresado con exito","Sistema de gestion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                metroTextBoxKm.Clear();
                metroTextBoxcomentario.Clear();
                
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
