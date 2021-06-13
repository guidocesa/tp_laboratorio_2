using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clases
{
    [Serializable]
    public class Bolt : CarPart
    {
        public enum HeadType { HEX, ALEM}

        public float Length { get; set; }

        public float Diameter { get; set; }

        public HeadType CurrentHeadType { get; set; }

        public Bolt(float diameter, float length, HeadType headType, int stock) 
            : base(stock, "B-" + headType.ToString() + "-D" + diameter.ToString() + "-L" + length.ToString())
        {
            this.Diameter = diameter;
            this.Length = length;
            this.CurrentHeadType = headType;
        }
    }
}
