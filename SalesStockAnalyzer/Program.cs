using SalesStockAnalyzer.Handlers;
using System.Globalization;
using System.Xml.Linq;
using Microsoft.Extensions.Configuration;

namespace SalesStockAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var xmlHandler = new XmlHandler();
            var doc = xmlHandler.ReadXml();
            var xml = xmlHandler.XmlDeserializer(doc);
            Console.WriteLine(xml.Products.First().Name);
        }
    }
}
