using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    [Serializable]
    public class Cog : CarPart
    {

        public int TeethNumber { get; set; }

        public Cog(int teethNumber, int stock) : base( stock, "C-T" + teethNumber.ToString())
        {
            this.TeethNumber = teethNumber;
        }

        public override CarPart GetCopy()
        {
            return new Cog(this.TeethNumber, 0);
        }
    }
}
