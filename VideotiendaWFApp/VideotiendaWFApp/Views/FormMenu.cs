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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if(imageNumber == 10)
            {
                imageNumber = 1;
            }
            pbxSlider.ImageLocation = string.Format(@"slider\{0}.jpg",imageNumber);
            imageNumber++;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
