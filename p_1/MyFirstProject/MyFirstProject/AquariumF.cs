 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace MyFirstProject
{
    public partial class AquariumF : Form
    {

        Aquarium MyAquarium = new Aquarium();

        public Bitmap BubbleIm = Resource1._7,
                      PlantIm = Resource1.plant1,
                      WaterIm = Resource1._8b544d713911eb6c5bb4eb2e3c370e44__2_;
                              
        public AquariumF()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            UpdateStyles();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MyAquarium.AquaIm = WaterIm;
        }      

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics graphics = e.Graphics;
            graphics.DrawImage(MyAquarium.AquaIm, new Rectangle(0, 0, 1200, 800));            
            int n1 = MyAquarium.CountBubble;
            int n2 = MyAquarium.CountFish;
            int n3 = MyAquarium.CountPlant;

            
            MyAquarium.MoveB(n1, graphics);            
            MyAquarium.MoveP(n3, graphics);
            MyAquarium.MoveF(n2, graphics);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (MyAquarium.CountBubble < 10)
            {
                Random random4 = new Random();
                Bubble m_l_Bubble1 = new Bubble(BubbleIm, 15, 10, random4.Next(1, 5), random4.Next(100, 1100), 650);
                MyAquarium.AddBubble(m_l_Bubble1);
            }
            else
            {
                MessageBox.Show("Максимальное количество пузырьков");
            }
        }

        private void AddPlantButton_Click(object sender, EventArgs e)
        {
            if (MyAquarium.CountPlant < 10)
            {
                Random random4 = new Random();
                Plant m_l_Plant1 = new Plant(PlantIm, 30, 40, random4.Next(3,6), random4.Next(100, 1000), random4.Next(400, 500));
                MyAquarium.AddPlant(m_l_Plant1);
            }
            else
            {
                MessageBox.Show("Максимальное количество растений");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ImF form2 = new ImF();
            form2.ShowDialog();
            MyAquarium.ChangeImWater(form2.WaterImX);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (MyAquarium.CountFish < 10)
            {
                FishF form3 = new FishF();
                form3.ShowDialog();
                Random random2 = new Random();
                Fish m_l_Fish1 = new Fish(form3.FishIm1X, form3.FishIm2X, 51, 34, form3.indexF, random2.Next(100, 1049), random2.Next(100, 600),form3.num, 1);
                MyAquarium.AddFish(m_l_Fish1);
            }
            else
            {
                MessageBox.Show("Максимальное количество рыбок");
            }

        }
        private void Button4_Click(object sender, EventArgs e)
        {
            if (MyAquarium.CountBubble > 0)
            {
                MyAquarium.RemoveBubble(MyAquarium.CountBubble - 1);
            }
            else
            {
                MessageBox.Show("Нету пузырьков");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
           if(MyAquarium.CountFish > 0)
            {
                MyAquarium.RemoveFish(MyAquarium.CountFish - 1);
            }
            else
            {
                MessageBox.Show("Нету рыбок");
            }
        }

        private void NextDay_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int n = random.Next(1,4);
            switch (n)
            {
                case 1:
                    if (MyAquarium.CountBubble > 0)
                    {
                        MyAquarium.m_l_Bubble[random.Next(0, MyAquarium.CountBubble)].Kill();
                    }
                    break;
                case 2:
                    if (MyAquarium.CountPlant > 0)
                    {
                        MyAquarium.m_l_Plant[random.Next(0, MyAquarium.CountPlant)].Kill();
                    }
                    break;
                case 3:
                    if (MyAquarium.CountFish > 0)
                    {
                        MyAquarium.m_l_Fish[random.Next(0, MyAquarium.CountFish)].Kill();
                    }
                    break;
            }
            if (MyAquarium.Check())
            {
                The_End formEnd = new The_End();
                formEnd.ShowDialog();
                Close();
            }
            
        }

        private void DelKillB_Click(object sender, EventArgs e)
        {
            MyAquarium.m_l_Bubble.RemoveAll(bubble => bubble.Life == false);

        }

        private void DellKillP_Click(object sender, EventArgs e)
        {
            MyAquarium.m_l_Plant.RemoveAll(plant => plant.Life == false);
        }

        private void DellKillF_Click(object sender, EventArgs e)
        {
            MyAquarium.m_l_Fish.RemoveAll(fish => fish.Life == false);

        }

        private void RemovePlantButton_Click(object sender, EventArgs e)
        {
            if(MyAquarium.CountPlant > 0)
            {
                MyAquarium.RemovePlant(MyAquarium.CountPlant - 1);
            }
            else
            {
                MessageBox.Show("Нету растений");
            }
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            Refresh();
        }

    }
}
