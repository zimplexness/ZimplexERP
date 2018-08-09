using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLayer.Controller;
using Entidades;


namespace ErpGestion
{
    public partial class ActividadMantenimientoForm : MetroFramework.Forms.MetroForm
    {
        private readonly MantenimientoVehiculoController mantenimiento;
        public ActividadMantenimientoForm()
        {
            InitializeComponent();
            mantenimiento = new MantenimientoVehiculoController();
        }

        private void ActividadVehiculoForm_Load(object sender, EventArgs e)
        {

           
            

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            metroTextBoxActividad.Clear();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ActividadMantenimiento actividad=new ActividadMantenimiento();
            actividad.Detalle = metroTextBoxActividad.Text;
            mantenimiento.AddActividadMantenimiento(actividad);
            MessageBox.Show("Actividad Agregada con exito", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
