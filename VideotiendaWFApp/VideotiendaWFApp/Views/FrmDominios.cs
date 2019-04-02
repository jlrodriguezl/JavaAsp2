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
    public partial class FrmDominios : Form
    {
        public FrmDominios()
        {            
            InitializeComponent();            
        }

        private void FrmDominios_Load(object sender, EventArgs e)
        {
            refrescarTabla();
            this.txtTipo.Select();
        }

        #region Helper
         public void refrescarTabla()
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                var lstDominios = from d in db.DOMINIOS
                                  select d;
                grdDominios.DataSource = lstDominios.ToList();
            }
        }

        private DOMINIOS getSelectedItem()
        {
            //Inicializar objeto para almacenar dominio seleccionado en la tabla
            DOMINIOS d = new DOMINIOS();
            try
            {
                //Obtener los valores de la PK del dominio seleccionado en la tabla
                d.TIPO_DOMINIO = 
                    grdDominios.Rows[grdDominios.CurrentRow.Index].
                    Cells[0].Value.ToString();
                d.ID_DOMINIO =
                    grdDominios.Rows[grdDominios.CurrentRow.Index].
                    Cells[1].Value.ToString();
                //Retornar objeto con datos del dominio seleccionado en la tabla
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
            using (videotiendaEntities db = new videotiendaEntities())
            {
                //Consultar todos los dominios
                var lstDominios = from d in db.DOMINIOS
                                  select d;

                //Aplicar filtros dependiendo de lo que el usuario haya ingresado en la pantalla
                if (!string.IsNullOrEmpty(this.txtTipo.Text))
                {
                    lstDominios = lstDominios.Where(d => d.TIPO_DOMINIO.Contains(this.txtTipo.Text));
                }
                if (!string.IsNullOrEmpty(this.txtId.Text))
                {
                    lstDominios = lstDominios.Where(d => d.ID_DOMINIO.Contains(this.txtId.Text));
                }
                if (!string.IsNullOrEmpty(this.txtValor.Text))
                {
                    lstDominios = lstDominios.Where(d => d.VLRDOMINIO.Contains(this.txtValor.Text));
                }
                //Retornar lista de dominios con los filtros aplicados
                grdDominios.DataSource = lstDominios.ToList();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "";
            this.txtTipo.Text = "";
            this.txtValor.Text = "";

            refrescarTabla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Views.FrmGestionarDominios frmGestionarDominios = new Views.FrmGestionarDominios(null,null);
            frmGestionarDominios.ShowDialog();

            refrescarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Obtener dominio que se seleccionó en la tabla para editar
            DOMINIOS d = getSelectedItem();
            //Hubo selección?
            if(d != null)
            {
                //Inicializar formulario de edición de dominios
                Views.FrmGestionarDominios frmGestionarDominios
                    = new Views.FrmGestionarDominios(d.TIPO_DOMINIO, d.ID_DOMINIO);
                //Abrir formulario de edición de dominios
                frmGestionarDominios.ShowDialog();
                //Refrescar tabla cuando regrese del formulario de edición
                refrescarTabla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Obtener el dominio que se va a eliminar
            DOMINIOS d = this.getSelectedItem();
            //Hubo selección?
            if (d != null)
            {
                if (MessageBox.Show("Está seguro que desea eliminar este registro?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) ==
                        System.Windows.Forms.DialogResult.Yes)
                {
                    //Establecer conexión con la BD a través de EF
                    using (videotiendaEntities db = new videotiendaEntities())
                    {
                        //Buscar el dominio en la BD
                        DOMINIOS dEliminar = db.DOMINIOS.Find(d.TIPO_DOMINIO, d.ID_DOMINIO);
                        //Eliminar el dominio de la tabla
                        db.DOMINIOS.Remove(dEliminar);
                        //Confirmar cambios en la BD
                        db.SaveChanges();
                    }
                    //Actualizar la tabla de datos
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
