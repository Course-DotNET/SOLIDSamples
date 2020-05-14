using System.Collections.Generic;
using System.Linq;

namespace SOLIDExamples.OSPBad
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

        public string Name { get;  }
        public Size Size { get; }
        public Color Color { get;  }
    }

    public static class ProductFilter
    {
        public static IEnumerable<Product> FilterByName(IEnumerable<Product> products, string name)
        {
            return products.Where(product => product.Name == name);
        }
        public static IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            return products.Where(product => product.Color == color);
        }

        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            return products.Where(product => product.Size == size);
        }

        public static IEnumerable<Product> FilterByColorAndSize(IEnumerable<Product> products, Color color, Size size)
        {
            return products.Where(product => product.Size == size && product.Color == color);
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

            var redProducts = ProductFilter.FilterByColor(products, Color.Red);
            var smallProducts = ProductFilter.FilterBySize(products, Size.Small);
        }
    }
}