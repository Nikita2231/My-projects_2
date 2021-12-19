
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyFirstProject
{
    class Aquarium
    {
        public Bitmap AquaIm { get; set; }


        public List<Fish> m_l_Fish = new List<Fish>();
        public List<Bubble> m_l_Bubble = new List<Bubble>();
        public List<Plant> m_l_Plant = new List<Plant>();

        public int CountBubble
        {
            get
            {
                return m_l_Bubble.Count;
            }
        }

        public int CountPlant
        {
            get
            {
                return m_l_Plant.Count;
            }
        }

        public int CountFish
        {
            get
            {
                return m_l_Fish.Count;
            }
        }

        public void AddBubble(Bubble bubble)
        {
            m_l_Bubble.Add(bubble);
        }

        public void AddPlant(Plant plant)
        {
            m_l_Plant.Add(plant);
        }

        public void AddFish(Fish fish)
        {
            m_l_Fish.Add(fish);
        }

        public void RemoveBubble(int n)
        {
            m_l_Bubble.RemoveAt(n);
        }

        public void RemovePlant(int n)
        {
            m_l_Plant.RemoveAt(n);
        }

        public void RemoveFish(int n)
        {
            m_l_Fish.RemoveAt(n);
        }


        public void ChangeImWater(Bitmap m_AquaIm)
        {
            AquaIm = m_AquaIm;
        }

        public void GraphicsFunction(Graphics graph, ObjectInWater objectInWater)
        {
            graph.DrawImage(objectInWater.ObjectImC, new Rectangle(objectInWater.object_X, objectInWater.object_Y, objectInWater.SizeO * objectInWater.SizeImX, objectInWater.SizeO * objectInWater.SizeImY));
        }

        public void MoveB(int n, Graphics graph)
        {
            
            if (n > 0)
            {
                for (int i = 0; i < n; ++i)
                { 
                    
                    if (m_l_Bubble[i].object_Y > 0)
                    {
                        GraphicsFunction(graph, m_l_Bubble[i]);
                        m_l_Bubble[i].object_Y -= 1;
                    }
                    else
                    {
                        m_l_Bubble[i].object_Y = 650;
                        Random random2 = new Random();
                        m_l_Bubble[i].object_X = random2.Next(100, 1100);
                        m_l_Bubble[i].SizeO = random2.Next(1, 5);
                    }                    
                }
            }
        }

        public void MoveF(int n, Graphics graph)
        {
            
            
            if (n > 0)
            {
                for (int i = 0; i < n; ++i)
                {
                    GraphicsFunction(graph, m_l_Fish[i]);
                    if (m_l_Fish[i].Life)
                    {
                        m_l_Fish[i].object_X += m_l_Fish[i].Kof;
                        if ((m_l_Fish[i].object_X <= 0) || (m_l_Fish[i].object_X >= 1050))
                        {
                            m_l_Fish[i].Kof = -m_l_Fish[i].Kof;
                            Bitmap ChangeIm = m_l_Fish[i].ObjectImC;
                            m_l_Fish[i].ObjectImC = m_l_Fish[i].FishImC2;
                            m_l_Fish[i].FishImC2 = ChangeIm;
                        }
                    }

                }
            }
        }

        public void MoveP(int n, Graphics graph)
        {
            if (n > 0)
            {
                for(int i = 0; i < n; ++i)
                {
                    GraphicsFunction(graph, m_l_Plant[i]);
                }
            }
        }
       
        public bool Check()
        {
            if (CountFish > 0)
            {
                int n = 0;
                for (int i = 0; i < CountFish; ++i)
                {
                    if (!m_l_Fish[i].Life)
                    {
                        ++n;
                    }
                }
                return (n == CountFish);
            }
            else
                return false;
        }

 
    }
}
