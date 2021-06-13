using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer
{
    /// <summary>
    /// This class helps serialize objects.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    public class Entry<T,U>
    {
        public T Key { get; set; }
        public U Value { get; set; }
        public Entry()
        {
        }

        public Entry(T key, U value)
        {
            Key = key;
            Value = value;
        }
    }
}
