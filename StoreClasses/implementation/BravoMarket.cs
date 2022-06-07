using System;
namespace StoreClasses.implementation
{
    public class BravoMarket : IStore
    {
        private Product[] _products;

        public Product[] Products => _products;
        private double _totalIncome;
        public int ProductLimit { get; set; }
        public double TotalIncome => _totalIncome;

        public void AddProduct(Product product)
        {
            if (ProductLimit > _products.Length && !IsExistProductByNo(product.No))
            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = product;
            }
        }


        public void SellProduct(string no)
        {
            Product product = FindProductByNo(no);
            if (product.Count>0)
            {
                _totalIncome += product.Price;
                product.Count--;
            }

        }


        public Product FindProductByNo(string no)
        {
            Product product = null;
            foreach (var pr in _products)
            {
                if (pr.No == no)
                {
                    product = pr;
                    break;
                }
            }
            return product;
        }
        public bool IsExistProductByNo(string no)
        {
            foreach (var pr in _products)
            {
                if (pr.No == no)
                {

                    return true;
                }
            } return false;
        }
    } }
