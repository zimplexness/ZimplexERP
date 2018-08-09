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
    public partial class RubroForm : MetroFramework.Forms.MetroForm
    {

        public int  Rubro{ get; set; }
        RubroProveedor RubroProveedor;
        
        public RubroForm()
        {
            InitializeComponent();
            this.RubroProveedor = new RubroProveedor();
        }

        private void RubroForm_Load(object sender, EventArgs e)
        {
            RubroProveedor = new ProveedorManager().GetRubroByID(Rubro);
            if (RubroProveedor!=null)
            {
                metroTextBoxID.Text = RubroProveedor.IDRubroProveedor.ToString();
                metroTextBoxDescripcion.Text = RubroProveedor.Descripcion;
            }
            else
            {
                metroTextBoxID.Text = "0";
                metroTextBoxDescripcion.Text = "";

            }
        }

        private void metroButtonAgregarPago_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroTextBoxDescripcion.Text))
            {
                MessageBox.Show("Error, Debe Insertar los Datos");
            }
            else
            {
                
                this.RubroProveedor.IDRubroProveedor = int.Parse(metroTextBoxID.Text);
                this.RubroProveedor.Descripcion = metroTextBoxDescripcion.Text;
                new ProveedorManager().InsertarorUpdateRubro(RubroProveedor);
                MessageBox.Show("Insertado con Exito");
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}
