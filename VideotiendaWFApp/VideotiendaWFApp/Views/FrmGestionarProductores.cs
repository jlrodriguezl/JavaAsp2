using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideotiendaWFApp.Models;

namespace VideotiendaWFApp.Views
{
    public partial class FrmGestionarProductores : Form
    {
        PRODUCTORES oProductores = null;
        private string idProductor;
        private string nomProductor;
            

        public FrmGestionarProductores(string idProductor, string nomProductor)
        {
            InitializeComponent();

            this.idProductor = idProductor;
            this.nomProductor = nomProductor;

            if (!string.IsNullOrEmpty(this.idProductor) && !string.IsNullOrEmpty(this.nomProductor))
            {
                cargarDatos();
            }
        }
        private void cargarDatos()
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                oProductores = db.PRODUCTORES.Find(idProductor, nomProductor);
                txtTipo.Text = oProductores.NOM_PROD;
            }
        }
        private void FrmGestionarProductores_Load(object sender, EventArgs e)
        {

        }
    }
}
