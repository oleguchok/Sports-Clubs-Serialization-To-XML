using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JsonSerializationPlugin
{
    public interface ISerializationPlugin
    {
        /// <summary>
        /// Parse you xml string to json string
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        string TransformXmlToJson(string xml);
        /// <summary>
        /// Parse you json string to XmlDocument
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        XmlDocument TransformJsonToXml(string json);
    }
}
