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
    public partial class FrmVideojuegos : Form
    {
        public FrmVideojuegos()
        {
            InitializeComponent();
        }

        private void cargarCategorias()
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                var firstItem = new List<dynamic>() {
                        new { ID_CATEGORIA = 0, NOM_CATEGORIA = "Todas"}
                    };
                var lstCategorias = (from c1 in firstItem
                                     select c1).Union(from c in db.CATEGORIAS
                                                      orderby c.NOM_CATEGORIA
                                                      select new
                                                      {
                                                          ID_CATEGORIA = c.ID_CATEGORIA,
                                                          NOM_CATEGORIA = c.NOM_CATEGORIA
                                                      });
                this.cboCategoria.DataSource = lstCategorias.ToList();
                this.cboCategoria.DisplayMember = "NOM_CATEGORIA";
                this.cboCategoria.ValueMember = "ID_CATEGORIA";
            }
        }
        private void cargarProductores()
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                var firstItem = new List<dynamic>() {
                        new { ID_PROD = 0, NOM_PROD = "Todos"}
                    };
                var lstProductores = (from p1 in firstItem
                                     select p1).Union(from p in db.PRODUCTORES
                                                      orderby p.NOM_PROD
                                                      select new
                                                      {
                                                          ID_PROD = p.ID_PROD,
                                                          NOM_PROD = p.NOM_PROD
                                                      });
                this.cboProd.DataSource = lstProductores.ToList();
                this.cboProd.DisplayMember = "NOM_PROD";
                this.cboProd.ValueMember = "ID_PROD";
            }
        }

        private void FrmVideojuegos_Load(object sender, EventArgs e)
        {
            cargarCategorias();
            cargarProductores();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
