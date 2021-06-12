using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serializer
{
    public class XML<T>
    {
        public bool Save(T _object, string path)
        {
            if (_object != null && path != null)
            {
                using (XmlTextWriter xmlTextWriter = new XmlTextWriter(path, Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    serializer.Serialize(xmlTextWriter, _object);
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Read(string path, out T _object)
        {
            _object = default;

            try
            {
                using (XmlReader reader = new XmlTextReader(path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    _object = (T)ser.Deserialize(reader);
                }

                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

    }
}
