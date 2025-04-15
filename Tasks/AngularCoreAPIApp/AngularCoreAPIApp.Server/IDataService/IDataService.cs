using AngularCoreAPIApp.Server.Models;
using AngularCoreAPIApp.Server.ReuestDTO;

namespace AngularCoreAPIApp.Server.IDataService
{
    public interface IDataService
    {
        public List<Category> GetAllCategory();

        public Category GetCategoryById(int id);

        public Category GetFirstCategory();

        public List<Category> GetCategoryByName(string name);

        public bool deleteCategory(int id);

        public void AddCategory(ReqDTO category);

        public bool updateCategory(int id, ReqDTO category);


        public Product GetProductById(int id);

        public bool deleteProduct(int id);

        public List<Product> GetAllProduct();

        public void AddProduct(ReqDTO product);

        public bool updateProduct(int id, ReqDTO productFromUser);



    }
}
