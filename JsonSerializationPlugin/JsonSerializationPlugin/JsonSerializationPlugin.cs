using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JsonSerializationPlugin
{
    public class JsonSerializationPlugin : ISerializationPlugin
    {
        public string TransformXmlToJson(string xmlPath)
        {
            StreamReader fs = new StreamReader(xmlPath);
            string text = fs.ReadToEnd();
            fs.Close();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(text);
            return JsonConvert.SerializeXmlNode(doc);
        }
    }
}
