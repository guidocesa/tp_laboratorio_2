using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class CarPart
    {
        private string id;
        protected int stock;

        public string Id
        {
            get
            {
                return this.id;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                this.stock = value;
            }
        }

        protected CarPart(int stock, string id)
        {
            this.id = id;
            this.stock = stock;
        }

        protected CarPart(string id) :this( 0 , id)
        {

        }

        public void AddStock(int stock)
        {
            this.stock += stock;
        }

        public int CheckStock()
        {
            return this.stock;
        }

        public void ReduceStock(int stock)
        {
            if(this.stock >= stock)
            {
                this.stock -= stock;
            }
            
        }

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

        public static bool operator !=(CarPart a, CarPart b)
        {
            return !(a == b);
        }
    }
}
