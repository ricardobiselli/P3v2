using Domain.Enums;
using Domain.IRepositories;
using Domain.Models.Products;

namespace Infrastructure.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public  List<string> GetUniqueCategories()
        {
            return  _context.Products
                .Where(p => p.State == EntitiesState.Active) // Filtrar productos activos
                .Select(p => p.Category)
                .Distinct()
                .Where(c => !string.IsNullOrEmpty(c)) // Excluir categorías nulas o vacías
                .ToList();
        }

        public List<Product> GetProductsByCategory(string category)
        {
            if (string.IsNullOrEmpty(category))
            {
                return _context.Products.ToList(); // Devuelve todos los productos si no hay categoría
            }

            return _context.Products.Where(p => p.Category == category).ToList(); // Filtra por categoría
        }

    }
}

