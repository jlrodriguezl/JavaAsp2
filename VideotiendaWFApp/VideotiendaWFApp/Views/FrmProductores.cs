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
                                     select new
                                     {
                                         ID_PROD = p.ID_PROD,
                                         NOM_PROD = p.NOM_PROD
                                     };

                grdProductores.DataSource = lstProductores.ToList();
            }
        }

        private PRODUCTORES getSelectedItem()
        {
            PRODUCTORES p = new PRODUCTORES();
            try
            {
               
                p.ID_PROD =
                   int.Parse(grdProductores.Rows[grdProductores.CurrentRow.Index].Cells[0].Value.ToString());
              

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
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                var lstProductores = from p in db.PRODUCTORES
                                     select new {
                                         ID_PROD = p.ID_PROD,
                                         NOM_PROD = p.NOM_PROD
                                     };

                if (!string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    lstProductores = lstProductores.Where(p => p.NOM_PROD.Contains(this.txtNombre.Text));
                }
                grdProductores.DataSource = lstProductores.ToList();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            refrescarTabla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Views.FrmGestionarProductores frmGestionarProductores = new
                Views.FrmGestionarProductores(null);
            frmGestionarProductores.ShowDialog();

            refrescarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PRODUCTORES p = getSelectedItem();

            if (p != null)
            {
                Views.FrmGestionarProductores frmGestionarProductores = new Views.
                    FrmGestionarProductores(p.ID_PROD.ToString());

                frmGestionarProductores.ShowDialog();

                refrescarTabla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PRODUCTORES p = this.getSelectedItem();

            if(p != null)
            {
                if(MessageBox.Show("¿Esta seguro que desea eliminar este registro?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (videotiendaEntities db = new videotiendaEntities())
                    {
                        PRODUCTORES pEliminar = db.PRODUCTORES.Find(p.ID_PROD);

                        db.PRODUCTORES.Remove(pEliminar);

                        db.SaveChanges();
                    }

                    this.refrescarTabla();
                }
            }


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
