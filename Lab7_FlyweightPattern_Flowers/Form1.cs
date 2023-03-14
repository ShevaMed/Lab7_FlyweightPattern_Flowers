using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlyweightFlowersLib.Context;
using FlyweightFlowersLib.Factory;
using FlyweightFlowersLib.Flyweight;

namespace Lab7_FlyweightPattern_Flowers
{
    public partial class Form1 : Form
    {
        Graphics g;
        Random random;

        FlowerFactory factory;
        List<Flower> flowers = new List<Flower>();
        FlowerFlyweight[] arrFlyweight = 
        {
            new FlowerFlyweight("..\\..\\images\\rose.png", new Size(10, 20), "rose"),
            new FlowerFlyweight("..\\..\\images\\tulip.png", new Size(10, 20), "tulip"),
            new FlowerFlyweight("..\\..\\images\\chrysanthemum.png", new Size(12, 15), "chrysanthemum")
        };
        
        public Form1()
        {
            InitializeComponent();

            g = this.CreateGraphics();
            random = new Random();

            factory = new FlowerFactory(arrFlyweight);
        }

        //Image img = new Bitmap("..\\..\\images\\field.jpg");
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == 150)
                Close();

            Point startPosition = new Point(random.Next(20, Width - 40), random.Next(Height / 2 + 10, Height - 90));
            Flower flower = new Flower(startPosition, factory.GetFlyweight(arrFlyweight[random.Next(0, arrFlyweight.Length)]));
            flowers.Add(flower);

            //g.DrawImage(img, 0, 0, Width, Height);

            for (int i = 0; i < flowers.Count(); i++)
            {
                if (flowers[i].size.Height < 80)
                {
                    flowers[i].size.Width += 2;
                    flowers[i].size.Height += 4;

                    flowers[i].xy.X -= 1;
                    flowers[i].xy.Y -= 2;
                }
                else
                {
                    flowers.RemoveAt(i);
                    ++count;
                }                
                g.DrawImage(flowers[i].flyweight.img, new Rectangle(flowers[i].xy, flowers[i].size));
            }
        }
    }
}
