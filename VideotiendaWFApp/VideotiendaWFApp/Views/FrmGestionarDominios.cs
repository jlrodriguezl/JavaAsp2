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
    public partial class FrmGestionarDominios : Form
    {
        DOMINIOS oDominio = null;
        private String tipoDominio;
        private String IdDominio;

        public FrmGestionarDominios(String tipoDominio, String idDominio)
        {
            //Dibujar el formulario
            InitializeComponent();
            //Recibir los datos de la PK (si son nulos estamos insertando. 
            //Si hay datos estamos editando)
            this.tipoDominio = tipoDominio;
            this.IdDominio = idDominio;
            
            //Si hay datos (edición), llamamos a cargarDatos()
            if(!string.IsNullOrEmpty(this.IdDominio) &&
                !string.IsNullOrEmpty(this.tipoDominio))
            {
                //Si es modo Edición, bloqueamos los TextBox de la PK
                cargarDatos();
                this.txtTipo.ReadOnly = true;
                this.txtId.ReadOnly = true;
            }
            else
            {
                //Si es modo Inserción habilitamos los TextBox de la PK
                this.txtTipo.ReadOnly = false;
                this.txtId.ReadOnly = false;
            }
        }

        private void cargarDatos()
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                oDominio = db.DOMINIOS.Find(tipoDominio, IdDominio);
                txtTipo.Text = oDominio.TIPO_DOMINIO;
                txtId.Text = oDominio.ID_DOMINIO;
                txtValor.Text = oDominio.VLRDOMINIO;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validar que todos los campos obligatorios se hayan diligenciado
            if (string.IsNullOrEmpty(this.txtId.Text) || string.IsNullOrEmpty(this.txtTipo.Text) || string.IsNullOrEmpty(this.txtValor.Text)){
                MessageBox.Show("Los campos marcados con (*) son obligatorios");
            }
            else
            {
                //Establecer conexión con la BD a través de EF
                using(videotiendaEntities db = new videotiendaEntities())
                {
                    //Si estamos en modo Inserción, inicializamos el objeto oDominio
                    if(this.tipoDominio == null && this.IdDominio == null)                    
                        oDominio = new DOMINIOS();
                    
                    oDominio.TIPO_DOMINIO = this.txtTipo.Text;
                    oDominio.ID_DOMINIO = this.txtId.Text;
                    oDominio.VLRDOMINIO = this.txtValor.Text;
                    //En modo inserción, adicionamos un nuevo registro
                    if (this.tipoDominio == null && this.IdDominio == null)
                        db.DOMINIOS.Add(oDominio);
                    else
                        //En modo edición, cambiamos el estado del objeto a Modificación
                        db.Entry(oDominio).State = System.Data.Entity.EntityState.Modified;
                    //Confirmar cambios en la BD
                    db.SaveChanges();
                    //Cerrar el formulario y volver al formulario de datos
                    this.Close();
                }
            }
        }

        private void FrmGestionarDominios_Load(object sender, EventArgs e)
        {
            this.txtTipo.Select();
        }
    }
}
