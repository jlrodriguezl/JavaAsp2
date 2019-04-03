using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideotiendaWFApp.Models;

namespace VideotiendaWFApp.Views
{
    public partial class FrmGestionarVideojuegos : Form
    {
        private int? idVideojuego;
        private VIDEOJUEGOS oVideojuego = null;
        public FrmGestionarVideojuegos(int? idVideojuego = null)
        {            
            InitializeComponent();
            //Recibir los datos de la PK (si son nulos estamos insertando. 
            //Si hay datos estamos editando)
            this.idVideojuego = idVideojuego;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            // Abrir cuadro de dialogo
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Mostrar imagen en PictureBox  
                pbxFoto.Image = new Bitmap(open.FileName);
                // image file path  
                txtFoto.Text = open.FileName;
            }
        }

        private void cargarCategorias()
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {               
                var lstCategorias = from c in db.CATEGORIAS
                                                      orderby c.NOM_CATEGORIA
                                                      select new
                                                      {
                                                          ID_CATEGORIA = c.ID_CATEGORIA,
                                                          NOM_CATEGORIA = c.NOM_CATEGORIA
                                                      };
                this.lstCategorias.DataSource = lstCategorias.ToList();
                this.lstCategorias.DisplayMember = "NOM_CATEGORIA";
                this.lstCategorias.ValueMember = "ID_CATEGORIA";
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
        private void FrmGestionarVideojuegos_Load(object sender, EventArgs e)
        {
            cargarCategorias();
            cargarProductores();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //string destFile = "~/ImgVideojuegos/";
            CAT_VIDEOJUEGOS catVideojuegos = new CAT_VIDEOJUEGOS();
            //Validar que todos los campos obligatorios se hayan diligenciado
            if (string.IsNullOrEmpty(this.txtFoto.Text) || string.IsNullOrEmpty(this.txtNombre.Text) 
                || int.Parse(this.cboProd.SelectedValue.ToString()) == 0 || this.lstCategorias.SelectedItems.Count == 0)
            {
                MessageBox.Show("Los campos marcados con (*) son obligatorios");
            }
            else
            {
                //Establecer conexión con la BD a través de EF
                using (videotiendaEntities db = new videotiendaEntities())
                {
                    //Si estamos en modo Inserción, inicializamos el objeto oVideojuego
                    if (this.idVideojuego == null)
                        oVideojuego = new VIDEOJUEGOS();

                    oVideojuego.NOM_VIDEOJUEGO = this.txtNombre.Text;
                    oVideojuego.IMG_VIDEOJUEGO = this.txtFoto.Text;
                    oVideojuego.ID_PROD = int.Parse(this.cboProd.SelectedValue.ToString());

                    //En modo inserción, adicionamos un nuevo registro
                    if (this.idVideojuego == null)
                        db.VIDEOJUEGOS.Add(oVideojuego);                    
                    else
                        //En modo edición, cambiamos el estado del objeto a Modificación
                        db.Entry(oVideojuego).State = System.Data.Entity.EntityState.Modified;
                    //Confirmar cambios en la BD
                    db.SaveChanges();

                    //Guardar relación de Categorias con Videojuegos
                    //var items = lstCategorias.Items.Cast<ListViewItem>().Where(item => item.Selected);
                    /*foreach (var item in lstCategorias.SelectedItems)
                    {
                        string s = item.ToString();
                        catVideojuegos = new CAT_VIDEOJUEGOS();
                        catVideojuegos.ID_CATEGORIA = 1;
                        catVideojuegos.NRO_REFERENCIA = oVideojuego.NRO_REFERENCIA;

                        db.CAT_VIDEOJUEGOS.Add(catVideojuegos);
                        db.SaveChanges();
                    }¨*/
                    for (int x = 0; x < this.lstCategorias.Items.Count; x++)
                    {
                        if (lstCategorias.GetSelected(x) == true)
                        {                     

                            catVideojuegos = new CAT_VIDEOJUEGOS();

                            catVideojuegos.ID_CATEGORIA = int.Parse(lstCategorias.SelectedValue.ToString());
                            catVideojuegos.NRO_REFERENCIA = oVideojuego.NRO_REFERENCIA;

                            db.CAT_VIDEOJUEGOS.Add(catVideojuegos);
                            db.SaveChanges();
                        }

                    }
                    //Copiar foto a carpeta del sistema
                    
                    System.IO.File.Copy(this.txtFoto.Text, @"..\ImgVideojuegos\"+ oVideojuego.NRO_REFERENCIA + ".jpg", true);
                    //Cerrar el formulario y volver al formulario de datos
                    this.Close();
                }
            }
        }
    }
}
