using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightFlowersLib.Flyweight
{
    public class FlowerFlyweight
    {
        public Image img;
        public Size size;
        public string name;

        public FlowerFlyweight(string fileName, Size size, string name)
        {
            img = Image.FromFile(fileName);
            this.size = size;
            this.name = name;
        }
    }
}
