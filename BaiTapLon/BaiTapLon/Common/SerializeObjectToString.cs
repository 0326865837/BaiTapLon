using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.Common
{
    public class SerializeObjectToString
    {
        public string SerializeObject(object obj)
        {
            IFormatter formatter = new BinaryFormatter();
            string result = string.Empty;
            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, obj);
                byte[] byt = new byte[stream.Length];
                byt = stream.ToArray();

                result = Convert.ToBase64String(byt);
                stream.Flush();
            }
            return result;
        }

        public object DeserializeObject(string str)
        {
            IFormatter formatter = new BinaryFormatter();

            byte[] byt = Convert.FromBase64String(str);
            object obj = null;
            using (Stream stream = new MemoryStream(byt, 0, byt.Length))
            {
                obj = formatter.Deserialize(stream);
            }
            return obj;
        }
    }
}
