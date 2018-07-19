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
    public partial class AdminCuentaCorrienteForm : MetroFramework.Forms.MetroForm
    {
        public AdminCuentaCorrienteForm()
        {
            InitializeComponent();
        }

        private void AdminCuentaCorrienteForm_Load(object sender, EventArgs e)
        {
            bindingSourceCuenta.DataSource = new ProveedorManager().GetCuentasCorrientes();

            IEnumerable<CuentasCorrientes> cuentas = new ProveedorManager().GetCuentasCorrientes();

            metroGridCuenta.AutoGenerateColumns = false;
            metroGridCuenta.DataSource = cuentas;
            metroGridCuenta.AutoSize = false;

            foreach (var item in cuentas)
            {
                Nombre.DataPropertyName = "Nombre";
                Razon.DataPropertyName = "Razon";
                Cuit.DataPropertyName = "Cuit";
                NumeroCuenta.DataPropertyName = "NumeroCuenta";
                Vencimiento.DataPropertyName = "Vencimiento";
                Comentario.DataPropertyName = "Comentario";
              


            }


        }

        private void metroGridFiltrarProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBoxFiltro.Text=="")
            {
                bindingSourceCuenta.DataSource = new ProveedorManager().GetCuentasCorrientes();
            }
            else {
                metroGridCuenta.DataSource = new ProveedorManager().filtroCuentasCorrientes(metroTextBoxFiltro.Text);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CuentaCorrienteForm CRORRIENTE = new CuentaCorrienteForm();
            CRORRIENTE.ShowDialog();
        }

        private void metroGridCuenta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            CuentaCorrienteForm frmcuenta= new CuentaCorrienteForm();
            frmcuenta.Cuit = metroGridCuenta.CurrentRow.Cells["Cuit"].Value.ToString();
            frmcuenta.FormClosed += frmcuenta_FormClosed;
           
            frmcuenta.Show();
        }

        private void frmcuenta_FormClosed(object sender,FormClosedEventArgs e) {

            Form frm = sender as Form;
            if (frm.DialogResult==DialogResult.OK)
            {
                bindingSourceCuenta.DataSource = new ProveedorManager().GetCuentasCorrientes();

                IEnumerable<CuentasCorrientes> cuentas = new ProveedorManager().GetCuentasCorrientes();

                metroGridCuenta.AutoGenerateColumns = false;
                metroGridCuenta.DataSource = cuentas;
                metroGridCuenta.AutoSize = false;

                foreach (var item in cuentas)
                {
                    Nombre.DataPropertyName = "Nombre";
                    Razon.DataPropertyName = "Razon";
                    Cuit.DataPropertyName = "Cuit";
                    NumeroCuenta.DataPropertyName = "NumeroCuenta";
                    Vencimiento.DataPropertyName = "Vencimiento";
                    Comentario.DataPropertyName = "Comentario";



                }
            }
        }

        private void metroButtonAgregarPago_Click(object sender, EventArgs e)
        {
            bindingSourceCuenta.DataSource = new ProveedorManager().GetCuentasCorrientes();

            IEnumerable<CuentasCorrientes> cuentas = new ProveedorManager().GetCuentasCorrientes();

            metroGridCuenta.AutoGenerateColumns = false;
            metroGridCuenta.DataSource = cuentas;
            metroGridCuenta.AutoSize = false;

            foreach (var item in cuentas)
            {
                Nombre.DataPropertyName = "Nombre";
                Razon.DataPropertyName = "Razon";
                Cuit.DataPropertyName = "Cuit";
                NumeroCuenta.DataPropertyName = "NumeroCuenta";
                Vencimiento.DataPropertyName = "Vencimiento";
                Comentario.DataPropertyName = "Comentario";



            }
        }
    }
}
