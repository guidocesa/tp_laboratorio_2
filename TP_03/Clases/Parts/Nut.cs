﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clases
{
    public class Nut : CarPart
    {
        public float Diameter { get; set; }

        public Nut(float diameter, int stock) : base( stock, "N-D" + diameter.ToString())
        {
            this.Diameter = diameter;
        }

        /// <summary>
        /// Returns a similar Nut object with Stock set to zero.
        /// </summary>
        /// <returns></returns>
        public override CarPart GetCopy()
        {
            return new Nut(this.Diameter, 0);
        }
    }
}
