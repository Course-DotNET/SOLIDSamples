using System.Collections.Generic;
using System.Linq;

namespace SOLIDExamples.OSP
{
    public enum Color
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Big
    }

    public class Product
    {
        public Product(string name, Size size, Color color)
        {
            Name = name;
            Size = size;
            Color = color;
        }

        public string Name { get; }
        public Size Size { get; }
        public Color Color { get; }
    }


    public interface IFilterCriteria<T>
    {
        bool IsSatisfied(T p);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> products, IFilterCriteria<T> criteria);
    }

    public class ProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products, IFilterCriteria<Product> criteria)
        {
            return products.Where(criteria.IsSatisfied);
        }
    }

    public class CombinedFilterCriteria : IFilterCriteria<Product>
    {
        private readonly IEnumerable<IFilterCriteria<Product>> criteries;

        public CombinedFilterCriteria(IEnumerable<IFilterCriteria<Product>> criteries)
        {
            this.criteries = criteries;
        }

        public bool IsSatisfied(Product p)
        {
            return criteries.All(item => item.IsSatisfied(p));
        }
    }

    public class SizeFilterCriteria : IFilterCriteria<Product>
    {
        private Size size;

        public SizeFilterCriteria(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(Product p)
        {
            return p.Size == size;
        }
    }

    public class ColorFilterCriteria : IFilterCriteria<Product>
    {
        private Color color;

        public ColorFilterCriteria(Color color)
        {
            this.color = color;
        }

        public bool IsSatisfied(Product p)
        {
            return p.Color == color;
        }
    }

    public class OCPBad
    {
        public void Main()
        {
            var products = new List<Product>();
            products.Add(new Product("Apple", Size.Small, Color.Green));
            products.Add(new Product("Pepper", Size.Medium, Color.Red));
            products.Add(new Product("Apple", Size.Big, Color.Red));

            var filter = new ProductFilter();
            var smallProducts = filter.Filter(products, new SizeFilterCriteria(Size.Small));
            var redProducts = filter.Filter(products, new ColorFilterCriteria(Color.Red));
            var criteries = new List<IFilterCriteria<Product>>()
            {

            };
            var combined = new CombinedFilterCriteria(criteries);
            var redAndSmallProducts = filter.Filter(products, combined);

        }
    }
}