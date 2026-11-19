using Microsoft.Extensions.Configuration;

namespace SalesStockAnalyzer.Handlers
{
    public class ConfigurationHandler
    {
        public string XmlFilePath { get; private set; } = string.Empty;

        public void GetXmlFilePath(IConfiguration configuration)
        {
            XmlFilePath = Path.Combine(AppContext.BaseDirectory, configuration["AppConfig:XmlFilePath"]);
        }
    }
}
