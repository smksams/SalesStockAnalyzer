namespace SalesStockAnalyzer.Models
{
    public class ProductModel
    {
        public int ?Id { get; set; }
        public string ?Name { get; set; }
        public DetailsModel ?Details { get; set; }
        public SalesInformationModel ?SalesInformation { get; set; }
        public DateTime ?ModificationDate { get; set; }
    }
}