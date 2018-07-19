using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BLayer.Controller;

namespace ErpGestion
{
    public partial class PadronForm : MetroFramework.Forms.MetroForm
    {
        
        public String FileLocation { get; set; }
        public PadronForm()
        {
            InitializeComponent();
        }

        private void PadronForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                FileLocation = dialog.FileName;
            }
        }

        private void metroButtonImportar_Click(object sender, EventArgs e)
        {
           
                if (FileLocation!=null)
                {
                    ImportarPadron import = new ImportarPadron();
                    import.StreamReader = FileLocation;
                    import.ImportarPadronMethod();
                    MessageBox.Show("Importación OK","Sistema de Gestion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

           
        }
    }
}
