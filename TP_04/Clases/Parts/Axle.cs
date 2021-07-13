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

        

        public Axle RequestStock(int stock)
        {
            if(this.Stock >= stock)
            {
                this.Stock = -stock;
                return new Axle(this.Length, this.Diameter, this.Stock);
            }

            throw new Exception("Out of Stock");
        }

        public override CarPart GetCopy()
        {
            return new Axle(this.Length, this.Diameter, 0);
        }
    }
}
