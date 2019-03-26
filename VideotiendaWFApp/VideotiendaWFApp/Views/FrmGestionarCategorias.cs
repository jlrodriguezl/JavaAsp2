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

namespace VideotiendaAPP.Views
{
    public partial class FrmGestionarCategorias : Form
    {
        CATEGORIAS OCategoria = null;
        
        private String nombreCategoria;

        // constructor para que reciba y setee los valores que van a tomar las variables globales 
        public FrmGestionarCategorias(String nombreCategoria)
        {
            // para dibujar el formulario
            InitializeComponent();
            //Para recibir los datos de la pk ( SI SON NULL ESTAMOS INSERTANDO 
            //SI HAY DATOS (EDICION) LLAMAMOS A CARGADATOS
           
            this.nombreCategoria = nombreCategoria;

            //SI HAY DATOS (EDICION), LLAMAMOS A CARGAR DATOS ()
            // !es negar
            if( !String.IsNullOrEmpty(this.nombreCategoria))
            {
                // si es modo edicion bloqueamos los txtbox de la pk
                cargarDatos();
                
                this.txtNcategoria.ReadOnly = true;

            }
            else
            {
                // si es modo insercion habilitamos  los texbox de la pk
                
                this.txtNcategoria.ReadOnly = false;

            }
        }

        private void FrmGestionarCategorias_Load(object sender, EventArgs e)
        {
            this.txtNcategoria.Select();
        }

        private void cargarDatos()
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                //odominos es el obejto  db base de datos find es buscar en la base de datos 
                OCategoria = db.CATEGORIAS.Find(nombreCategoria);
               
                
              txtNcategoria.Text = OCategoria.NOM_CATEGORIA;
                
            }

        }

        private void lblNCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();  // su funcion es cerra el formulario y regresar al formulario padre
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //colocamos la condicion 
            if (string.IsNullOrEmpty(this.txtNcategoria.Text))
            {
                MessageBox.Show(" los campos marcados con (*) son obligatorios");
            }
            else
            {
                //establcer conexion con la bd a traves d ef
                using (videotiendaEntities db = new videotiendaEntities())
                {  //capta los datos en  los espacios  y los envia a la bd

                    if (this.txtNcategoria== null)

                        OCategoria = new CATEGORIAS();

                   
                    OCategoria.NOM_CATEGORIA = this.txtNcategoria.Text;
                    
                    // en modo insercion adicionamos un nuevo registro
                    if ( this.nombreCategoria == null)
                        db.CATEGORIAS.Add(OCategoria);

                    else
                        // en modo edicion , cambiamos el estado del objeto a modificacion
                        db.Entry(OCategoria).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges(); // guaradar y cancelar

                    this.Close();

                }



            }
        }


    }
}
