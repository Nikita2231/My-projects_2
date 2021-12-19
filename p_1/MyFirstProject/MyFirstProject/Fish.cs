using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyFirstProject
{
    public class Fish : ObjectInWater
    {
        public Bitmap FishImC2 { get; set; }


        public int Number { get; set; }

        public int Kof { get; set; }

        public Fish(Bitmap m_FishImC, Bitmap m_FishImC2, int sizex, int sizey, int size, int fishX, int fishY, int number, int kof, bool life = true)
            :base(m_FishImC, sizex, sizey, size, fishX, fishY, life)
        {
            FishImC2 = m_FishImC2;
            Number = number;
            Kof = kof;
        }

        public override void Kill()
        {
            if (Life == true)
            {
                Life = false;
                switch (Number)
                {
                    case 1:
                        ObjectImC = Resource1.FishC1_Kill;
                        object_Y = 20;
                        break;
                    case 2:
                        ObjectImC = Resource1.Neon1_Kill;
                        object_Y = 20;
                        break;
                    case 3:
                        ObjectImC = Resource1.WhiteM1__3_;
                        object_Y = 20;
                        break;
                }
            }
        }
        

    }
}
