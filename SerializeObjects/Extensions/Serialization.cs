using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace SerializeObjects.Extensions
{
    static class Serialization
    {
        public static T DeserializeXML<T>(this string toDeserialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            StringReader textReader = new StringReader(toDeserialize);
            return (T)xmlSerializer.Deserialize(textReader);
        }

        public static string SerializeXML<T>(this T toSerialize)
        {
            //System.Diagnostics.Debug.WriteLine(typeof(T).Name);
            //System.Diagnostics.Debug.WriteLine(toSerialize.GetType().Name);

            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());
            StringWriter textWriter = new StringWriter();
            xmlSerializer.Serialize(textWriter, toSerialize);
            return textWriter.ToString();
        }


        public static string SerializeJson<T>(this T toSerialize) {
            return JsonConvert.SerializeObject(toSerialize);
        }

        public static T DeserializeJson<T>(this string toDeserialize)
        {
            return JsonConvert.DeserializeObject<T>(toDeserialize);
        }

    }
}
