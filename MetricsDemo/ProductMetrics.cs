using System.Diagnostics.Metrics;

namespace MetricsDemo
{
    public class ProductMetrics
    {
        private readonly Counter<int> _soldProductsCount;

        public ProductMetrics(IMeterFactory meterFactory)
        {
            var meterInstance = meterFactory.Create("MetricsDemo.ProductStore");
            _soldProductsCount = meterInstance.CreateCounter<int>("metricsdemo.productstore.sold_products_count");
        }

        public void CountProductsSold(int quantity)
        {
            _soldProductsCount.Add(quantity);
        }
    }
}