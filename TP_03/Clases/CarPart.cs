using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clases
{
    public abstract class CarPart
    {
        public string Id { get; }

        public int Stock{ get; set; }

        /// <summary>
        /// Sets the stock and id atributes.
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="id"></param>
        protected CarPart(int stock, string id)
        {
            this.Id = id;
            this.Stock = stock;
        }

        /// <summary>
        /// Sets the id atribute and 0 to stock.
        /// </summary>
        /// <param name="id"></param>
        protected CarPart(string id) :this( 0 , id)
        {

        }

        /// <summary>
        /// Increments stock by the recieved amount
        /// </summary>
        /// <param name="stock"></param>
        public void AddStock(int stock)
        {
            if(stock > 0)
            {
                this.Stock += stock;
            }
        }

        /// <summary>
        /// Returns the current stock value.
        /// </summary>
        /// <returns></returns>
        public int CheckStock()
        {
            return this.Stock;
        }

        /// <summary>
        /// Reduces the stock by the recieved ammount.
        /// </summary>
        /// <param name="stock"></param>
        public void ReduceStock(int stock)
        {
            if(this.Stock >= stock)
            {
                this.Stock -= stock;
            }
            
        }

        /// <summary>
        /// Compares two CarParts to see if they are the same.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            if(other is CarPart)
            {
                if(this == (CarPart) other)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Equals(String other)
        {
            if (this.Id == other)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Compares two CarParts to see if they are the same.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(CarPart a, CarPart b)
        {
            if( a.Id.Equals(b.Id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Compares two CarParts to see if they are different.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(CarPart a, CarPart b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Returns a Copy of the CarPart with Stock = 0;
        /// </summary>
        /// <returns></returns>
        public abstract CarPart GetCopy();
    }
}
