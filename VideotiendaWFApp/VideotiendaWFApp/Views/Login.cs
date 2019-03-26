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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                int user = int.Parse(txtUsuario.Text);
                String pwd = txtContrasena.Text;

                var lstPersonas = from p in db.PERSONAS
                                  where p.NRO_DOC == user && p.CONTRASENA == pwd
                                  select p;
                if(lstPersonas.Count() > 0)
                {
                    this.Hide();
                    Views.FormMenu formMenu = new FormMenu();                    
                    formMenu.Show();
                    

                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta");
                }
                
            }
            

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtUsuario.Text = "";
            this.txtContrasena.Text = "";
        }
    }
}
