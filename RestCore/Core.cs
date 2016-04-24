using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using log4net;
using log4net.Config;

namespace RestCore
{
    public class Core
    {
        public static Int64 Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                if (n >= 3 && n <= 100)
                {
                    uint a = 1;
                    uint b = 1;
                    uint Fibo = 0;
                    for (uint i = 3; i <= n; i++)
                    {
                        Fibo = b + a;
                        a = b;
                        b = Fibo;
                    }
                    return Fibo;
                }
                else
                {
                    return -1;
                }
            }
        }

        public static string XmlToJson(string xmlString) {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.LoadXml(xmlString);
                string jsonText = JsonConvert.SerializeXmlNode(doc);
                return jsonText;
            }
            catch (XmlException e) {
                return null;
            } 
        }
    }
}
