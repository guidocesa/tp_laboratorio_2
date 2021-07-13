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
        private List<CarPart> availableParts;

        static Warehouse()
        {
            warehouse = new Warehouse();
            warehouse.availableParts = new List<CarPart>();
        }

        /// <summary>
        /// Returns the only instance of Warehouse.
        /// </summary>
        /// <returns></returns>
        public static Warehouse Get_Warehouse()
        {
            return Warehouse.warehouse;
        }

        /// <summary>
        /// Recieves a Parts list ass a request, it check whether it has enough stock of each part, if it has, it saves a the request as an XML file.
        /// if it doesn't, throws a new exception.
        /// </summary>
        /// <param name="newRequest"></param>
        public void ReceiveRequest(List<CarPart> newRequest)
        {
            if(newRequest.Count > 0)
            {
                foreach(CarPart item in newRequest)
                {
                    if( !availableParts.Contains(item) ||
                        (availableParts.Contains(item) && availableParts[availableParts.IndexOf(item)].Stock < item.CheckStock()) )
                    {
                        throw new Exception("Not enough stock");
                    }
                }

                /*
                 * Here a message or request notification should be sent to the warehouse
                 */


            
                this.Save(Environment.CurrentDirectory + "\\Request_" + DateTime.Now.ToString("yyyy-MM-dd T HH-mm-ss") + ".xml", newRequest);

                foreach (CarPart item in newRequest)
                {
                    availableParts[availableParts.IndexOf(item)].ReduceStock(item.CheckStock());
                }
            }
        }

        /// <summary>
        /// Returns the List of CarParts.
        /// </summary>
        /// <returns></returns>
        public List<CarPart> GetParts()
        {
            return this.availableParts;
        }

        /// <summary>
        /// Recieves CarParts, if they are already on stock, it adds the new amount to it, if they are not, they are added to the Available Parts list.
        /// </summary>
        /// <param name="newParts"></param>
        public void AddParts(List<CarPart> newParts)
        {
            foreach(CarPart item in newParts)
            {
                if(availableParts.Contains(item))
                {
                    availableParts[availableParts.IndexOf(item)].AddStock(item.CheckStock());
                }
                else
                {
                    availableParts.Add(item);
                }
            }
        }

        /// <summary>
        /// Calls the Save method passing the available parts list.
        /// </summary>
        /// <param name="path"></param>
        public void Save(string path)
        {
            this.Save(path, this.availableParts);
        }

        /// <summary>
        /// Saves the recieved CarPart List to the recieved path as an XML document. 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="parts"></param>
        public void Save(string path, List<CarPart> parts)
        {
            List<Entry<string, int>> aux = new List<Entry<string, int>>();

            foreach(CarPart item in parts)
            {
                aux.Add(new Entry<string, int>(item.Id, item.Stock));
            }

            try
            {
                XML<List<Entry<string, int>>> serializer = new XML<List<Entry<string, int>>>();

                serializer.Save(aux, path);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Tries to load CarParts from the recieved path.
        /// </summary>
        /// <param name="path"></param>
        public void Load(string path)
        {

            XML<List<Entry<string, int>>> serializer = new XML<List<Entry<string, int>>>();

            List<Entry<string, int>> aux = new List<Entry<string, int>>();

            try
            {
                if(serializer.Read(path, out aux))
                {
                    this.LoadObjects( aux );
                }
            }
            catch(Exception e)
            {
                throw new Exception("Problems when loading the Warehouse");
            }

        }

        /// <summary>
        /// Translates the loaded file (strings and ints) to CarParts
        /// </summary>
        /// <param name="aux"></param>
        public void LoadObjects(List<Entry<string, int>> aux)
        {

            this.availableParts.Clear();

            foreach (Entry<string, int> item in aux)
            {
                this.availableParts.Add(item.Key.LoadPartFromString());
                this.availableParts.Last().Stock = item.Value;
            }
        }

        /// <summary>
        /// Loads the CarParts from a SQL database.
        /// </summary>
        public bool LoadFromDatabase()
        {
            this.availableParts.Clear();
            this.availableParts = SQLConnection.LoadWarehouse();
            if(availableParts.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Saves the current car parts to the SQL database.
        /// </summary>
        public void SaveToDatabase()
        {
            SQLConnection.SaveWarehouse(this.availableParts);
        }
    }
}
