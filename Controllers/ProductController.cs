using Microsoft.AspNetCore.Mvc;
using Turkcell.Models;

namespace Turkcell.Controllers
{
    public class ProductController : Controller
    {

        private Context _context;
        private readonly ProductRepository _productRepository;
        // bir viewden başka bir viewe data taşımak için tempdata kullanırız.
        // İhtiyac duyduğu nesneyi Constructar ile alıyors biz buna depencedy Injection deriz. = design pattern
        public ProductController(Context context)
        {
            //DI  Container
            // DepenDENCY Injection Pattern = bağımlılıkların yönetilmesi ile ilgili çözümler sunar. 
            //Constructr veya metoda ihtiyac duyduğumuz classı alabilmemizi sağlar bunu DI Container ile yaparız.
            /*   if(!_context.Products.Any())
               {
                    MANUEL Veri Girişi
                      _context.Add( new() { ProductId = 1, ProductName = "Kalem", Price = 100, Stock = 20 });
                        _context.Add(  new() { ProductId = 2, ProductName = "Silgi", Price = 100, Stock = 20 });
                           _context.Add(  new() { ProductId = 3, ProductName = "Kurşun Kalem", Price = 100, Stock = 20 });

            _context.SaveChanges();

               } */
            _productRepository = new  ProductRepository();
            _context = context;
           
        }
         

        public IActionResult Index()
        {
            //   var product = _productRepository.GetAll();
            var product = _context.Products.ToList();
            return View(product);
        }

        public IActionResult Remove(int id)
        {
            var product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
          //  _productRepository.Remove(id);
            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveProduct(Product product)
        {

            _context.Products.Add(product);
            _context.SaveChanges();
            TempData["status"] = "Ürün başarıyla Eklendi";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            // find ile primary key olan id getir. ve viewe gönder
            var product = _context.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Update(Product product , int productId)
        {
           product.ProductId = productId;
            _context.Products.Update(product);
            _context.SaveChanges();
            TempData["status"] = "Ürün başarıyla Güncellendi";
            return RedirectToAction("Index");
        }
    }
}
