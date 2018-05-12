using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErpGestion
{
    public partial class ZimplexHome : Form
    {
        public ZimplexHome()
        {
            InitializeComponent();
        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonPanel5_Click(object sender, EventArgs e)
        {
            




        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {

            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ProveedoresFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form proveedorfrm = new ProveedoresFrm();
            proveedorfrm.MdiParent = this;
            proveedorfrm.Show();

        }

        private void ribbonButtonComprobantes_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ComprobantesFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form comprobantesfrm = new ComprobantesFrm();
            comprobantesfrm.MdiParent = this;
            comprobantesfrm.Show();
        }

        private void ribbonButtonPagos_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(PagosFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form pagosfrm = new PagosFrm();
            pagosfrm.MdiParent = this;
            pagosfrm.Show();
        }

        private void ribbonButtonConsultas_Click(object sender, EventArgs e)
        {
            
        }

        private void ribbonButtonProductos_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ProductosFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form prodfrm = new ProductosFrm();
            prodfrm.MdiParent = this;
            prodfrm.Show();
        }

        private void ribbonButtonEmpleados_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(EmpleadoForm))
                {
                    f.Activate();
                    return;
                }
            }
            Form empleadofrm = new EmpleadoForm();
            empleadofrm.MdiParent = this;
            empleadofrm.Show();
        }

        private void ribbonButtonTaller_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(TallerFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form tallerform = new TallerFrm();
            tallerform.MdiParent = this;
            tallerform.Show();
        }

        private void ribbonButtonVechiculo_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(VehiculosFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form vehiculoform = new VehiculosFrm();
            vehiculoform.MdiParent = this;
            vehiculoform.Show();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(LocalidadesFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form localidadform = new LocalidadesFrm();
            localidadform.MdiParent = this;
            localidadform.Show();
        }

        private void ribbonButtonConsultaComprobantes_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ConsultasComprobantesFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form consultas = new ConsultasComprobantesFrm();
            consultas.MdiParent = this;
            consultas.Show();
        }

        private void Ingresar_DoubleClick(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(LocalidadesFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form localidafrm = new LocalidadesFrm();
            localidafrm.MdiParent = this;
            localidafrm.Show();

        }

        private void ribbonButtonProvincia_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ProvinciaFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form provinciaform = new ProvinciaFrm();
            provinciaform.MdiParent = this;
            provinciaform.Show();

        }

        private void ribbonButtonBuscar_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(ProveedoresFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form proveedorfrm = new ProveedoresFrm();
            proveedorfrm.MdiParent = this;
            proveedorfrm.Show();

        }

        private void PolizaButton_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(PolizaSeguroFrm))
                {
                    f.Activate();
                    return;
                }
            }
            Form polizaform = new PolizaSeguroFrm();
            polizaform.MdiParent = this;
            polizaform.Show();
        }
    }
}
