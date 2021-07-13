using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    [Serializable]
    public class BallBearing : CarPart
    {

        public float Diameter { get; set; }

        public BallBearing(float diameter, int stock) :  base(stock, "BB-D" + diameter.ToString())
        {
            this.Diameter = diameter;
        }

        /// <summary>
        /// Returns a similar BallBearing object with Stock set to zero.
        /// </summary>
        /// <returns></returns>
        public override CarPart GetCopy()
        {
            return new BallBearing(this.Diameter, 0);
        }
    }
}
