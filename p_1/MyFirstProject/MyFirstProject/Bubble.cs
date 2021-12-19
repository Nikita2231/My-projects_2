using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstProject
{
    public class Bubble : ObjectInWater
    {

        public Bubble(Bitmap m_BubbleImC, int sizex, int sizey, int size, int bubX, int bubY, bool life = true)
            : base(m_BubbleImC, sizex, sizey, size, bubX, bubY, life) { }

        public override void Kill()
        {
            if (Life)
            {
                ObjectImC = Resource1._7_Kill;
                Life = false;
            }
        }

    }
}
