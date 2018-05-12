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
    public partial class ProductosFrm : MetroFramework.Forms.MetroForm
    {
        public ProductosFrm()
        {
            InitializeComponent();
        }

        public int idarticuloupdate { get; set; }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            ArticuloManager a = new ArticuloManager();
            bindingSourceProductos.DataSource = a.ListarArticulos();
            metroGridProductos.DataSource = bindingSourceProductos;
            metroComboBoxCategoria.DataSource = a.Categorias();
            metroComboBoxCategoria.DisplayMember = "Categoria";
            metroComboBoxCategoria.ValueMember = "IDCategoria";



            metroComboBoxUbicacion.DataSource = a.ListarUbicacion();
            metroComboBoxUbicacion.DisplayMember = "Ubicacion1";
            metroComboBoxUbicacion.ValueMember = "IdUbicacion";

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(metroTextBoxProducto.Text) == true)
                {
                    MessageBox.Show("Debe insertar al menos el nombre del articulo", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }




                else
                {
                    ArticuloManager a = new ArticuloManager();

                    if (a.ValidateArticulo(metroTextBoxProducto.Text) == 1)
                    {
                        MessageBox.Show("Ya existe un articulo con el mismo nombre", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        a.InsertarArticulos(int.Parse(metroComboBoxCategoria.SelectedValue.ToString()), int.Parse(metroComboBoxUbicacion.SelectedValue.ToString()),
                                            metroTextBoxProducto.Text, metroTextBoxDescripcion.Text, metroTextBoxCodigo.Text,
                                            float.Parse(metroTextBoxIva.Text.Replace(".", ",")));

                        MessageBox.Show("El articulo se ingreso con exito", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroGridProductos.DataSource = new ArticuloManager().ListarArticulos();
                        metroTextBoxProducto.Clear();
                        metroTextBoxDescripcion.Clear();
                        metroTextBoxCodigo.Clear();
                        metroTextBoxIva.Clear();
                        metroTextBoxProducto.Focus();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloManager artmanager = new ArticuloManager();
                int idarticulo = int.Parse(metroGridProductos.CurrentRow.Cells["IDArticulo"].Value.ToString());

                if (artmanager.EliminarArticulo(idarticulo) == 1)
                {
                    MessageBox.Show("El Articulo se elimino con exito");
                    metroGridProductos.DataSource = artmanager.ListarArticulos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ArticuloManager a = new ArticuloManager();
            Articulos art = new Articulos();
            art = a.EncontrarArticulo(int.Parse(metroGridProductos.CurrentRow.Cells["IDArticulo"].Value.ToString()));

            metroTextBoxProducto.Text = art.Nombre;
            metroTextBoxDescripcion.Text = art.Descripcion;
            metroTextBoxCodigo.Text = art.Codigo;
            idarticuloupdate = art.IDArticulo;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloManager artmanager = new ArticuloManager();
                int idarticulo = int.Parse(metroGridProductos.CurrentRow.Cells["IDArticulo"].Value.ToString());

                if (artmanager.EliminarArticulo(idarticulo) == 1)
                {
                    MessageBox.Show("El Articulo se elimino con exito");
                    metroGridProductos.DataSource = artmanager.ListarArticulos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(metroTextBoxProducto.Text) == true)
                {
                    MessageBox.Show("Debe insertar al menos el nombre del articulo", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }




                else
                {
                    ArticuloManager a = new ArticuloManager();

                    if (a.ValidateArticulo(metroTextBoxProducto.Text) == 1)
                    {
                       DialogResult dialogResult= MessageBox.Show("Ya existe un articulo con el mismo nombre, Desea Actualizarlo?", "Sistema de Gestion de Compras", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dialogResult==DialogResult.Yes)
                        {
                            //metodo actualizar productos

                        }
                    }
                    else
                    {
                        a.InsertarArticulos(int.Parse(metroComboBoxCategoria.SelectedValue.ToString()), int.Parse(metroComboBoxUbicacion.SelectedValue.ToString()),
                                            metroTextBoxProducto.Text, metroTextBoxDescripcion.Text, metroTextBoxCodigo.Text,
                                            float.Parse(metroTextBoxIva.Text.Replace(".", ",")));

                        MessageBox.Show("El articulo se ingreso con exito", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroGridProductos.DataSource = new ArticuloManager().ListarArticulos();
                        metroTextBoxProducto.Clear();
                        metroTextBoxDescripcion.Clear();
                        metroTextBoxCodigo.Clear();
                        metroTextBoxIva.Clear();
                        metroTextBoxProducto.Focus();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            metroGridProductos.DataSource = new ArticuloManager().FiltrarArticulos(metroTextBoxFiltroNombre.Text);
        }
    }
}
