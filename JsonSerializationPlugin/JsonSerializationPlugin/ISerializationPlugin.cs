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
        /// Parse you xml to json string. Take path of your Xml file.
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        string TransformXmlToJson(string xmlPath);
    }
}
