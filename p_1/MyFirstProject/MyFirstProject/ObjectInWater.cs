using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyFirstProject
{
    abstract public class ObjectInWater
    {
        public int object_X { get; set; }

        public int object_Y { get; set; }

        public int SizeO { get; set; }
        public Bitmap ObjectImC { get; set; }

        public int SizeImX { get; set; }

        public int SizeImY { get; set; }

        public bool Life { get; set; }

        public ObjectInWater(Bitmap m_ObjectImC, int sizex, int sizey, int size, int obX, int obY, bool life = true)
        {
            object_X = obX;
            object_Y = obY;
            SizeO = size;
            ObjectImC = m_ObjectImC;
            SizeImX = sizex;
            SizeImY = sizey;
            Life = life;
        }


        abstract public void Kill();
    }


}
