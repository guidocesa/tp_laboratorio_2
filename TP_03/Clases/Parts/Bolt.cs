using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Bolt : CarPart
    {
        public enum HeadType { HEX, ALEM}

        private float diameter;
        private float length;
        private HeadType headType;

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

        public HeadType CurrentHeadType
        {
            get
            {
                return this.headType;
            }
            set
            {
                this.headType = value;
            }
        }

        public Bolt(float diameter, float length, HeadType headType, int stock) 
            : base(stock, "B-" + headType.ToString() + "-D" + diameter.ToString() + "-L" + length.ToString())
        {
            this.diameter = diameter;
            this.length = length;
            this.headType = headType;
        }
    }
}
