using SalesStockAnalyzer.Models;
using System.Xml.Linq;

namespace SalesStockAnalyzer.Handlers
{
    public class XmlHandler
    {
        public XDocument ReadXml(string filePath)
        {
            return XDocument.Load(filePath);
        }

        public ProductsModel XmlDeserializer(XDocument xml)
        {
            var products = new ProductsModel();

            foreach (var element in xml.Root.Elements("Product"))
            {
                var product = new ProductModel 
                { 
                    Id = (int)element.Attribute("id"), 
                    Name = (string)element.Element("Name")

                };

                products.Products.Add(product);
            }

            return products;
        }
    }
}
