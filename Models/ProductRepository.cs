namespace Turkcell.Models
{
    public class ProductRepository
    {

        /*   private static List<Product> _products = new List<Product>()
           {
               new() { ProductId = 1, ProductName = "Kalem", Price = 100, Stock = 20 },
                new () { ProductId = 2, ProductName = "Silgi", Price = 100, Stock = 20 },
                   new () { ProductId = 3, ProductName = "Kurşun Kalem", Price = 100, Stock = 20 }
           };

           public List<Product> GetAll() => _products;

           public void Add(Product newProduct) => _products.Add(newProduct);
           public void Remove(int id)
           {
               var hasproduct = _products.FirstOrDefault(x => x.ProductId == id);
               if(hasproduct == null)
               {
                   throw new Exception("Bu id ait ürün yktur.");

               }

               _products.Remove(hasproduct);
           }


           public void Update(Product updateProduct)
           {
               var hasProduct = _products.FirstOrDefault(x => x.ProductId == updateProduct.ProductId);
               if(hasProduct == null)
               {
                   throw new Exception("böyle bir urun yoktur.");
               }

               hasProduct.ProductName =updateProduct.ProductName;
               hasProduct.Price = updateProduct.Price;
               hasProduct.Stock= updateProduct.Stock;

               var index = _products.FindIndex(x => x.ProductId == updateProduct.ProductId);
               _products[index] =hasProduct;
           **/
    }


}
    