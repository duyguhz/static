using System;
namespace StoreClasses
{
   internal interface IStore
    {
        Product[] products { get; }
        int ProductLimit { get; set; }
        double TotalIncome { get; set; }
        void AddProduct(Product product);
        void SellProduct(string no);
    }
}
