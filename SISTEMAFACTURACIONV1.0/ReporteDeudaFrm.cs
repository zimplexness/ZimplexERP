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
    public partial class ReporteDeudaFrm : MetroFramework.Forms.MetroForm
    {
        public ReporteDeudaFrm()
        {
            InitializeComponent();
        }
        public int idproveedor { get; set; }
        private void ReporteDeuda_Load(object sender, EventArgs e)
        {

            

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            PagosManager p = new PagosManager();
            EncabezadoDeuda_ResultBindingSource.DataSource = p.EncabezadpDeuda(idproveedor);
            FacturasPendientesPago_ResultBindingSource.DataSource = p.ListFacturasPendientesPago(idproveedor);


            this.reportViewer1.RefreshReport();

        }
    }
}
