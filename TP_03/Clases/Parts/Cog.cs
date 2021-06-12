using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cog : CarPart
    {
        private int teethNumber;

        public int TeethNumber
        {
            get
            {
                return this.teethNumber;
            }
            set
            {
                this.teethNumber = value;
            }
        }

        public Cog(int teethNumber, int stock) : base( stock, "C-T" + teethNumber.ToString())
        {
            this.teethNumber = teethNumber;
        }

    }
}
