using FlyweightFlowersLib.Flyweight;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightFlowersLib.Context
{
    public class Flower
    {
        public Point xy;
        public Size size;
        public FlowerFlyweight flyweight;

        public Flower(Point xy, FlowerFlyweight flyweight)
        {
            this.xy = xy;
            size = flyweight.size;
            this.flyweight = flyweight;
        }
    }
}
