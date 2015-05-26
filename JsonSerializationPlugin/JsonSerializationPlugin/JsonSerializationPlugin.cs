using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JsonSerializationPlugin
{
    public class JsonSerializationPlugin : ISerializationPlugin
    {
        public string TransformXmlToJson(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            return JsonConvert.SerializeXmlNode(doc);
        }

        public XmlDocument TransformJsonToXml(string json)
        {
            return JsonConvert.DeserializeXmlNode(json);
        }
    }
}
