using Domain.Models.Products;

namespace Domain.IRepositories
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        public List<string> GetUniqueCategories();
        public List<Product> GetProductsByCategory(string category);



    }
}
