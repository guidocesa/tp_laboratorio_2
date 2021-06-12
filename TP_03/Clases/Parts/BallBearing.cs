using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class BallBearing : CarPart
    {
        private float diameter;

        public float Diameter
        {
            get
            {
                return this.diameter;
            }
            set
            {
                this.diameter = value;
            }
        }

        public BallBearing(float diameter, int stock) :  base(stock, "BB-D" + diameter.ToString())
        {
            this.diameter = diameter;
        }
    }
}
