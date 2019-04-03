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
using VideotiendaWFApp.Views;

namespace VideotiendaWFApp.Views
{
    public partial class Frmpersonas : Form
    {
        public Frmpersonas()
        {
            InitializeComponent();
        }
        private void cargarTipoPersona()
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                var firstItem = new List<dynamic>() {
                        new { ID_DOMINIO = 0, VLRDOMINIO = "Todos"}
                    };
                var lstTiposId = (from c1 in firstItem
                                  select c1).Union(from d in db.DOMINIOS
                                                   where d.TIPO_DOMINIO.Equals("TIPO_PERSONA")
                                                      orderby d.VLRDOMINIO
                                                      select new
                                                      {
                                                          ID_DOMINIO = d.ID_DOMINIO,
                                                          VLRDOMINIO = d.VLRDOMINIO
                                                      });
                this.cboTipoPersona.DataSource = lstTiposId.ToList();
                this.cboTipoPersona.DisplayMember = "VLRDOMINIO";
                this.cboTipoPersona.ValueMember = "ID_DOMINIO";
            }
        }

        private void Frmpersonas_Load(object sender, EventArgs e)
        {
            cargarTipoPersona();
            refrescarTabla();
            this.txtdocumento.Select();
        }

        #region Helper
        public void refrescarTabla()
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                var lstPersonas = from d in db.PERSONAS
                                  select new {
                                      NRO_DOC = d.NRO_DOC,
                                      TIPO_DOC = d.TIPO_DOC,
                                      NOMBRES = d.NOMBRES,
                                      CELULAR = d.CELULAR,
                                      CORREO = d.CORREO,
                                      DIRECCION = d.DIRECCION,
                                      TIPO_PERSONA = d.TIPO_PERSONA                                      
                                  };
                grdDatosP.DataSource = lstPersonas.ToList();
            }
        }
        private PERSONAS getSelectedItem()
        {
            //Inicializar objeto para almacenar dominio seleccionado en la tabla
            PERSONAS d = new PERSONAS();
            try
            {
                //Obtener los valores de la PK del dominio seleccionado en la tabla
                d.TIPO_DOC =
                    grdDatosP.Rows[grdDatosP.CurrentRow.Index].
                    Cells[0].Value.ToString();
                d.TIPO_PERSONA =
                    grdDatosP.Rows[grdDatosP.CurrentRow.Index].
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
                //Consultar todas las personas
                var lstPersonas = from d in db.PERSONAS
                                  select new
                                  {
                                      NRO_DOC = d.NRO_DOC,
                                      TIPO_DOC = d.TIPO_DOC,
                                      NOMBRES = d.NOMBRES,
                                      CELULAR = d.CELULAR,
                                      CORREO = d.CORREO,
                                      DIRECCION = d.DIRECCION,
                                      TIPO_PERSONA = d.TIPO_PERSONA
                                  };
                //Aplicar filtros dependiendo de lo que el usuario haya ingresado en la pantalla
                if (!string.IsNullOrEmpty(this.txtnombre.Text))
                {
                    lstPersonas = lstPersonas.Where(d => d.NOMBRES.Contains(this.txtnombre.Text));
                }
                if (!string.IsNullOrEmpty(this.txtCorreo.Text))
                {
                    lstPersonas = lstPersonas.Where(d => d.CORREO.Contains(this.txtCorreo.Text));
                }
                if (!string.IsNullOrEmpty(this.txtdocumento.Text))
                {
                    lstPersonas = lstPersonas.Where(d => d.DIRECCION.Contains(this.txtDireccion.Text));
                }
                //Retornar lista de dominios con los filtros aplicados
                grdDatosP.DataSource = lstPersonas.ToList();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtnombre.Text = "";
            this.txtdocumento.Text = "";
            this.txtDireccion.Text = "";
            this.txtCorreo.Text = "";
            this.txtCelular.Text = "";
            

            refrescarTabla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            /*Views.FrmGestionarPersonas frmGestionarDominios = new Views.FrmGestionarPersonas(null, null);
            frmGestionarPersonas.ShowDialog();*/

            refrescarTabla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Obtener dominio que se seleccionó en la tabla para editar
            PERSONAS d = getSelectedItem();
            //Hubo selección?
            if (d != null)
            {
                //Inicializar formulario de edición de dominios
                /*Views.FrmGestionarPersonas frmGestionarPersonas
                    = new Views.FrmGestionarPersonas(d.TIPO_DOMINIO, d.ID_DOMINIO);
                //Abrir formulario de edición de dominios
                frmGestionarPersonas.ShowDialog();*/
                //Refrescar tabla cuando regrese del formulario de edición
                refrescarTabla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Obtener LA PERSONA que se va a eliminar
            PERSONAS d = this.getSelectedItem();
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
                        PERSONAS dEliminar = db.PERSONAS.Find(d.TIPO_PERSONA, d.NRO_DOC);
                        //Eliminar el dominio de la tabla
                        db.PERSONAS.Remove(dEliminar);
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

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            FrmGestionarPersonas frmGestionarPersonas = new FrmGestionarPersonas(null);
            frmGestionarPersonas.Show();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }
    }
}