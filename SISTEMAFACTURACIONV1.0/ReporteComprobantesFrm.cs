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
    public partial class ReporteComprobantesFrm : MetroFramework.Forms.MetroForm
    {
        public ReporteComprobantesFrm()
        {
            InitializeComponent();
        }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin{ get; set; }

        private void ReporteComprobantesForm_Load(object sender, EventArgs e)
        {
            try
            {
                ComprobantesManager CManager = new ComprobantesManager();
                ProveedorManager p = new ProveedorManager();



                ComprobantesGastos_Compras_ResultBindingSource.DataSource = CManager.ListarFacturasComprasGastos(FechaInicio, FechaFin);
                this.reportViewer1.RefreshReport();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
