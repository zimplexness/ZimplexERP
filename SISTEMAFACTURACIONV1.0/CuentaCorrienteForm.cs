using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLayer;

namespace ErpGestion
{
    public partial class CuentaCorrienteForm : MetroFramework.Forms.MetroForm
    {
        public string Cuit { get; set; }
        
        CuentasCorrientes Cuenta = new CuentasCorrientes();

        public CuentaCorrienteForm()
        {
            InitializeComponent();
            
           
        }

         private void CuentaCorrienteForm_Load(object sender, EventArgs e)
        {



            Cuenta = new ProveedorManager().GetCuentaCorrienteByCuit(Cuit);
            if (Cuenta!=null)
            {
                metroTextBoxNOMBRE.Text = Cuenta.Nombre;
                metroTextBoxCUENTA.Text = Cuenta.NumeroCuenta;
                metroTextBoxVencimiento.Text = Cuenta.Vencimiento.ToString();
                metroTextBoxComentario.Text = Cuenta.Comentario;

            }

            //autocomplete textbox con proveedores

            ProveedorManager p = new ProveedorManager();

            AutoCompleteStringCollection sourcename = new AutoCompleteStringCollection();
            sourcename.AddRange(p.listarNombreProveedores().ToArray());
            metroTextBoxNOMBRE.AutoCompleteMode = AutoCompleteMode.Suggest;
            metroTextBoxNOMBRE.AutoCompleteSource = AutoCompleteSource.CustomSource;
            metroTextBoxNOMBRE.AutoCompleteCustomSource = sourcename;





        }
        public CuentaCorrienteForm(CuentasCorrientes cuenta)
        {
            this.Cuenta = cuenta;

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButtonAgregarPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(metroTextBoxNOMBRE.Text)|| string.IsNullOrEmpty(metroTextBoxCUENTA.Text)||
                    string.IsNullOrEmpty(metroTextBoxVencimiento.Text)


                    )
                {
                    MessageBox.Show("Error, Debe Insertar los Datos");
                }
                else
                {
                    int idproveedor= new ProveedorManager().DevolverIdPRoveedorporNombre(metroTextBoxNOMBRE.Text);
                    CuentaCorriente cuenta = new CuentaCorriente();
                    cuenta.IDProveedor = idproveedor;
                    cuenta.Nombre = metroTextBoxCUENTA.Text;
                    cuenta.Comentario = metroTextBoxComentario.Text;
                    cuenta.Vencimiento =int.Parse(metroTextBoxVencimiento.Text);
                    new ProveedorManager().InsertarorUpdateCuentaCorriente(cuenta);
                    MessageBox.Show("Insertado o Actualizado con Exito");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    
                   
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
