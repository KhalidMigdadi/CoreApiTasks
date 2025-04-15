using AngularCoreAPIApp.Server.Models;
using AngularCoreAPIApp.Server.ReuestDTO;

namespace AngularCoreAPIApp.Server.DataSevice
{
    public class DataService : AngularCoreAPIApp.Server.IDataService.IDataService
    {

        private readonly MyDbContext _context;

        public DataService(MyDbContext context)
        {
            _context = context;
        }
        public List<Category> GetAllCategory()
        {
            var cat = _context.Categories.ToList();

            return cat;

        }


        public Category GetCategoryById(int id)
        {
            var categoryID = _context.Categories.Find(id);

            return categoryID; // status 200 
        }



        public Category GetFirstCategory()
        {
            var categoryID = _context.Categories.First();
            return categoryID;
        }


        public List<Category> GetCategoryByName(string name)
        {
            var categoryName = _context.Categories.Where(c => c.Name == name).ToList();



            return categoryName;
        }


        public bool deleteCategory(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
                return true;
            }
            return false;

        }



        public void AddCategory(ReqDTO category)
        {
            var cat = new Category()
            {
                Name = category.Name,
                Description = category.Description,
            };
            _context.Categories.Add(cat);
            _context.SaveChanges();
        }


        public bool updateCategory(int id, ReqDTO categoryFromUser)
        {
            var category = _context.Categories.Find(id);

            if (category == null)
                return false;

            category.Name = categoryFromUser.Name;
            category.Description = categoryFromUser.Description;

            _context.Categories.Update(category);
            _context.SaveChanges();

            return true;

        }





        public List<Product> GetAllProduct()

        {
            var products = _context.Products.ToList();

            return products;
        }


        public Product GetProductById(int id)
        {
            var productById = _context.Products.SingleOrDefault(p => p.Id == id);


            return productById;


        }


        public bool deleteProduct(int id)
        {
            var product = _context.Categories.Find(id);
            if (product != null)
            {
                _context.Categories.Remove(product);
                _context.SaveChanges();
                return true;
            }
            return false;

        }


        public void AddProduct(ReqDTO product)
        {
            var pro = new Product()
            {
                Name = product.Name,
                Description = product.Description,
            };
            _context.Products.Add(pro);
            _context.SaveChanges();
        }


        public bool updateProduct(int id, ReqDTO productFromUser)
        {
            var product = _context.Products.Find(id);

            if (product == null)
                return false;

            product.Name = productFromUser.Name;
            product.Description = productFromUser.Description;

            _context.Products.Update(product);
            _context.SaveChanges();

            return true;

        }


    }
}
