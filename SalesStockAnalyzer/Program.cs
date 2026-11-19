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
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("AppSettings.json")
            .Build();

            var configurationHandler = new ConfigurationHandler();
            configurationHandler.GetXmlFilePath(configuration);


            var xmlHandler = new XmlHandler();
            var doc = xmlHandler.ReadXml(configurationHandler.XmlFilePath);
            var xml = xmlHandler.XmlDeserializer(doc);
            Console.WriteLine(xml.Products.First().Name);
        }
    }
}
