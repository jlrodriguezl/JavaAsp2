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
    public partial class FrmGestionarPersonas : Form
    {
        private Decimal NumDocumento;
        PERSONAS oPersona = null;
        public FrmGestionarPersonas(Decimal NumDocumento)
        {
            InitializeComponent();

            this.NumDocumento = NumDocumento;

            if (NumDocumento != 0)
            {
                cargarDatos();
                this.txtDocumento.ReadOnly = true;
                this.cboTipoDocumento.Enabled = false;
            }
            else {
                this.txtDocumento.ReadOnly = false;
                this.cboTipoDocumento.Enabled = true;
            }
        }

        private void cargarDatos() {
            using (videotiendaEntities db = new videotiendaEntities()) {
                oPersona = db.PERSONAS.Find(NumDocumento);
                txtNombres.Text = oPersona.NOMBRES;
                txtDocumento.Text = oPersona.NRO_DOC.ToString();
                txtDireccion.Text = oPersona.DIRECCION;
                txtApellidos.Text = oPersona.NOMBRES;
                txtCelular.Text = oPersona.CELULAR.ToString();
                txtCorreo.Text = oPersona.CORREO;
                txtContrasena.Text = oPersona.CONTRASENA;
                cboTipoDocumento.SelectedItem = oPersona.TIPO_DOC;
                cboTipoPersona.SelectedItem = oPersona.TIPO_PERSONA;                

            }

        }

        private void cargarTipoDocumento() {

            using (videotiendaEntities db = new videotiendaEntities()) {
                var firstItem = new List<dynamic>
                {
                    new{ ID_TDocumento = "", Nom_TDocumento="" }
                };

                var lstTipoDocumento = (from TD1 in firstItem select TD1)
                    .Union(from TD in db.DOMINIOS.Where
                    (TD => TD.TIPO_DOMINIO.Contains("TIPO_DOC"))
                           select new {
                               ID_TDocumento = TD.ID_DOMINIO,
                               Nom_TDocumento = TD.VLRDOMINIO

                           });

                this.cboTipoDocumento.DataSource = lstTipoDocumento.ToList();
                this.cboTipoDocumento.DisplayMember = "Nom_TDocumento";
                this.cboTipoDocumento.ValueMember = "ID_TDocumento";

            }
        }

        private void cargarTipoPersona() {
            using (videotiendaEntities db = new videotiendaEntities()) {

                var firstItem = new List<dynamic> {
                    new{ ID_TCliente = "", Nom_TCliente=""}
                };

                var lstTipoCliente = (from TC1 in firstItem select TC1)
                    .Union(from TC in db.DOMINIOS.Where
                           (TC => TC.TIPO_DOMINIO.Contains("TIPO_PERSONA"))
                           select new
                           {
                               ID_TCliente = TC.ID_DOMINIO,
                               Nom_TCliente = TC.VLRDOMINIO
                           });
                this.cboTipoPersona.DataSource = lstTipoCliente.ToList();
                this.cboTipoPersona.DisplayMember = "Nom_TCliente";
                this.cboTipoPersona.ValueMember = "ID_TCliente";
            }

        }
     

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNombres.Text) || string.IsNullOrEmpty(this.txtApellidos.Text) ||
                string.IsNullOrEmpty(this.txtDocumento.Text) || string.IsNullOrEmpty(this.txtCelular.Text) ||
                string.IsNullOrEmpty(this.txtCorreo.Text) || string.IsNullOrEmpty(this.txtDireccion.Text) ||
                string.IsNullOrEmpty(this.txtContrasena.Text) || string.IsNullOrEmpty(this.cboTipoDocumento.ValueMember) ||
                string.IsNullOrEmpty(this.cboTipoPersona.ValueMember))
            {
                MessageBox.Show("Los campos marcados con * son obligatorios");


            }
            else {
                using (videotiendaEntities db = new videotiendaEntities()) {

                    //Insercion
                    if (this.NumDocumento ==0)
                    {
                     oPersona = new PERSONAS();
                    }
                    oPersona.NOMBRES = this.txtNombres.Text + " " + this.txtApellidos.Text;
                    oPersona.NRO_DOC = Convert.ToInt64(this.txtDocumento.Text);
                    oPersona.CELULAR = Convert.ToInt64(this.txtCelular.Text);
                    oPersona.DIRECCION = this.txtDireccion.Text;
                    oPersona.CORREO = this.txtCorreo.Text;
                    oPersona.CONTRASENA = this.txtContrasena.Text;
                    oPersona.TIPO_DOC = this.cboTipoDocumento.SelectedValue.ToString();
                    oPersona.TIPO_PERSONA = this.cboTipoPersona.SelectedValue.ToString();

                    if (this.NumDocumento==0)
                    {
                        db.PERSONAS.Add(oPersona);
                    }
                    else
                    {
                        //EDICION
                        db.Entry(oPersona).State = System.Data.Entity.EntityState.Modified;

                    }
                    
                    db.SaveChanges();
                    this.Close();
                }
            }

        }

        private void FrmGestionarPersonas_Load(object sender, EventArgs e)
        {
            cargarTipoDocumento();
            cargarTipoPersona();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
