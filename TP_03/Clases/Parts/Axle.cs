using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    [Serializable]
    public class Axle : CarPart
    {

        public float Length { get; set; }

        public float Diameter {get; set;}

        public Axle(float length, float diameter, int stock) 
            : base( stock , "A-L" + length.ToString() + "-D" + diameter.ToString())
        {
            this.Diameter = diameter;
            this.Length = length;
        }

        
        /// <summary>
        /// Returns the requested number of Axle parts if possible.
        /// </summary>
        /// <param name="stock"></param>
        /// <returns></returns>
        public Axle RequestStock(int stock)
        {
            if(this.Stock >= stock)
            {
                this.Stock = -stock;
                return new Axle(this.Length, this.Diameter, this.Stock);
            }

            throw new Exception("Out of Stock");
        }

        /// <summary>
        /// Returns a similar Axle object with Stock set to zero.
        /// </summary>
        /// <returns></returns>
        public override CarPart GetCopy()
        {
            return new Axle(this.Length, this.Diameter, 0);
        }
    }
}
