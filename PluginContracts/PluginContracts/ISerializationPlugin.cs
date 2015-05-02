using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PluginContracts
{
    public interface ISerializationPlugin
    {
        string TransformXmlToJson(string xml);

        XmlDocument TransformJsonToXml(string json);
    }
}
