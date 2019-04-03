using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideotiendaWFApp.Views
{
    public partial class FrmVerFoto : Form
    {
        string url;
        public FrmVerFoto(string url)
        {
            InitializeComponent();
            this.url = url;
        }

        private void FrmVerFoto_Load(object sender, EventArgs e)
        {            
            this.pcbFoto.ImageLocation = this.url;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
