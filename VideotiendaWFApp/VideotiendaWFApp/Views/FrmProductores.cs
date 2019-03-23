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

        private PRODUCTORES getSelectedItem()
        {
            PRODUCTORES p = new PRODUCTORES();
            try
            {
                p.ID_PROD =
                    int.Parse(grDatos.Rows[grDatos.CurrentRow.Index].Cells[0].
                    Value.ToString());
                p.NOM_PROD =
                    grDatos.Rows[grDatos.CurrentRow.Index].Cells[1].Value.ToString();

                return p;
            }
            catch
            {
                return null;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Views.FrmGestionarProductores frmGestionarProductores = new
                Views.FrmGestionarProductores(null,null);
            frmGestionarProductores.ShowDialog();

            refrescarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PRODUCTORES p = getSelectedItem();

            if(p != null)
            {
                Views.FrmGestionarProductores frmGestionarProductores = new Views.
                    FrmGestionarProductores((p.ID_PROD).ToString(), p.NOM_PROD);

                frmGestionarProductores.ShowDialog();

                refrescarTabla();
            }
        }
    }
}
