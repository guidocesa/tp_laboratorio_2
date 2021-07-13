using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    interface IStockable<T>
    {
        void AddStock(int stock);

        T RequestStock(int stock);

        int CheckStock();

        void ReduceStock(int stock);
    }
}
