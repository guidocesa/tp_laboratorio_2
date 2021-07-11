using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases
{
    public static class Extender
    {
        public static CarPart LoadPartFromString(this string id)
        {
            float length;
            float diameter;
            CarPart ret;

            string[] ID = id.Split('-');

            switch (ID[0])
            {
                case "BB":
                    float.TryParse(ID[1].Remove(0, 1), out diameter);
                    ret = new BallBearing(diameter, 0);
                    break;

                case "A":
                    float.TryParse(ID[1].Remove(0, 1), out length);
                    float.TryParse(ID[2].Remove(0, 1), out diameter);
                    ret = new Axle(length, diameter, 0);
                    break;

                case "C":
                    int.TryParse(ID[1].Remove(0, 1), out int teeth);
                    ret = new Cog(teeth, 0);
                    break;

                case "N":
                    float.TryParse(ID[1].Remove(0, 1), out diameter);
                    ret = new Nut(diameter, 0);
                    break;

                case "B":
                    float.TryParse(ID[2].Remove(0, 1), out diameter);
                    float.TryParse(ID[3].Remove(0, 1), out length);
                    if (ID[1].Equals("HEX"))
                    {
                        ret = new Bolt(diameter, length, Bolt.HeadType.HEX, 0);
                    }
                    else
                    {
                        ret = new Bolt(diameter, length, Bolt.HeadType.ALEM, 0);
                    }
                    break;
                default:
                    ret = null;
                    break;
            }

            return ret;
        }
    }
}
