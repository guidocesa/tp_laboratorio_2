using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Axle : CarPart, IStockable<Axle>
    {
        private float length;
        private float diameter;

        public float Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }

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

        public Axle(float length, float diameter, int stock) 
            : base( stock , "A-L" + length.ToString() + "-D" + diameter.ToString())
        {
            this.diameter = diameter;
            this.length = length;
        }

        

        public Axle RequestStock(int stock)
        {
            if(this.stock >= stock)
            {
                this.stock = -stock;
                return new Axle(this.length, this.diameter, this.stock);
            }

            throw new Exception("Out of Stock");
        }
    }
}
