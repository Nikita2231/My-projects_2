using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProject
{
    public partial class ImF : Form
    {


        private Bitmap WaterIm2 = Resource1.Im2__2_,
                       WaterIm1 = Resource1._8b544d713911eb6c5bb4eb2e3c370e44__2_,
                       WaterIm3 = Resource1.Im3__2_;
        public Bitmap WaterImX;    
        public ImF()
        {
            InitializeComponent();
        }

        private void ButtAqua3_Click(object sender, EventArgs e)
        {
            WaterImX = WaterIm1;
            Close();
        }
        private void ButtAqua2_Click(object sender, EventArgs e)
        {
            WaterImX = WaterIm3;
            Close();
        }

        private void ButtAqua1_Click(object sender, EventArgs e)
        {
            WaterImX = WaterIm2;
            Close();
        }
    }
}
