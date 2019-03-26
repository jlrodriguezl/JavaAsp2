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

        private string idProductores;
        
            

        public FrmGestionarProductores(string idProductores)
        {
            InitializeComponent();

            this.idProductores = idProductores;

            if (!string.IsNullOrEmpty(this.idProductores))
            {
                cargarDatos();
            }
           
        }

        private void cargarDatos()
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                oProductores = db.PRODUCTORES.Find(int.Parse(idProductores));

                txtNombre.Text = oProductores.NOM_PROD;
                
            }
        }

        private void FrmGestionarProductores_Load(object sender, EventArgs e)
        {
            
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
                    if(this.idProductores == null)

                        oProductores = new PRODUCTORES();
                    
                    oProductores.NOM_PROD = this.txtNombre.Text;

                    if(this.idProductores == null)
                    
                        db.PRODUCTORES.Add(oProductores);
                    
                    else
                    
                        db.Entry(oProductores).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        this.Close();
                    
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
