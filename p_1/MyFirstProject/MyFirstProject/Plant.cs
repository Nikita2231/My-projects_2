using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyFirstProject
{
    public class Plant: ObjectInWater
    {
        public Plant(Bitmap m_PlantImC, int sizex, int sizey, int size, int plantX, int plantY, bool life = true)
            : base(m_PlantImC, sizex, sizey, size, plantX, plantY, life) { }

        public override void Kill()
        {
            if (Life)
            {
                ObjectImC = Resource1.Plant_Kill;
                Life = false;
            }
        }

    }
}
