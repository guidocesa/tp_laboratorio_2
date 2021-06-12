using Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Warehouse
    {
        private static Warehouse warehouse;
        private Dictionary<string, CarPart> availableParts;

        static Warehouse()
        {
            warehouse = new Warehouse();
            warehouse.availableParts = new Dictionary<string, CarPart>();
        }

        public static Warehouse Get_Warehouse()
        {
            return Warehouse.warehouse;
        }

        public void ReceiveRequest(List<CarPart> newRequest)
        {
            foreach(CarPart item in newRequest)
            {
                if( !availableParts.ContainsKey(item.Id) ||
                    (availableParts.ContainsKey(item.Id) && availableParts[item.Id].CheckStock() < item.CheckStock()) )
                {
                    throw new Exception("Not enough stock");
                }
            }

            /*
             * Here a message or request notification should be sent to the warehouse
             */

            foreach(CarPart item in newRequest)
            {
                availableParts[item.Id].ReduceStock(item.CheckStock());
            }
        }

        public Dictionary<String, CarPart> GetParts()
        {
            return this.availableParts;
        }

        public void AddParts(List<CarPart> newParts)
        {
            foreach(CarPart item in newParts)
            {
                if(availableParts.ContainsKey(item.Id))
                {
                    availableParts[item.Id].AddStock(item.CheckStock());
                }
                else
                {
                    availableParts.Add(item.Id, item);
                }
            }
        }

        public void Save(string path)
        {
            Dictionary<String, int> aux = new Dictionary<string, int>();

            foreach(KeyValuePair<string, CarPart> item in this.availableParts)
            {
                aux.Add(item.Key, item.Value.CheckStock());
            }

            XML<Dictionary<String, int>> serializer = new XML<Dictionary<String, int>>();

            serializer.Save(aux, path);

        }

        public void Load(string path)
        {
            Dictionary<String, int> aux = new Dictionary<string, int>();

            XML<Dictionary<String, int>> xml = new XML<Dictionary<string, int>>();

            try
            {
                if (xml.Read(path, out aux))
                {
                    this.LoadObjects(aux);
                }
            }
            catch(Exception e)
            {
                throw e;
            }

        }

        private void LoadObjects(Dictionary<string, int> aux)
        {
            float length; 
            float diameter;

            foreach (KeyValuePair<string, int> item in aux)
            {
                string[] ID = item.Key.Split('-');

                switch(ID[0])
                {
                    case "BB":
                        float.TryParse(ID[1], out  diameter);
                        BallBearing bb = new BallBearing(diameter, item.Value);
                        this.availableParts.Add(bb.Id, bb);
                        break;

                    case "A":
                        float.TryParse(ID[1], out length);
                        float.TryParse(ID[2], out diameter);
                        Axle a = new Axle(length, diameter, item.Value);
                        this.availableParts.Add(a.Id, a);
                        break;

                    case "C":
                        int.TryParse(ID[1], out int teeth);
                        Cog c = new Cog(teeth, item.Value);
                        this.availableParts.Add(c.Id, c);
                        break;

                    case "N":
                        float.TryParse(ID[1], out diameter);
                        Nut n = new Nut(diameter, item.Value);
                        this.availableParts.Add(n.Id, n);
                        break;

                    case "B":
                        float.TryParse(ID[2], out diameter);
                        float.TryParse(ID[3], out length);
                        if(ID[1].Equals("HEX"))
                        {
                            Bolt b = new Bolt(diameter, length, Bolt.HeadType.HEX, item.Value);
                            this.availableParts.Add(b.Id, b);
                        }
                        else
                        {
                            Bolt b = new Bolt(diameter, length, Bolt.HeadType.ALEM, item.Value);
                            this.availableParts.Add(b.Id, b);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
