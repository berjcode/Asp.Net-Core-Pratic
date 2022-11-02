using MessagePack;

using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace Turkcell.Models
{
    public class Product
    {
        // nnull değerler için ? koy. string ifadeler içinde koymak gerekir. .net 6 ile gelen bir özelliktir.
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
