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

namespace ErpGestion
{
    public partial class AdminMantenimientoVehiculoForm : MetroFramework.Forms.MetroForm
    {
        private readonly MantenimientoVehiculoController mantenimientoVehiculo;
        public AdminMantenimientoVehiculoForm()
        {
            InitializeComponent();
            mantenimientoVehiculo = new MantenimientoVehiculoController();
        }

        private void AdminMantenimientoVehiculoForm_Load(object sender, EventArgs e)
        {
            metroGridMantenimientos.DataSource = mantenimientoVehiculo.GetMantenimientos();

        }
    }
}
