using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories;

namespace ErpGestion
{
    public partial class FindProvinciasFrm : MetroFramework.Forms.MetroForm
    {

        private IFindProvincia _caller;


        public FindProvinciasFrm(IFindProvincia caller)
        {
            InitializeComponent();
            _caller = caller;
        }

        private void FindProvinciasFrm_Load(object sender, EventArgs e)
        {
            metroGridProvincias.AutoGenerateColumns = false;
            metroGridProvincias.DataSource = ProvinciaRepository.GetAllProvincias();
            
        }
    }
}
