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
using Entidades;


namespace ErpGestion
{
    public partial class AdminActividadesMantenimientoForm : MetroFramework.Forms.MetroForm
    {
        VehiculosManager VehiculosManager;
        public AdminActividadesMantenimientoForm()
        {
            InitializeComponent();
            VehiculosManager = new VehiculosManager();

        }

        private void AdminActividadesMantenimientoForm_Load(object sender, EventArgs e)
        {
            bindingSourceActividad.DataSource = VehiculosManager.GetActividadMantenimientos() ;

           

            metroGridActividad.AutoGenerateColumns = false;
            metroGridActividad.DataSource = bindingSourceActividad;
            metroGridActividad.AutoSize = false;

          
            foreach (var item in bindingSourceActividad)
            {
                IdActividad.DataPropertyName = "IDActividadMantenimiento";
                Actividades.DataPropertyName = "Detalle";



            }
        }
    }
}
