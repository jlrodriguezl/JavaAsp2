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
                oProductores = db.PRODUCTORES.Find(nomProductor);
                txtNombre.Text = oProductores.NOM_PROD;
            }
        }
        private void FrmGestionarProductores_Load(object sender, EventArgs e)
        {
            this.txtNombre.Select();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("El campo es obligatorio");
            }
            else
            {
                using (videotiendaEntities db = new videotiendaEntities())
                {
                    if(this.nomProductor == null)
                    {
                        oProductores = new PRODUCTORES();
                    }
                    oProductores.NOM_PROD = txtNombre.Text;

                    if(this.nomProductor == null)
                    {
                        db.PRODUCTORES.Add(oProductores);
                    }
                    else
                    {
                        db.Entry(oProductores).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        this.Close();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
