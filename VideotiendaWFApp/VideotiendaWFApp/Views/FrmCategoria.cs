using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideotiendaAPP.Models;  // carga la app con el modelo categoria


namespace VideotiendaAPP.Views
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmDominios_Load(object sender, EventArgs e)
        {
            refrescarTabla(); // cargara lpos datos cuanfdo inicia
        }


        #region Helper

        public void refrescarTabla()
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                var ltsCategoria = from d in db.CATEGORIAS
                                   select d;
                // datasource = a consultar a base de datos
                grdDatos.DataSource = ltsCategoria.ToList(); // se define para que pueda traer la lts de la base de datos

            }
        }

        private CATEGORIAS getselectedItem()
        {
            // inicializa objeto para almacenar dominios seleccionado en la tabla

            CATEGORIAS d = new CATEGORIAS();

            try
            {
                // va la a fila categoria y toma el indice   rows =filas   cells = celda

                d.NOM_CATEGORIA = grdDatos.Rows[grdDatos.CurrentRow.Index].Cells[0].Value.ToString();

                return d;
            }
            catch
            {
                return null;
            }

        }

        #endregion 

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // primer paso conetar base de datso video tienda  
            using (videotiendaEntities db = new videotiendaEntities())
            {

                //segundo consultar los categorias

                var ltsCategoria = from d in db.CATEGORIAS select d;
                // var definimos lstCategorua

                // aplicar fltros ingresados por el usuario

                //aplicar busqueda en nombre categoria
                if (!String.IsNullOrEmpty(this.txtncategoria.Text)) // VALIDA SI ESTA VACIO O NULL
                {
                    ltsCategoria = ltsCategoria.Where(d => d.NOM_CATEGORIA.Contains(this.txtncategoria.Text));
                }

                grdDatos.DataSource = ltsCategoria.ToList();
                // grADatos es para que cargue la tabla en gried view
            }
        }

        // BORRAR LO QUE SE HACE EN LOS TXTB
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //SE DIRIJE A LOS TXBOX Y LOS LIMPIA 
            this.txtncategoria.Text = " ";

            refrescarTabla();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {

        }


   
        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
