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
    public partial class FrmProductores : Form
    {
        public FrmProductores()
        {
            InitializeComponent();
        }

#region Helper

        public void refrescarTabla()
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                var lstProductores = from p in db.PRODUCTORES
                                    select p;

                grDatos.DataSource = lstProductores.ToList();
            }
        }

#endregion

        private void FrmProductores_Load(object sender, EventArgs e)
        {
            refrescarTabla();
            this.txtNombre.Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                var lstProductores = from p in db.PRODUCTORES
                                     select p;

                if (!string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    lstProductores = lstProductores.Where(p => p.NOM_PROD.Contains(this.txtNombre.Text));
                }
                grDatos.DataSource = lstProductores.ToList();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
        }
    }
}
