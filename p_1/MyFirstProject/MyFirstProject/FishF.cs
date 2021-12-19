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
    public partial class FishF : Form
    {
        public Bitmap FisIm11 = Resource1.FishC1,
                      FishImNeon1 = Resource1.Neon1,
                      FishImWhiteM1 = Resource1.WhiteM1__2_,
                      FishImNeon2 = Resource1.Neon2,
                      FishImWhiteM2 = Resource1.WhiteM2,
                      FishIm12 = Resource1.FishC2;
            

        public Bitmap FishIm1X;
        public Bitmap FishIm2X;
        public int indexF = 0;
        public int num;




        public FishF()
        {
            InitializeComponent();
        }

        private void ButtFish1_Click(object sender, EventArgs e)
        {
            FishIm1X = FisIm11;
            FishIm2X = FishIm12;
            indexF = 3;
            num = 1;
            Close();
        }

        private void ButtFish2_Click(object sender, EventArgs e)
        {
            FishIm1X = FishImNeon1;
            FishIm2X = FishImNeon2;
            indexF = 1;
            num = 2;
            Close();
        }

        private void ButtFish3_Click(object sender, EventArgs e)
        {
            FishIm1X = FishImWhiteM1;
            FishIm2X = FishImWhiteM2;
            indexF = 2;
            num = 3;
            Close();
        }
    }
}
