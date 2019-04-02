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

        public void cargarVideojuegos()
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                //Consultar todos los datos
                var lstVideojuegos = from v in db.VIDEOJUEGOS
                                     join p in db.PRODUCTORES on v.ID_PROD equals p.ID_PROD
                                     join cv in db.CAT_VIDEOJUEGOS on v.NRO_REFERENCIA equals cv.NRO_REFERENCIA
                                     join c in db.CATEGORIAS on cv.ID_CATEGORIA equals c.ID_CATEGORIA
                                     select new
                                     {
                                         NRO_REERENCIA = v.NRO_REFERENCIA,
                                         NOM_VIDEOJUEGO = v.NOM_VIDEOJUEGO,
                                         IMG_VIDEOJUEGO = v.IMG_VIDEOJUEGO,
                                         ID_PROD = p.ID_PROD,
                                         NOM_PROD = p.NOM_PROD,
                                         ID_CATEGORIA = c.ID_CATEGORIA,
                                         NOM_CATEGORIA = c.NOM_CATEGORIA,
                                         ID_CAT_VIDEOJUEGO = cv.ID_CAT_VIDEOJUEGO
                                     };               
                grdVideojuegos.DataSource = lstVideojuegos.ToList();
            }
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                //Consultar todos los datos
                var lstVideojuegos = from v in db.VIDEOJUEGOS
                                     join p in db.PRODUCTORES on v.ID_PROD equals p.ID_PROD
                                     join cv in db.CAT_VIDEOJUEGOS on v.NRO_REFERENCIA equals cv.NRO_REFERENCIA
                                     join c in db.CATEGORIAS on cv.ID_CATEGORIA equals c.ID_CATEGORIA
                                     select new
                                     {
                                         NRO_REERENCIA = v.NRO_REFERENCIA,
                                         NOM_VIDEOJUEGO = v.NOM_VIDEOJUEGO,
                                         IMG_VIDEOJUEGO = v.IMG_VIDEOJUEGO,
                                         ID_PROD = p.ID_PROD,
                                         NOM_PROD = p.NOM_PROD,
                                         ID_CATEGORIA = c.ID_CATEGORIA,
                                         NOM_CATEGORIA = c.NOM_CATEGORIA,
                                         ID_CAT_VIDEOJUEGO = cv.ID_CAT_VIDEOJUEGO
                                     };

                //Aplicar filtros dependiendo de lo que el usuario haya ingresado en la pantalla
                if (int.Parse(this.cboCategoria.SelectedValue.ToString()) != 0)
                {
                    lstVideojuegos = lstVideojuegos.Where(v => v.ID_CATEGORIA.Equals(this.cboCategoria.SelectedValue));
                }
                if (int.Parse(this.cboProd.SelectedValue.ToString()) != 0)
                {
                    lstVideojuegos = lstVideojuegos.Where(v => v.ID_PROD.Equals(this.cboProd.SelectedValue));
                }
                if (!string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    lstVideojuegos = lstVideojuegos.Where(v => v.NOM_VIDEOJUEGO.Contains(this.txtNombre.Text));
                }
                //Retornar lista de videojuegos con los filtros aplicados
                grdVideojuegos.DataSource = lstVideojuegos.ToList();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            cboCategoria.SelectedIndex = 0;
            cboProd.SelectedIndex = 0;
            cargarVideojuegos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmGestionarVideojuegos frmGestionarVideojuegos = new FrmGestionarVideojuegos(null);
            frmGestionarVideojuegos.ShowDialog();
        }
    }
}
