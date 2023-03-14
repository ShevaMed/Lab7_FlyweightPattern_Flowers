using FlyweightFlowersLib.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightFlowersLib.Factory
{
    public class FlowerFactory
    {
        private List<FlowerFlyweight> flyweights = new List<FlowerFlyweight>();

        public FlowerFactory()
        {
        }

        public FlowerFactory(FlowerFlyweight[] flyweights)
        {
            foreach(var i in flyweights)
            {
                this.flyweights.Add(i);
            }    
        }

        public FlowerFlyweight GetFlyweight(FlowerFlyweight flyweight)
        {
            foreach (var i in flyweights)
            {
                if (i == flyweight)
                    return i;
            }
            flyweights.Add(flyweight);

            return flyweight;
        }
    }
}
