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
    public partial class ActividadVehiculoForm : MetroFramework.Forms.MetroForm
    {
        public ActividadVehiculoForm()
        {
            InitializeComponent();
        }

        private void ActividadVehiculoForm_Load(object sender, EventArgs e)
        {

            bindingSourceActividadesVehiculo.DataSource = new VehiculosManager().GetActividades();
            

        }
    }
}
